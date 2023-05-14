using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.WinForms;
using System.Diagnostics;
using System.Drawing.Printing;

namespace GUI
{
    public partial class AccountantManagement : Form
    {
        BUS_ExportReceiptDetails exportReceiptDetails;
        BUS_ExportReceipt exportReceipt;
        BUS_ResellerImportReceiptDetails resellerReceiptDetails;
        BUS_Reseller reseller;
        BUS_ResellerImportReceipt resellerBill;
        BUS_Accountant acc;
        BUS_Receipt receipt;
        BUS_ReceiptDetails receiptDetails;
        BUS_WarehouseProducts warehouseProducts;

        PrintPreviewDialog printPreviewDialog3 = new PrintPreviewDialog();
        PrintPreviewDialog printPreviewDialog4 = new PrintPreviewDialog();
        PrintDocument printDocument3 = new PrintDocument();
        PrintDocument printDocument4 = new PrintDocument();
        public AccountantManagement()
        {
            InitializeComponent();
        }
        private string accountantName, accountantEmail, accountantPassword;
        private int accountantID, warehouseID;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public AccountantManagement(string email, string password)
        {
            InitializeComponent();
            acc = new BUS_Accountant(0, "", email, password, 0);
            accountantName = acc.selectName().Rows[0][0].ToString();
            accountantID = (int)acc.selectID().Rows[0][0];
            warehouseID = (int)acc.selectWarehouse().Rows[0][0];
            accountantEmail = email;
            accountantPassword = password;
        }
        private void AccountantManagement_Load(object sender, EventArgs e)
        {
            printPreviewDialog3.Document = printDocument3;
            printPreviewDialog4.Document = printDocument4;
            printDocument3.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage3);
            printDocument4.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage4);
            label_welcome.Text = "Wellcome!!! " + accountantName;
        }
        private void loadPhoneTable()
        {
            BUS_Phone phone = new BUS_Phone();
            DataTable table = phone.selectPhone();

            grdPhone.DataSource = table;
            grdPhone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void bAccountant_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel_accDB.Visible = true;
            loadDashboard();
        }

        private void bProduct_Click(object sender, EventArgs e)
        {
            loadPhoneTable();
            loadPhonePie();
            panel_accDB.Visible = false;
            panel_phone.Visible = true;

            bProduct.Visible = false;
            bBack2.Visible = true;
        }

        private void bBack_Click_1(object sender, EventArgs e)
        {
            panel_accDB.Visible = false;
            panel_phone.Visible = false;
            panel1.Visible = true;
        }

        private void bBack2_Click(object sender, EventArgs e)
        {
            panel_phone.Visible = false;
            panel_accDB.Visible = true;
            loadDashboard();
        }

        private void bPrintER_Click(object sender, EventArgs e)
        {
            if (grd_ER.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Export Receipt.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd_ER.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in grd_ER.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in grd_ER.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Receipt Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void grd_ER_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_ER.CurrentRow != grd_ER.Rows[grd_ER.Rows.Count - 1])
            {
                int id = (int)grd_ER.CurrentRow.Cells[0].Value;
                exportReceiptDetails = new BUS_ExportReceiptDetails(id);
                DataTable tableIRD = exportReceiptDetails.selectExportReceiptDetails();
                grd_ERD.DataSource = tableIRD;
                grd_ERD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void loadExportReceipt()
        {
            exportReceipt = new BUS_ExportReceipt(accountantID);
            DataTable table = exportReceipt.getReceipt();

            grd_ER.DataSource = table;
            grd_ER.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void bPrintERD_Click(object sender, EventArgs e)
        {
            if (grd_ERD.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Export Receipt Details.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd_ERD.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in grd_ERD.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in grd_ERD.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Receipt Detail Exported Successfully", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void printExportReceipt(Graphics g)
        {
            int cellHeight = 40;
            int cellWidthPadding = 5;
            int cellHeightPadding = 5;

            int y = 0;
            int x = 0;

            for (int i = 0; i < grd_ER.RowCount; i++)
            {
                x = 0;
                for (int j = 0; j < grd_ER.ColumnCount; j++)
                {
                    System.Drawing.Rectangle cellBounds = new System.Drawing.Rectangle(x, y, grd_ER.Columns[j].Width - cellWidthPadding, cellHeight - cellHeightPadding);

                    g.DrawString(grd_ER[j, i].FormattedValue.ToString(), grd_ER.Font, Brushes.Black, cellBounds);

                    x += grd_ER.Columns[j].Width;
                }
                y += cellHeight;
            }
        }

        private void printExportReceiptDetail(Graphics g)
        {
            int cellHeight = 40;
            int cellWidthPadding = 5;
            int cellHeightPadding = 5;

            int y = 0;
            int x = 0;

            for (int i = 0; i < grd_ERD.RowCount; i++)
            {
                x = 0;
                for (int j = 0; j < grd_ERD.ColumnCount; j++)
                {
                    System.Drawing.Rectangle cellBounds = new System.Drawing.Rectangle(x, y, grd_ERD.Columns[j].Width - cellWidthPadding, cellHeight - cellHeightPadding);

                    g.DrawString(grd_ERD[j, i].FormattedValue.ToString(), grd_ERD.Font, Brushes.Black, cellBounds);

                    x += grd_ERD.Columns[j].Width;
                }
                y += cellHeight;
            }
        }

        private void printDocument1_PrintPage3(object sender, PrintPageEventArgs e)
        {
            printExportReceipt(e.Graphics);
        }

        private void printDocument1_PrintPage4(object sender, PrintPageEventArgs e)
        {
            printExportReceiptDetail(e.Graphics);
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;

            loadExportReceipt();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private SKColor GetRandomColor()
        {
            Random random = new Random();
            return new SKColor((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255));
        }


        private void loadPhonePie()
        {
            List<string> labels = new List<string>();
            List<int> export = new List<int>();
            List<int> import = new List<int>();

            foreach (DataGridViewRow row in grdPhone.Rows)
            {
                if (!row.IsNewRow)
                {
                    labels.Add(row.Cells[0].Value.ToString() + ":");
                    if (row.Cells[2].Value != DBNull.Value)
                    {
                        import.Add((int)row.Cells[2].Value);
                    }
                    else
                    {
                        import.Add(0);
                    }
                    if (row.Cells[3].Value != DBNull.Value)
                    {
                        export.Add((int)row.Cells[3].Value);
                    }
                    else
                    {
                        export.Add(0);

                    }
                }
            }

            List<PieSeries<int>> pieSeriesList = new List<PieSeries<int>>();

            for (int i = 0; i < 5; i++)
            {
                PieSeries<int> pieSeries = new PieSeries<int>
                {
                    Values = new List<int> { import[i] },
                    Name = labels[i],
                    Stroke = null,
                    IsVisible = Convert.ToBoolean(import[i]),
                    Fill = new SolidColorPaint(GetRandomColor()),
                };
                pieSeriesList.Add(pieSeries);
            }

            pieChart2.Series = pieSeriesList.ToArray();

            List<PieSeries<int>> pieSeriesList_1 = new List<PieSeries<int>>();

            for (int i = 0; i < 5; i++)
            {
                PieSeries<int> pieSeries_1 = new PieSeries<int>
                {
                    Values = new List<int> { export[i] },
                    Name = labels[i],
                    Stroke = null,
                    IsVisible = Convert.ToBoolean(export[i]),
                    Fill = new SolidColorPaint(GetRandomColor()),
                };
                pieSeriesList_1.Add(pieSeries_1);
            }

            pieChart3.Series = pieSeriesList_1.ToArray();
        }

        private void loadDashboard()
        {
            acc = new BUS_Accountant(accountantID, accountantName, accountantEmail, accountantPassword, warehouseID);
            grdDB.DataSource = acc.selectProfit();

            List<string> labels = new List<string>();
            List<int> export = new List<int>();
            List<int> import = new List<int>();
            int totalExport = 0;
            int totalImport = 0;

            foreach (DataGridViewRow row in grdDB.Rows)
            {
                if (!row.IsNewRow)
                {
                    labels.Add(row.Cells[1].Value.ToString().Substring(0, 9));
                    export.Add((int)row.Cells[2].Value);
                    import.Add((int)row.Cells[3].Value);
                    totalExport += (int)row.Cells[2].Value;
                    totalImport += (int)row.Cells[3].Value;

                    Debug.WriteLine(row.Cells[1].Value.ToString());
                }
            }

            cartesianChart1.Series = new ISeries[]{
                new LineSeries<int>
                {
                    Values = export,
                    Fill = new SolidColorPaint(SKColors.Blue),
                    Stroke = null,
                    Name = "Income: "

                },
                new LineSeries<int>
                {
                    Values = import,
                    Fill = new SolidColorPaint(SKColors.Red),
                    Stroke = null,
                    Name = "Outcome: "
                }
            };

            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Labels = labels,
                    TextSize = 20,
                }
            };
            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    TextSize = 20,
                }
            };

        }



    }
}
