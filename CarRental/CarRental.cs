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
        double totalprice = 0.00;
        void SetDefaults()
        {
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipcodeTextBox.Text = "";
            BeginOdometerTextBox.Text = "";
            EndOdometerTextBox.Text = "";
            DaysTextBox.Text = "";
            TotalDistanceTextBox.Text = "";
            MileageCostTextBox.Text = "";
            DailyChargeTextBox.Text = "";
            MinusDiscountsTextBox.Text = "";
            YouOweTextBox.Text = "";
            AAADiscount.Checked = false;
            SeniorDiscount.Checked = false;
            MilesRadioButton.Checked = true;
        }
        void ValidateInputs() 
        { 
            
        }
        void CalculateTotals() 
        {
            DailyCharge();
            MilageCharge();
            TotalDiscounts();
            YouOweTextBox.Text = $"${totalprice}";
        }
        private double KilometersToMiles(double miles) 
        {
            
            return miles * 0.62;
        }
        void DailyCharge() 
        {
            double days = double.Parse(DaysTextBox.Text);
            double dayscost = Math.Round((15.00 * days), 2);
            totalprice += dayscost;
            DailyChargeTextBox.Text = $"$ {dayscost}";
        }
        void MilageCharge() 
        { 
            int max = 0;
            int min = 0;
            double miles = 0;
            double milescost = 0;
            
            max = int.Parse(EndOdometerTextBox.Text);
            min = int.Parse(BeginOdometerTextBox.Text);
            miles = max - min;
            if (KmRadioButton.Checked == true)
            {
                KilometersToMiles(miles);
            }

            if (miles <= 200)
            {
                milescost = 0;
            }
            else if (201 <= miles && miles <= 500) 
            {
                milescost = miles * 0.12;
            }
            else if (miles > 500) 
            {
                milescost = miles * 0.10;
            }

            TotalDistanceTextBox.Text = $"{miles} mi";
            MileageCostTextBox.Text = $"${milescost}";
            totalprice += milescost;
        }
        void TotalDiscounts() 
        {
            double discount = 0;
            double totalDiscount = 0;
            if (AAADiscount.Checked == true) 
            {
                discount += 0.05;
            }
            if (SeniorDiscount.Checked == true) 
            {
                discount += 0.03;
            }

            totalDiscount = Math.Round((totalprice * discount),2);

            MinusDiscountsTextBox.Text = $"${totalDiscount}";
            totalprice -= totalDiscount;
        }
        
        void Summary() 
        { 
            
        }

        void ExitProgram() 
        {
            DialogResult results = MessageBox.Show("Do you Wish to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (results == DialogResult.Yes)
            {
                this.Close();
            }
            else 
            {
                
            }
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
