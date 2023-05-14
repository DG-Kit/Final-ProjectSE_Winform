namespace DTO
{
    public class DTO_Reseller
    {
        private int ResellerID;


        public int _ResellerID
        {
            get
            {
                return ResellerID;
            }
            set
            {
                ResellerID = value;
            }
        }



        public DTO_Reseller(int ResellerID)
        {
            this.ResellerID = ResellerID;
        }
    }
}