namespace CarRental
{
    //Micah Spencer
    //RCET2265
    //Fall 2025
    //Car Rental Form Program
    //https://github.com/micahspencer-png/CarRental.git
    public partial class CarRental : Form
    {
        public CarRental()
        {
            InitializeComponent();
            SetDefaults();
        }
        //ProgramLogic------------------------------------------------------------------------------------------------------

        int customers = 0;
        double miles = 0.00;
        double charges = 0.00;
        void SetDefaults()
        {
               
        }
        void ValidateInputs() 
        { 
            
        }
        void CalculateTotals() 
        {
            DailyCharge();
            MilageCharge();
            TotalDiscounts();
        }
        void DailyCharge() 
        { 
        
        }
        void MilageCharge() 
        { 
        
        }
        void TotalDiscounts() 
        {
            AAADiscountAdd();
            SeniorDiscountAdd();
        }
        void AAADiscountAdd() 
        { 
        
        }
        void SeniorDiscountAdd() 
        { 
        
        }
        void Summary() 
        { 
            
        }

        void ExitProgram() 
        { 
        
        }
        //EventHandlers-----------------------------------------------------------------------------------------------------
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            Summary();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            ValidateInputs();
        }
    }
}
