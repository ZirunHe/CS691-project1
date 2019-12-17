namespace Gettry_Engagement_Letter
{
    partial class Individual_Tax_Return
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Individual_Tax_Return));
            this.FirstChild = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EngagementName = new System.Windows.Forms.TextBox();
            this.RatesOther = new System.Windows.Forms.RadioButton();
            this.RatesNo = new System.Windows.Forms.RadioButton();
            this.RatesYes = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.SecondChild = new System.Windows.Forms.TextBox();
            this.ThridChild = new System.Windows.Forms.TextBox();
            this.LetterDated = new System.Windows.Forms.TextBox();
            this.ChildYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ChildNo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Responsible_FirstName = new System.Windows.Forms.TextBox();
            this.ClientLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillingManager = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientGroup = new System.Windows.Forms.TextBox();
            this.Cl = new System.Windows.Forms.Label();
            this.ClientStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statebox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.czipcodebox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.citybox = new System.Windows.Forms.TextBox();
            this.ClientsAddressBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ClientFirstName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Responsible_LastName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.RadioButton();
            this.Mrs_Button = new System.Windows.Forms.RadioButton();
            this.Mr_Button = new System.Windows.Forms.RadioButton();
            this.Ms_Button = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ClientAddress_Second = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CorrespondenceName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.RemoveRates = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstChild
            // 
            this.FirstChild.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstChild.ForeColor = System.Drawing.Color.Black;
            this.FirstChild.Location = new System.Drawing.Point(3, 77);
            this.FirstChild.Multiline = true;
            this.FirstChild.Name = "FirstChild";
            this.FirstChild.Size = new System.Drawing.Size(240, 27);
            this.FirstChild.TabIndex = 12;
            this.FirstChild.Text = "Individual#1";
            this.FirstChild.Visible = false;
            this.FirstChild.Enter += new System.EventHandler(this.Name_Enter);
            this.FirstChild.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(710, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 38);
            this.button1.TabIndex = 15;
            this.button1.TabStop = false;
            this.button1.Text = "Generate Letter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Generate_Letter_button_Click);
            // 
            // EngagementName
            // 
            this.EngagementName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngagementName.Location = new System.Drawing.Point(710, 437);
            this.EngagementName.Multiline = true;
            this.EngagementName.Name = "EngagementName";
            this.EngagementName.Size = new System.Drawing.Size(241, 49);
            this.EngagementName.TabIndex = 440;
            this.EngagementName.Text = "Name of the Engagement Letter";
            this.EngagementName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EngagementName.Visible = false;
            this.EngagementName.Enter += new System.EventHandler(this.Name_of_Engagement);
            this.EngagementName.Leave += new System.EventHandler(this.Name_of_Engagement_leave);
            // 
            // RatesOther
            // 
            this.RatesOther.AutoSize = true;
            this.RatesOther.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatesOther.Location = new System.Drawing.Point(925, 408);
            this.RatesOther.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RatesOther.Name = "RatesOther";
            this.RatesOther.Size = new System.Drawing.Size(332, 26);
            this.RatesOther.TabIndex = 438;
            this.RatesOther.Text = "Fee\'s Covered Under Bus. Eng. Ltr";
            this.RatesOther.UseVisualStyleBackColor = true;
            this.RatesOther.CheckedChanged += new System.EventHandler(this.RatesOther_CheckedChanged_1);
            this.RatesOther.Leave += new System.EventHandler(this.Leaved);
            // 
            // RatesNo
            // 
            this.RatesNo.AutoSize = true;
            this.RatesNo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatesNo.Location = new System.Drawing.Point(925, 380);
            this.RatesNo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RatesNo.Name = "RatesNo";
            this.RatesNo.Size = new System.Drawing.Size(225, 26);
            this.RatesNo.TabIndex = 437;
            this.RatesNo.Text = "Partner Rates at $495";
            this.RatesNo.UseVisualStyleBackColor = true;
            this.RatesNo.CheckedChanged += new System.EventHandler(this.RatesNo_CheckedChanged);
            // 
            // RatesYes
            // 
            this.RatesYes.AutoSize = true;
            this.RatesYes.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatesYes.Location = new System.Drawing.Point(713, 380);
            this.RatesYes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RatesYes.Name = "RatesYes";
            this.RatesYes.Size = new System.Drawing.Size(170, 26);
            this.RatesYes.TabIndex = 436;
            this.RatesYes.Text = "Standard Rates";
            this.RatesYes.UseVisualStyleBackColor = true;
            this.RatesYes.CheckedChanged += new System.EventHandler(this.RatesYes_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label19.Location = new System.Drawing.Point(709, 344);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(178, 22);
            this.label19.TabIndex = 435;
            this.label19.Text = "Fees && Billing Rates";
            // 
            // SecondChild
            // 
            this.SecondChild.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondChild.ForeColor = System.Drawing.Color.Black;
            this.SecondChild.Location = new System.Drawing.Point(3, 118);
            this.SecondChild.Multiline = true;
            this.SecondChild.Name = "SecondChild";
            this.SecondChild.Size = new System.Drawing.Size(240, 27);
            this.SecondChild.TabIndex = 13;
            this.SecondChild.Text = "Individual#2";
            this.SecondChild.Visible = false;
            this.SecondChild.Enter += new System.EventHandler(this.EnterName);
            this.SecondChild.Leave += new System.EventHandler(this.LeaveName);
            // 
            // ThridChild
            // 
            this.ThridChild.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThridChild.ForeColor = System.Drawing.Color.Black;
            this.ThridChild.Location = new System.Drawing.Point(3, 157);
            this.ThridChild.Multiline = true;
            this.ThridChild.Name = "ThridChild";
            this.ThridChild.Size = new System.Drawing.Size(240, 27);
            this.ThridChild.TabIndex = 14;
            this.ThridChild.Text = "Individual#3";
            this.ThridChild.Visible = false;
            this.ThridChild.Enter += new System.EventHandler(this.Enter3Name);
            this.ThridChild.Leave += new System.EventHandler(this.Enter3Leave);
            // 
            // LetterDated
            // 
            this.LetterDated.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetterDated.Location = new System.Drawing.Point(976, 437);
            this.LetterDated.Multiline = true;
            this.LetterDated.Name = "LetterDated";
            this.LetterDated.Size = new System.Drawing.Size(241, 49);
            this.LetterDated.TabIndex = 441;
            this.LetterDated.Text = "Letter Dated";
            this.LetterDated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LetterDated.Visible = false;
            this.LetterDated.WordWrap = false;
            this.LetterDated.Enter += new System.EventHandler(this.Letter_Enter);
            this.LetterDated.Leave += new System.EventHandler(this.Letter_Leave);
            // 
            // ChildYes
            // 
            this.ChildYes.AutoSize = true;
            this.ChildYes.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildYes.Location = new System.Drawing.Point(6, 32);
            this.ChildYes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ChildYes.Name = "ChildYes";
            this.ChildYes.Size = new System.Drawing.Size(58, 26);
            this.ChildYes.TabIndex = 433;
            this.ChildYes.Text = "Yes";
            this.ChildYes.UseVisualStyleBackColor = true;
            this.ChildYes.CheckedChanged += new System.EventHandler(this.ChildYes_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(2, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 22);
            this.label6.TabIndex = 432;
            this.label6.Text = "Other Engagements";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ChildNo
            // 
            this.ChildNo.AutoSize = true;
            this.ChildNo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildNo.Location = new System.Drawing.Point(137, 32);
            this.ChildNo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ChildNo.Name = "ChildNo";
            this.ChildNo.Size = new System.Drawing.Size(54, 26);
            this.ChildNo.TabIndex = 434;
            this.ChildNo.Text = "No";
            this.ChildNo.UseVisualStyleBackColor = true;
            this.ChildNo.CheckedChanged += new System.EventHandler(this.ChildNo_CheckedChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(5, 598);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 21);
            this.label5.TabIndex = 469;
            this.label5.Text = "Responsible Person First Name";
            // 
            // Responsible_FirstName
            // 
            this.Responsible_FirstName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsible_FirstName.Location = new System.Drawing.Point(9, 622);
            this.Responsible_FirstName.Multiline = true;
            this.Responsible_FirstName.Name = "Responsible_FirstName";
            this.Responsible_FirstName.Size = new System.Drawing.Size(256, 27);
            this.Responsible_FirstName.TabIndex = 12;
            // 
            // ClientLastName
            // 
            this.ClientLastName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLastName.Location = new System.Drawing.Point(309, 289);
            this.ClientLastName.Multiline = true;
            this.ClientLastName.Name = "ClientLastName";
            this.ClientLastName.Size = new System.Drawing.Size(247, 27);
            this.ClientLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(303, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 21);
            this.label3.TabIndex = 462;
            this.label3.Text = "Primary Client Last Name";
            // 
            // BillingManager
            // 
            this.BillingManager.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingManager.Location = new System.Drawing.Point(9, 447);
            this.BillingManager.Multiline = true;
            this.BillingManager.Name = "BillingManager";
            this.BillingManager.Size = new System.Drawing.Size(547, 27);
            this.BillingManager.TabIndex = 6;
            this.BillingManager.TextChanged += new System.EventHandler(this.BillingManager_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(5, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 460;
            this.label2.Text = "Billing Manager";
            // 
            // ClientGroup
            // 
            this.ClientGroup.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientGroup.Location = new System.Drawing.Point(9, 564);
            this.ClientGroup.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ClientGroup.Multiline = true;
            this.ClientGroup.Name = "ClientGroup";
            this.ClientGroup.Size = new System.Drawing.Size(256, 27);
            this.ClientGroup.TabIndex = 10;
            // 
            // Cl
            // 
            this.Cl.AutoSize = true;
            this.Cl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Cl.Location = new System.Drawing.Point(5, 543);
            this.Cl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cl.Name = "Cl";
            this.Cl.Size = new System.Drawing.Size(110, 21);
            this.Cl.TabIndex = 458;
            this.Cl.Text = "Client Group";
            // 
            // ClientStatus
            // 
            this.ClientStatus.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientStatus.Location = new System.Drawing.Point(312, 564);
            this.ClientStatus.Multiline = true;
            this.ClientStatus.Name = "ClientStatus";
            this.ClientStatus.Size = new System.Drawing.Size(243, 27);
            this.ClientStatus.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(309, 542);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 456;
            this.label9.Text = "Client Status";
            // 
            // statebox
            // 
            this.statebox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statebox.Location = new System.Drawing.Point(287, 509);
            this.statebox.Multiline = true;
            this.statebox.Name = "statebox";
            this.statebox.Size = new System.Drawing.Size(102, 27);
            this.statebox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(283, 487);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 21);
            this.label12.TabIndex = 454;
            this.label12.Text = "State";
            // 
            // czipcodebox
            // 
            this.czipcodebox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.czipcodebox.Location = new System.Drawing.Point(423, 509);
            this.czipcodebox.Multiline = true;
            this.czipcodebox.Name = "czipcodebox";
            this.czipcodebox.Size = new System.Drawing.Size(132, 27);
            this.czipcodebox.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(416, 485);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 21);
            this.label13.TabIndex = 452;
            this.label13.Text = " Zip Code";
            // 
            // citybox
            // 
            this.citybox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citybox.Location = new System.Drawing.Point(9, 509);
            this.citybox.Multiline = true;
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(256, 27);
            this.citybox.TabIndex = 7;
            // 
            // ClientsAddressBox
            // 
            this.ClientsAddressBox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsAddressBox.Location = new System.Drawing.Point(9, 341);
            this.ClientsAddressBox.Multiline = true;
            this.ClientsAddressBox.Name = "ClientsAddressBox";
            this.ClientsAddressBox.Size = new System.Drawing.Size(547, 27);
            this.ClientsAddressBox.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label21.Location = new System.Drawing.Point(5, 318);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 21);
            this.label21.TabIndex = 448;
            this.label21.Text = "Primary Address";
            // 
            // ClientFirstName
            // 
            this.ClientFirstName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientFirstName.Location = new System.Drawing.Point(9, 289);
            this.ClientFirstName.Multiline = true;
            this.ClientFirstName.Name = "ClientFirstName";
            this.ClientFirstName.Size = new System.Drawing.Size(234, 27);
            this.ClientFirstName.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label22.Location = new System.Drawing.Point(5, 268);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(201, 21);
            this.label22.TabIndex = 446;
            this.label22.Text = "Primary Client First Name";
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(2, 161);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(246, 38);
            this.SearchButton.TabIndex = 445;
            this.SearchButton.TabStop = false;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(4, 130);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(245, 27);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.No_New_Line);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1384, 71);
            this.panel3.TabIndex = 470;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(3, 108);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 21);
            this.label16.TabIndex = 471;
            this.label16.Text = "Client Engagement #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(1, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 30);
            this.label4.TabIndex = 473;
            this.label4.Text = "Individual Tax Return ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ChildNo);
            this.panel1.Controls.Add(this.ChildYes);
            this.panel1.Controls.Add(this.SecondChild);
            this.panel1.Controls.Add(this.ThridChild);
            this.panel1.Controls.Add(this.FirstChild);
            this.panel1.Location = new System.Drawing.Point(713, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 191);
            this.panel1.TabIndex = 474;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(310, 598);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 21);
            this.label1.TabIndex = 476;
            this.label1.Text = "Responsible Person Last Name";
            // 
            // Responsible_LastName
            // 
            this.Responsible_LastName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsible_LastName.Location = new System.Drawing.Point(312, 622);
            this.Responsible_LastName.Multiline = true;
            this.Responsible_LastName.Name = "Responsible_LastName";
            this.Responsible_LastName.Size = new System.Drawing.Size(243, 27);
            this.Responsible_LastName.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveButton);
            this.panel2.Controls.Add(this.Mrs_Button);
            this.panel2.Controls.Add(this.Mr_Button);
            this.panel2.Controls.Add(this.Ms_Button);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(713, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 63);
            this.panel2.TabIndex = 563;
            // 
            // RemoveButton
            // 
            this.RemoveButton.AutoSize = true;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(486, 29);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(166, 26);
            this.RemoveButton.TabIndex = 282;
            this.RemoveButton.TabStop = true;
            this.RemoveButton.Text = "Not Applicable";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // Mrs_Button
            // 
            this.Mrs_Button.AutoSize = true;
            this.Mrs_Button.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mrs_Button.Location = new System.Drawing.Point(352, 29);
            this.Mrs_Button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Mrs_Button.Name = "Mrs_Button";
            this.Mrs_Button.Size = new System.Drawing.Size(63, 26);
            this.Mrs_Button.TabIndex = 281;
            this.Mrs_Button.TabStop = true;
            this.Mrs_Button.Text = "Mrs.";
            this.Mrs_Button.UseVisualStyleBackColor = true;
            // 
            // Mr_Button
            // 
            this.Mr_Button.AutoSize = true;
            this.Mr_Button.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mr_Button.Location = new System.Drawing.Point(8, 32);
            this.Mr_Button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Mr_Button.Name = "Mr_Button";
            this.Mr_Button.Size = new System.Drawing.Size(56, 26);
            this.Mr_Button.TabIndex = 278;
            this.Mr_Button.TabStop = true;
            this.Mr_Button.Text = "Mr.";
            this.Mr_Button.UseVisualStyleBackColor = true;
            // 
            // Ms_Button
            // 
            this.Ms_Button.AutoSize = true;
            this.Ms_Button.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ms_Button.Location = new System.Drawing.Point(187, 29);
            this.Ms_Button.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Ms_Button.Name = "Ms_Button";
            this.Ms_Button.Size = new System.Drawing.Size(57, 26);
            this.Ms_Button.TabIndex = 279;
            this.Ms_Button.TabStop = true;
            this.Ms_Button.Text = "Ms.";
            this.Ms_Button.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(2, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 22);
            this.label7.TabIndex = 277;
            this.label7.Text = "Letter Addressed To";
            // 
            // ClientAddress_Second
            // 
            this.ClientAddress_Second.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientAddress_Second.Location = new System.Drawing.Point(9, 394);
            this.ClientAddress_Second.Multiline = true;
            this.ClientAddress_Second.Name = "ClientAddress_Second";
            this.ClientAddress_Second.Size = new System.Drawing.Size(547, 27);
            this.ClientAddress_Second.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(5, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 21);
            this.label11.TabIndex = 567;
            this.label11.Text = "Secondary Address";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // CorrespondenceName
            // 
            this.CorrespondenceName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrespondenceName.Location = new System.Drawing.Point(9, 238);
            this.CorrespondenceName.Multiline = true;
            this.CorrespondenceName.Name = "CorrespondenceName";
            this.CorrespondenceName.Size = new System.Drawing.Size(546, 27);
            this.CorrespondenceName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(5, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 569;
            this.label8.Text = "Client Name ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(5, 485);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 21);
            this.label14.TabIndex = 570;
            this.label14.Text = "City";
            // 
            // RemoveRates
            // 
            this.RemoveRates.AutoSize = true;
            this.RemoveRates.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveRates.Location = new System.Drawing.Point(713, 407);
            this.RemoveRates.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RemoveRates.Name = "RemoveRates";
            this.RemoveRates.Size = new System.Drawing.Size(162, 26);
            this.RemoveRates.TabIndex = 571;
            this.RemoveRates.Text = "Remove Rates";
            this.RemoveRates.UseVisualStyleBackColor = true;
            this.RemoveRates.CheckedChanged += new System.EventHandler(this.RemoveRates_CheckedChanged);
            // 
            // Individual_Tax_Return
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1365, 737);
            this.Controls.Add(this.Responsible_FirstName);
            this.Controls.Add(this.Responsible_LastName);
            this.Controls.Add(this.RemoveRates);
            this.Controls.Add(this.CorrespondenceName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClientAddress_Second);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LetterDated);
            this.Controls.Add(this.ClientLastName);
            this.Controls.Add(this.BillingManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientGroup);
            this.Controls.Add(this.Cl);
            this.Controls.Add(this.ClientStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statebox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.czipcodebox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.ClientsAddressBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.ClientFirstName);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EngagementName);
            this.Controls.Add(this.RatesOther);
            this.Controls.Add(this.RatesNo);
            this.Controls.Add(this.RatesYes);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Individual_Tax_Return";
            this.Text = "Individual Tax Return";
            this.Load += new System.EventHandler(this.Individual_Tax_Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FirstChild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EngagementName;
        private System.Windows.Forms.RadioButton RatesOther;
        private System.Windows.Forms.RadioButton RatesNo;
        private System.Windows.Forms.RadioButton RatesYes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox SecondChild;
        private System.Windows.Forms.TextBox ThridChild;
        private System.Windows.Forms.TextBox LetterDated;
        private System.Windows.Forms.RadioButton ChildYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton ChildNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Responsible_FirstName;
        private System.Windows.Forms.TextBox ClientLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BillingManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientGroup;
        private System.Windows.Forms.Label Cl;
        private System.Windows.Forms.TextBox ClientStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox statebox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox czipcodebox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.TextBox ClientsAddressBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox ClientFirstName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Responsible_LastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Mrs_Button;
        private System.Windows.Forms.RadioButton Mr_Button;
        private System.Windows.Forms.RadioButton Ms_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RemoveButton;
        private System.Windows.Forms.TextBox ClientAddress_Second;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CorrespondenceName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton RemoveRates;
    }
}