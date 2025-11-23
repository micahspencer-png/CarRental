namespace CarRental
{
    partial class CarRental
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            StateComboBox = new ComboBox();
            StateLabel = new Label();
            DaysLabel = new Label();
            DaysTextBox = new TextBox();
            CityLabel = new Label();
            EndOdometerLabel = new Label();
            AddressLabel = new Label();
            NameLabel = new Label();
            BeginOdometerLabel = new Label();
            ZipcodeLabel = new Label();
            ZipcodeTextBox = new TextBox();
            NameTextBox = new TextBox();
            BeginOdometerTextBox = new TextBox();
            EndOdometerTextBox = new TextBox();
            AddressTextBox = new TextBox();
            CityTextBox = new TextBox();
            groupBox2 = new GroupBox();
            KmRadioButton = new RadioButton();
            MilesRadioButton = new RadioButton();
            groupBox3 = new GroupBox();
            SeniorDiscount = new CheckBox();
            AAADiscount = new CheckBox();
            groupBox4 = new GroupBox();
            YouOweLabel = new Label();
            MinusDiscountsLabel = new Label();
            DailyChargeLabel = new Label();
            MileageCostLabel = new Label();
            DistanceLabel = new Label();
            YouOweTextBox = new TextBox();
            MinusDiscountsTextBox = new TextBox();
            DailyChargeTextBox = new TextBox();
            MileageCostTextBox = new TextBox();
            TotalDistanceTextBox = new TextBox();
            groupBox5 = new GroupBox();
            ClearButton = new Button();
            SubmitButton = new Button();
            ExitButton = new Button();
            SummaryButton = new Button();
            CalculateButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(StateComboBox);
            groupBox1.Controls.Add(StateLabel);
            groupBox1.Controls.Add(DaysLabel);
            groupBox1.Controls.Add(DaysTextBox);
            groupBox1.Controls.Add(CityLabel);
            groupBox1.Controls.Add(EndOdometerLabel);
            groupBox1.Controls.Add(AddressLabel);
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Controls.Add(BeginOdometerLabel);
            groupBox1.Controls.Add(ZipcodeLabel);
            groupBox1.Controls.Add(ZipcodeTextBox);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Controls.Add(BeginOdometerTextBox);
            groupBox1.Controls.Add(EndOdometerTextBox);
            groupBox1.Controls.Add(AddressTextBox);
            groupBox1.Controls.Add(CityTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client Information";
            // 
            // StateComboBox
            // 
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Items.AddRange(new object[] { "", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" });
            StateComboBox.Location = new Point(294, 131);
            StateComboBox.Name = "StateComboBox";
            StateComboBox.Size = new Size(104, 28);
            StateComboBox.TabIndex = 5;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(37, 138);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(43, 20);
            StateLabel.TabIndex = 1;
            StateLabel.Text = "State";
            // 
            // DaysLabel
            // 
            DaysLabel.AutoSize = true;
            DaysLabel.Location = new Point(35, 266);
            DaysLabel.Name = "DaysLabel";
            DaysLabel.Size = new Size(117, 20);
            DaysLabel.TabIndex = 1;
            DaysLabel.Text = "Number of Days";
            // 
            // DaysTextBox
            // 
            DaysTextBox.Location = new Point(306, 263);
            DaysTextBox.Name = "DaysTextBox";
            DaysTextBox.Size = new Size(92, 27);
            DaysTextBox.TabIndex = 7;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(37, 105);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 1;
            CityLabel.Text = "City";
            // 
            // EndOdometerLabel
            // 
            EndOdometerLabel.AutoSize = true;
            EndOdometerLabel.Location = new Point(35, 237);
            EndOdometerLabel.Name = "EndOdometerLabel";
            EndOdometerLabel.Size = new Size(186, 20);
            EndOdometerLabel.TabIndex = 1;
            EndOdometerLabel.Text = "Ending Odometer Reading";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(35, 72);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(62, 20);
            AddressLabel.TabIndex = 1;
            AddressLabel.Text = "Address";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(35, 37);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(116, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Customer Name";
            // 
            // BeginOdometerLabel
            // 
            BeginOdometerLabel.AutoSize = true;
            BeginOdometerLabel.Location = new Point(35, 204);
            BeginOdometerLabel.Name = "BeginOdometerLabel";
            BeginOdometerLabel.Size = new Size(207, 20);
            BeginOdometerLabel.TabIndex = 1;
            BeginOdometerLabel.Text = "Beginning Odometer Reading";
            // 
            // ZipcodeLabel
            // 
            ZipcodeLabel.AutoSize = true;
            ZipcodeLabel.Location = new Point(37, 171);
            ZipcodeLabel.Name = "ZipcodeLabel";
            ZipcodeLabel.Size = new Size(70, 20);
            ZipcodeLabel.TabIndex = 1;
            ZipcodeLabel.Text = "Zip Code";
            // 
            // ZipcodeTextBox
            // 
            ZipcodeTextBox.Location = new Point(306, 164);
            ZipcodeTextBox.Name = "ZipcodeTextBox";
            ZipcodeTextBox.Size = new Size(92, 27);
            ZipcodeTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(196, 30);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(202, 27);
            NameTextBox.TabIndex = 0;
            // 
            // BeginOdometerTextBox
            // 
            BeginOdometerTextBox.Location = new Point(262, 197);
            BeginOdometerTextBox.Name = "BeginOdometerTextBox";
            BeginOdometerTextBox.Size = new Size(136, 27);
            BeginOdometerTextBox.TabIndex = 5;
            // 
            // EndOdometerTextBox
            // 
            EndOdometerTextBox.Location = new Point(262, 230);
            EndOdometerTextBox.Name = "EndOdometerTextBox";
            EndOdometerTextBox.Size = new Size(136, 27);
            EndOdometerTextBox.TabIndex = 6;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(196, 65);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(202, 27);
            AddressTextBox.TabIndex = 1;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(196, 98);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(202, 27);
            CityTextBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(KmRadioButton);
            groupBox2.Controls.Add(MilesRadioButton);
            groupBox2.Location = new Point(12, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(404, 104);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Is Odometer in Km or Mi?";
            // 
            // KmRadioButton
            // 
            KmRadioButton.AutoSize = true;
            KmRadioButton.Location = new Point(6, 67);
            KmRadioButton.Name = "KmRadioButton";
            KmRadioButton.Size = new Size(101, 24);
            KmRadioButton.TabIndex = 1;
            KmRadioButton.TabStop = true;
            KmRadioButton.Text = "Kilometers";
            KmRadioButton.UseVisualStyleBackColor = true;
            // 
            // MilesRadioButton
            // 
            MilesRadioButton.AutoSize = true;
            MilesRadioButton.Location = new Point(6, 37);
            MilesRadioButton.Name = "MilesRadioButton";
            MilesRadioButton.Size = new Size(65, 24);
            MilesRadioButton.TabIndex = 0;
            MilesRadioButton.TabStop = true;
            MilesRadioButton.Text = "Miles";
            MilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SeniorDiscount);
            groupBox3.Controls.Add(AAADiscount);
            groupBox3.Location = new Point(422, 299);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(408, 105);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Discounts";
            // 
            // SeniorDiscount
            // 
            SeniorDiscount.AutoSize = true;
            SeniorDiscount.Location = new Point(20, 73);
            SeniorDiscount.Name = "SeniorDiscount";
            SeniorDiscount.Size = new Size(184, 24);
            SeniorDiscount.TabIndex = 1;
            SeniorDiscount.Text = "Senior Citizen Discount";
            SeniorDiscount.UseVisualStyleBackColor = true;
            // 
            // AAADiscount
            // 
            AAADiscount.AutoSize = true;
            AAADiscount.Location = new Point(20, 43);
            AAADiscount.Name = "AAADiscount";
            AAADiscount.Size = new Size(183, 24);
            AAADiscount.TabIndex = 0;
            AAADiscount.Text = "AAA Member Discount";
            AAADiscount.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(YouOweLabel);
            groupBox4.Controls.Add(MinusDiscountsLabel);
            groupBox4.Controls.Add(DailyChargeLabel);
            groupBox4.Controls.Add(MileageCostLabel);
            groupBox4.Controls.Add(DistanceLabel);
            groupBox4.Controls.Add(YouOweTextBox);
            groupBox4.Controls.Add(MinusDiscountsTextBox);
            groupBox4.Controls.Add(DailyChargeTextBox);
            groupBox4.Controls.Add(MileageCostTextBox);
            groupBox4.Controls.Add(TotalDistanceTextBox);
            groupBox4.Location = new Point(422, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(426, 262);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Cost Summary";
            // 
            // YouOweLabel
            // 
            YouOweLabel.AutoSize = true;
            YouOweLabel.Location = new Point(26, 213);
            YouOweLabel.Name = "YouOweLabel";
            YouOweLabel.Size = new Size(67, 20);
            YouOweLabel.TabIndex = 1;
            YouOweLabel.Text = "You Owe";
            // 
            // MinusDiscountsLabel
            // 
            MinusDiscountsLabel.AutoSize = true;
            MinusDiscountsLabel.Location = new Point(26, 167);
            MinusDiscountsLabel.Name = "MinusDiscountsLabel";
            MinusDiscountsLabel.Size = new Size(116, 20);
            MinusDiscountsLabel.TabIndex = 1;
            MinusDiscountsLabel.Text = "Minus Discounts";
            // 
            // DailyChargeLabel
            // 
            DailyChargeLabel.AutoSize = true;
            DailyChargeLabel.Location = new Point(26, 123);
            DailyChargeLabel.Name = "DailyChargeLabel";
            DailyChargeLabel.Size = new Size(94, 20);
            DailyChargeLabel.TabIndex = 1;
            DailyChargeLabel.Text = "Daily Charge";
            // 
            // MileageCostLabel
            // 
            MileageCostLabel.AutoSize = true;
            MileageCostLabel.Location = new Point(26, 84);
            MileageCostLabel.Name = "MileageCostLabel";
            MileageCostLabel.Size = new Size(114, 20);
            MileageCostLabel.TabIndex = 1;
            MileageCostLabel.Text = "Mileage Charge";
            // 
            // DistanceLabel
            // 
            DistanceLabel.AutoSize = true;
            DistanceLabel.Location = new Point(26, 51);
            DistanceLabel.Name = "DistanceLabel";
            DistanceLabel.Size = new Size(167, 20);
            DistanceLabel.TabIndex = 1;
            DistanceLabel.Text = "Total Distance Travelled";
            // 
            // YouOweTextBox
            // 
            YouOweTextBox.Location = new Point(213, 206);
            YouOweTextBox.Name = "YouOweTextBox";
            YouOweTextBox.ReadOnly = true;
            YouOweTextBox.Size = new Size(180, 27);
            YouOweTextBox.TabIndex = 0;
            // 
            // MinusDiscountsTextBox
            // 
            MinusDiscountsTextBox.Location = new Point(213, 160);
            MinusDiscountsTextBox.Name = "MinusDiscountsTextBox";
            MinusDiscountsTextBox.ReadOnly = true;
            MinusDiscountsTextBox.Size = new Size(180, 27);
            MinusDiscountsTextBox.TabIndex = 0;
            // 
            // DailyChargeTextBox
            // 
            DailyChargeTextBox.Location = new Point(213, 116);
            DailyChargeTextBox.Name = "DailyChargeTextBox";
            DailyChargeTextBox.ReadOnly = true;
            DailyChargeTextBox.Size = new Size(180, 27);
            DailyChargeTextBox.TabIndex = 0;
            // 
            // MileageCostTextBox
            // 
            MileageCostTextBox.Location = new Point(213, 77);
            MileageCostTextBox.Name = "MileageCostTextBox";
            MileageCostTextBox.ReadOnly = true;
            MileageCostTextBox.Size = new Size(180, 27);
            MileageCostTextBox.TabIndex = 0;
            // 
            // TotalDistanceTextBox
            // 
            TotalDistanceTextBox.Location = new Point(213, 43);
            TotalDistanceTextBox.Name = "TotalDistanceTextBox";
            TotalDistanceTextBox.ReadOnly = true;
            TotalDistanceTextBox.Size = new Size(180, 27);
            TotalDistanceTextBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ClearButton);
            groupBox5.Controls.Add(SubmitButton);
            groupBox5.Controls.Add(ExitButton);
            groupBox5.Controls.Add(SummaryButton);
            groupBox5.Controls.Add(CalculateButton);
            groupBox5.Location = new Point(24, 452);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(802, 76);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(263, 26);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(116, 35);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(507, 26);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(116, 35);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(385, 26);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(116, 35);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(629, 26);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(116, 35);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "&Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(141, 26);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(116, 35);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Ca&lculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // CarRental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 540);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CarRental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rental Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private RadioButton MilesRadioButton;
        private Button ClearButton;
        private Button ExitButton;
        private Button SummaryButton;
        private Button CalculateButton;
        private TextBox DaysTextBox;
        private TextBox ZipcodeTextBox;
        private TextBox NameTextBox;
        private TextBox BeginOdometerTextBox;
        private TextBox EndOdometerTextBox;
        private TextBox AddressTextBox;
        private TextBox CityTextBox;
        private RadioButton KmRadioButton;
        private CheckBox SeniorDiscount;
        private CheckBox AAADiscount;
        private TextBox MinusDiscountsTextBox;
        private TextBox DailyChargeTextBox;
        private TextBox MileageCostTextBox;
        private TextBox TotalDistanceTextBox;
        private TextBox YouOweTextBox;
        private Label StateLabel;
        private Label DaysLabel;
        private Label CityLabel;
        private Label EndOdometerLabel;
        private Label AddressLabel;
        private Label NameLabel;
        private Label BeginOdometerLabel;
        private Label ZipcodeLabel;
        private Label YouOweLabel;
        private Label MinusDiscountsLabel;
        private Label DailyChargeLabel;
        private Label MileageCostLabel;
        private Label DistanceLabel;
        private ComboBox StateComboBox;
        private Button SubmitButton;
    }
}
