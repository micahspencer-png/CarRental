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
            SummaryButton.Enabled = false;
        }
        //ProgramLogic------------------------------------------------------------------------------------------------------

        int customers = 0;
        double mileage = 0.00;
        double charges = 0.00;
        double totalprice = 0.00;
        double totalmiles = 0.00;
        
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
            //sets the default state as empty textboxes
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
            //sets all variables as correct, then changes them if they are actually incorrect
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

            //will validate as long as the boxes aren't empty
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

            //will validate as long as a state is selected
            if (StateComboBox.SelectedIndex == 0) 
            { 
                allFieldsAreValid = false;
                StateComboBox.BackColor = Color.LightYellow;
                stateValid = false;
            }

            //will validate as long as the values are numbers, not strings
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
            //runs a comparison so that the end odometer reading can't be below beginning odometer reading
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

             //sets global variables so that the error function knows what specifically is invalid
             NameValid = nameValid;
             AddressValid = addressValid;
             CityValid = cityValid;
             StateValid = stateValid;
             ZipcodeValid = zipcodeValid;
             BeginodometerValid = beginodometerValid;
             EndodometerValid = endodometerValid;
             OdometerValid = odometerValid;
             DaysValid = daysValid;

            //runs calculations if everything is valid and displays error message if it isn't
            if (allFieldsAreValid == true)
            {
                CalculateTotals();
            }
            else 
            {
                Error();
            }
        }
        private double KilometerToMiles(ref double difference) 
        {
            //converts the odometer difference to miles if km was selected
            difference = Math.Round((difference * 0.62), 2);
            return difference;
        }
        void Error() 
        {
            //this section tells user what is wrong with the validation in a message box and clears the incorrect data, 
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
            //clears any previous calculations and then calculates new totals
            SubmitButton.Enabled = true;
            totalprice = 0.00;
            DailyCharge();
            MilageCharge();
            TotalDiscounts();
            totalprice = Math.Round(totalprice, 2);
            //displays total in text box
            YouOweTextBox.Text = $"${totalprice}";
        }
        void DailyCharge() 
        {
            double days = double.Parse(DaysTextBox.Text);
            // sets the daily charge to $15 and adds it to total price
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
            
            //gets the difference on the odometer
            max = int.Parse(EndOdometerTextBox.Text);
            min = int.Parse(BeginOdometerTextBox.Text);
            difference = max - min;
            
            if (KmRadioButton.Checked == true)
            {
                //runs km to mi converter
                KilometerToMiles(ref difference);
                miles = difference;
            }
            else 
            {
                miles = difference;
            }

            //sets 0-200 miles as free
            if (miles <= 200)
            {
                milescost = 0;
            }
            //sets 201-500 miles as $0.12 per mile
            else if (201 <= miles && miles <= 500)
            {
                milescost = miles * 0.12;
            }
            //sets 500+ miles as $0.10 per mile
            else if (miles > 500)
            {
                milescost = miles * 0.10;
            }

            //sets the total miles for the summary
            mileage = miles;

            milescost = Math.Round(milescost, 2);
            //displays the total number of miles and the total mileage cost
            TotalDistanceTextBox.Text = $"{miles} mi";
            MileageCostTextBox.Text = $"${milescost}";
            //adds mileage cost to total price
            totalprice += milescost;
        }
        void TotalDiscounts() 
        {
            double discount = 0;
            double totalDiscount = 0;
            
            //adds a 5% discount if there is an AAA membership
            if (AAADiscount.Checked == true) 
            {
                discount += 0.05;
            }

            //adds a 3% discount if user is a senior citizen
            if (SeniorDiscount.Checked == true) 
            {
                discount += 0.03;
            }

            //calculates the total savings
            totalDiscount = Math.Round((totalprice * discount),2);
            //displays the total savings
            MinusDiscountsTextBox.Text = $"${totalDiscount}";
            //removes the savings from the total price
            totalprice -= totalDiscount;
        }

        void SubmitData() 
        {
            //saves the number of customers, total miles, and total charges for the summary to pull up
            customers += 1;
            totalmiles += mileage;
            totalmiles = Math.Round(totalmiles, 2);
            charges += totalprice;
            charges = Math.Round(charges, 2);
        }
        
        void Summary() 
        {
            //creates a string that holds all of the data
            string Summary = "";
            Summary += $"Number of Customers:     {customers}     \n";
            Summary += $"Total Miles Driven:       {totalmiles} miles      \n";
            Summary += $"Total Charges:         ${charges}      \n";

            //creates a message box that shows the total saved data
            MessageBox.Show($"{Summary}", "Customer Summary");
        }

        void ExitProgram() 
        {
            //creates a messagebox that prompts the user
            DialogResult results = MessageBox.Show("Do you Wish to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (results == DialogResult.Yes)
            {
                //closes program on "yes"
                this.Close();
            }
            else 
            {
                //keeps program running and closes the message box on "no"
            }
        }
        //EventHandlers-----------------------------------------------------------------------------------------------------
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //checks the inputs for any problems then calculates the cost
            ValidateInputs();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //sets the default data in the text boxes, but doesn't reset the summary
            SetDefaults();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //displays summary message box
            Summary();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //runs message box to leave program
            ExitProgram();
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //submits needed data to summary
            SubmitData();

            //clears output display to show that it is a new customer
            TotalDistanceTextBox.Text = "";
            MileageCostTextBox.Text = "";
            DailyChargeTextBox.Text = "";
            MinusDiscountsTextBox.Text = "";
            BeginOdometerTextBox.Text = "";
            EndOdometerTextBox.Text = "";
            DaysTextBox.Text = "";
            YouOweTextBox.Text = "";
            
            //enables summary button and doesn't allow a second submit
            SummaryButton.Enabled = true;
            SubmitButton.Enabled = false;
        }

    }
}
