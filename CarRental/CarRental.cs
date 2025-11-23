using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        
        bool NameValid;
        bool AddressValid;
        bool CityValid;
        bool StateValid;
        bool ZipcodeValid;
        bool BeginodometerValid;
        bool EndodometerValid;
        bool OdometerValid;
        bool DaysValid;
        void SetDefaults()
        {
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateComboBox.SelectedIndex = 0;
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
            SubmitButton.Enabled = false;
        }
        void ValidateInputs() 
        {
            int end = 0;
            int begin = 0;
            NameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StateComboBox.BackColor = Color.White;
            ZipcodeTextBox.BackColor = Color.White;
            BeginOdometerTextBox.BackColor = Color.White;
            EndOdometerTextBox.BackColor = Color.White;
            DaysTextBox.BackColor = Color.White;
            bool allFieldsAreValid = true;
            bool nameValid = true;
            bool addressValid = true;
            bool cityValid = true;
            bool stateValid = true;
            bool zipcodeValid = true;
            bool beginodometerValid = true;
            bool endodometerValid = true;
            bool odometerValid = true;
            bool daysValid = true;

            if (NameTextBox.Text == "")
            {
                allFieldsAreValid = false;
                NameTextBox.BackColor = Color.LightYellow;
                nameValid = false;
            }

            if (AddressTextBox.Text == "")
            {
                allFieldsAreValid = false;
                AddressTextBox.BackColor = Color.LightYellow;
                addressValid = false;
            }

            if (CityTextBox.Text == "")
            {
                allFieldsAreValid = false;
                CityTextBox.BackColor = Color.LightYellow;
                cityValid = false;
            }

            if (StateComboBox.SelectedIndex == 0) 
            { 
                allFieldsAreValid = false;
                StateComboBox.BackColor = Color.LightYellow;
                stateValid = false;
            }

            try
            {
                int zip = int.Parse(ZipcodeTextBox.Text); 
               
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                ZipcodeTextBox.BackColor = Color.LightYellow;
                zipcodeValid = false;

            }

            try
            {
                begin = int.Parse(BeginOdometerTextBox.Text);

            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                BeginOdometerTextBox.BackColor = Color.LightYellow;
                beginodometerValid = false;

            }

            try
            {
                end = int.Parse(EndOdometerTextBox.Text);
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                EndOdometerTextBox.BackColor = Color.LightYellow;
                endodometerValid = false;

            }

            if (end < begin)
            {
                allFieldsAreValid = false;
                BeginOdometerTextBox.BackColor = Color.LightYellow;
                EndOdometerTextBox.BackColor = Color.LightYellow;
                odometerValid = false;
            }

            try
            {
                int days = int.Parse(DaysTextBox.Text);
                if (days <= 0 || days > 45)
                {
                    allFieldsAreValid = false;
                    DaysTextBox.BackColor = Color.LightYellow;
                    daysValid = false;
                }
            }
            catch (Exception)
            {
                allFieldsAreValid = false;
                DaysTextBox.BackColor = Color.LightYellow;
                daysValid = false;
            }

             
             NameValid = nameValid;
             AddressValid = addressValid;
             CityValid = cityValid;
             StateValid = stateValid;
             ZipcodeValid = zipcodeValid;
             BeginodometerValid = beginodometerValid;
             EndodometerValid = endodometerValid;
             OdometerValid = odometerValid;
             DaysValid = daysValid;


            if (allFieldsAreValid == true)
            {
                CalculateTotals();
            }
            else 
            {
                Error();
            }
        }

        void Error() 
        {
            string message = "";
            if (DaysValid == false)
            {
                DaysTextBox.Text = "";
                DaysTextBox.Focus();
                message += "Days are Invalid\n";
            }

            if (OdometerValid == false)
            {
                EndOdometerTextBox.Text = "";
                EndOdometerTextBox.Focus();
                message += "Ending Odometer Reading Can't be Lower than Beginning Odometer Reading\n";
            }

            if (EndodometerValid == false)
            {
                EndOdometerTextBox.Text = "";
                EndOdometerTextBox.Focus();
                message += "Ending Odometer Reading is Invalid\n";
            }

            if (BeginodometerValid == false)
            {
                BeginOdometerTextBox.Text = "";
                BeginOdometerTextBox.Focus();
                message += "Beginning Odometer Reading is Invalid\n";
            }

            if (ZipcodeValid == false)
            {
                ZipcodeTextBox.Text = "";
                ZipcodeTextBox.Focus();
                message += "Zipcode is Invalid\n";
            }

            if (StateValid == false)
            {
                StateComboBox.SelectedIndex = 0;
                StateComboBox.Focus();
                message += "State isn't Selected\n";
            }

            if (CityValid == false)
            {
                CityTextBox.Text = "";
                CityTextBox.Focus();
                message += "City is Invalid\n";
            }

            if (AddressValid == false)
            {
                AddressTextBox.Text = "";
                AddressTextBox.Focus();
                message += "Address is Invalid\n";
            }

            if (NameValid == false)
            {
                NameTextBox.Text = "";
                NameTextBox.Focus();
                message += "Name is Invalid\n";
            }

            string[] messageArray;
            messageArray = message.Split("\n");
            string messages = "";
            for (int i = messageArray.GetUpperBound(0); i >= 0; i--)
            {
                messages += messageArray[i] + "\n";
            }
            MessageBox.Show($"{messages}");
        }
        void CalculateTotals() 
        {
            SubmitButton.Enabled = true;
            totalprice = 0.00;
            DailyCharge();
            MilageCharge();
            TotalDiscounts();
            YouOweTextBox.Text = $"${totalprice}";
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
            double difference = 0;
            
            max = int.Parse(EndOdometerTextBox.Text);
            min = int.Parse(BeginOdometerTextBox.Text);
            difference = max - min;
            if (KmRadioButton.Checked == true)
            {
                miles = difference * 0.62;
            }
            else if (MilesRadioButton.Checked == true)
            {
                miles = difference;
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

            milescost = Math.Round(milescost, 2);
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
            ValidateInputs();
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
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
            SummaryButton.Enabled = true;
            SubmitButton.Enabled = false;
        }

    }
}
