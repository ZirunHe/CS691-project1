﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;

namespace Gettry_Engagement_Letter
{
    public partial class Business_Tax_Return__With_Individual_ : Form
    {
        public Business_Tax_Return__With_Individual_()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection("Data Source = GETT17E-SQL03\\CCHAXCESS; Initial Catalog = CCH_ENT;User ID=cch_user;Password=cch_user");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CLIENTPARTNERSHIP.NameLine1,ClientType,ClientStatus,AddressLine1,AddressLine2,CityName,PostalCode,StateProvinceCode,BillManagerName,StaffFirstName AS PartnerFirstName,StaffLastName AS PartnerLastName FROM CLIENTPARTNERSHIP JOIN CLIENT ON CLIENTPARTNERSHIP.ClientIdent = CLIENT.ClientIdent JOIN CLIENTADDRESS ON CLIENTPARTNERSHIP.ClientIdent = CLIENTADDRESS.ReferenceIdent JOIN CLIENTPRACTICE ON CLIENTPARTNERSHIP.ClientIdent = CLIENTPRACTICE.ClientIdent JOIN CLIENTCRS ON CLIENTPARTNERSHIP.ClientIdent = CLIENTCRS.ClientIdent JOIN STAFF ON STAFF.StaffIdent = CLIENTCRS.StaffIdent WHERE FirmClientStaffAssignmentName = 'Responsible Person' AND ClientSubId = '" + SearchBox.Text + "'", con);

                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                CompanyName.Text = dt.Rows[0][0].ToString();
                ClientGroup.Text = dt.Rows[0][1].ToString();
                ClientStatus.Text = dt.Rows[0][2].ToString();
                CompanyAddress.Text = dt.Rows[0][3].ToString();
                ClientAddress_Second.Text = dt.Rows[0][4].ToString();
                City.Text = dt.Rows[0][5].ToString();
                Zip.Text = dt.Rows[0][6].ToString();
                State.Text = dt.Rows[0][7].ToString();
                BillingManager.Text = dt.Rows[0][8].ToString();
                Responsible_FirstName.Text = dt.Rows[0][9].ToString();
                Responsible_LastName.Text = dt.Rows[0][10].ToString();
            }
            catch (Exception ex) when (ex is System.Data.SqlClient.SqlException || ex is System.IndexOutOfRangeException)
            {

            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source = GETT17E-SQL03\\CCHAXCESS; Initial Catalog = CCH_ENT;User ID=cch_user;Password=cch_user");
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT CLIENTCORP.NameLine1,ClientType,ClientStatus,AddressLine1,AddressLine2,CityName,PostalCode,StateProvinceCode,BillManagerName,StaffFirstName AS PartnerFirstName,StaffLastName AS PartnerLastName FROM CLIENTCORP JOIN CLIENT ON CLIENTCORP.ClientIdent = CLIENT.ClientIdent JOIN CLIENTADDRESS ON CLIENTCORP.ClientIdent = CLIENTADDRESS.ReferenceIdent JOIN CLIENTPRACTICE ON CLIENTCORP.ClientIdent = CLIENTPRACTICE.ClientIdent JOIN CLIENTCRS ON CLIENTCORP.ClientIdent = CLIENTCRS.ClientIdent JOIN STAFF ON STAFF.StaffIdent = CLIENTCRS.StaffIdent WHERE FirmClientStaffAssignmentName = 'Responsible Person' AND ClientSubId = '" + SearchBox.Text + "'", con);

                System.Data.DataTable dt = new System.Data.DataTable();
                sda1.Fill(dt);
                CompanyName.Text = dt.Rows[0][0].ToString();
                ClientGroup.Text = dt.Rows[0][1].ToString();
                ClientStatus.Text = dt.Rows[0][2].ToString();
                CompanyAddress.Text = dt.Rows[0][3].ToString();
                ClientAddress_Second.Text = dt.Rows[0][4].ToString();
                City.Text = dt.Rows[0][5].ToString();
                Zip.Text = dt.Rows[0][6].ToString();
                State.Text = dt.Rows[0][7].ToString();
                BillingManager.Text = dt.Rows[0][8].ToString();
                Responsible_FirstName.Text = dt.Rows[0][9].ToString();
                Responsible_LastName.Text = dt.Rows[0][10].ToString();
            }

            catch (Exception ex) when (ex is System.Data.SqlClient.SqlException || ex is System.IndexOutOfRangeException)
            {
                if (ex is System.Data.SqlClient.SqlException)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source = NY-L-WNORALES\\SQLEXPRESS; Initial Catalog = CCH_ENT; Integrated Security = True");
                        SqlDataAdapter sda1 = new SqlDataAdapter("SELECT CLIENTCORP.NameLine1,ClientType,ClientStatus,AddressLine1,AddressLine2,CityName,PostalCode,StateProvinceCode,BillManagerName,StaffFirstName AS PartnerFirstName,StaffLastName AS PartnerLastName FROM CLIENTCORP JOIN CLIENT ON CLIENTCORP.ClientIdent = CLIENT.ClientIdent JOIN CLIENTADDRESS ON CLIENTCORP.ClientIdent = CLIENTADDRESS.ReferenceIdent JOIN CLIENTPRACTICE ON CLIENTCORP.ClientIdent = CLIENTPRACTICE.ClientIdent JOIN CLIENTCRS ON CLIENTCORP.ClientIdent = CLIENTCRS.ClientIdent JOIN STAFF ON STAFF.StaffIdent = CLIENTCRS.StaffIdent WHERE FirmClientStaffAssignmentName = 'Responsible Person' AND ClientSubId = '" + SearchBox.Text + "'", con);

                        System.Data.DataTable dt = new System.Data.DataTable();
                        sda1.Fill(dt);
                        CompanyName.Text = dt.Rows[0][0].ToString();
                        ClientGroup.Text = dt.Rows[0][1].ToString();
                        ClientStatus.Text = dt.Rows[0][2].ToString();
                        CompanyAddress.Text = dt.Rows[0][3].ToString();
                        ClientAddress_Second.Text = dt.Rows[0][4].ToString();
                        City.Text = dt.Rows[0][5].ToString();
                        Zip.Text = dt.Rows[0][6].ToString();
                        State.Text = dt.Rows[0][7].ToString();
                        BillingManager.Text = dt.Rows[0][8].ToString();
                        Responsible_FirstName.Text = dt.Rows[0][9].ToString();
                        Responsible_LastName.Text = dt.Rows[0][10].ToString();
                    }
                    catch (Exception ext) when (ext is System.Data.SqlClient.SqlException || ext is System.IndexOutOfRangeException)
                    {
                        // MessageBox.Show("The Client Could not be found, it is either not a client or you are using the Wrong Engagement Number. Please check Axcess ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source = NY-L-WNORALES\\SQLEXPRESS; Initial Catalog = CCH_ENT; Integrated Security = True");
                        SqlDataAdapter sda1 = new SqlDataAdapter("SELECT CLIENTPARTNERSHIP.NameLine1,ClientType,ClientStatus,AddressLine1,AddressLine2,CityName,PostalCode,StateProvinceCode,BillManagerName,StaffFirstName AS PartnerFirstName,StaffLastName AS PartnerLastName FROM CLIENTPARTNERSHIP JOIN CLIENT ON CLIENTPARTNERSHIP.ClientIdent = CLIENT.ClientIdent JOIN CLIENTADDRESS ON CLIENTPARTNERSHIP.ClientIdent = CLIENTADDRESS.ReferenceIdent JOIN CLIENTPRACTICE ON CLIENTPARTNERSHIP.ClientIdent = CLIENTPRACTICE.ClientIdent JOIN CLIENTCRS ON CLIENTPARTNERSHIP.ClientIdent = CLIENTCRS.ClientIdent JOIN STAFF ON STAFF.StaffIdent = CLIENTCRS.StaffIdent WHERE FirmClientStaffAssignmentName = 'Responsible Person' AND ClientSubId = '" + SearchBox.Text + "'", con);

                        System.Data.DataTable dt = new System.Data.DataTable();
                        sda1.Fill(dt);
                        CompanyName.Text = dt.Rows[0][0].ToString();
                        ClientGroup.Text = dt.Rows[0][1].ToString();
                        ClientStatus.Text = dt.Rows[0][2].ToString();
                        CompanyAddress.Text = dt.Rows[0][3].ToString();
                        ClientAddress_Second.Text = dt.Rows[0][4].ToString();
                        City.Text = dt.Rows[0][5].ToString();
                        Zip.Text = dt.Rows[0][6].ToString();
                        State.Text = dt.Rows[0][7].ToString();
                        BillingManager.Text = dt.Rows[0][8].ToString();
                        Responsible_FirstName.Text = dt.Rows[0][9].ToString();
                        Responsible_LastName.Text = dt.Rows[0][10].ToString();
                    }
                    catch (Exception ext) when (ext is System.Data.SqlClient.SqlException || ext is System.IndexOutOfRangeException)
                    {

                    }
                }

                //  MessageBox.Show("The Client Could not be found, it is either not a client or you are using the Wrong Engagement Number. Please check Axcess, if the issue continues please contact your IT department. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }




        string myvalue;
        private void Generate_Letter_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("The Letter will be dated todays date " + (DateTime.Now.ToString("MMMM d, yyyy.")) + " Would you like to keep the current date", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialogResult == DialogResult.No)
            {

                myvalue = Interaction.InputBox("", "Date Change", (DateTime.Now.ToString("MMMM d, yyyy")));

            }

            else if (dialogResult == DialogResult.Yes)
            {

            }




            if (MessageBox.Show("Please Confirm the following information is correct ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    var application = new Microsoft.Office.Interop.Word.Application();
                    var document = new Microsoft.Office.Interop.Word.Document();



                    string imagePathAndy = @"C:\Users\Andrew J. Rubin Signature.tiff";
                    string imagePathAndrew = @"C:\Users\Andrew Ross Signature.tiff";
                    string imagePathBob = @"C:\Users\Bob Bjelke Signature.tiff";
                    string imagePathGabe = @"C:\Users\Gabe Shurek Signature.tif";
                    string imagePathBruce = @"C:\Users\Signature - Bruce.tiff";
                    string imagePathMarcus = @"C:\Users\Steven Marcus Signature.tif";
                    string imagePathHoward = @"C:\Users\Howard Fine Signature.tiff";
                    string imagePathRobin = @"C:\Users\Robin Rokuson Signature.tiff";
                    string imagePathMikeBloom = @"C:\Users\Michael.tiff";
                    string imagePathPeterMarx = @"C:\Users\Signature - Peter.tiff";
                    string imagePathJed = @"C:\Users\Jed Dallek Signature.tiff";
                    string imageHappen = @"C:\Users\Marc Heppen Signature.tiff";
                    string imageDolinger = @"C:\Users\Mark Dolinger Signature.tiff";
                    string imageWarshavsky = @"C:\Users\Mark Warshavsky Signature.tif";
                    string imageSaners = @"C:\Users\Scott Sanders Signature.tiff";
                    string imagePeter = @"C:\Users\Signature - Peter.tiff";
                    string imageOppenheim = @"C:\Users\Steven Oppenheim Signature.tiff";
                    string imagePaulBella = @"C:\Users\Paul Bella.tiff";
                    string imageLeeFerber = @"C:\Users\Lee.tiff";
                    string imageJoelDressner = @"C:\Users\Joel.tiff";
                    string imageGlazer = @"C:\Users\Russ Glazer Signature.tiff";






                    // New Path
                    string imagePathAndys = @"S:\Shared\Engagement Letters\Signatures\Andrew J. Rubin Signature.tiff";
                    string imagePathAndrews = @"S:\Shared\Engagement Letters\Signatures\Andrew Ross Signature.tiff";
                    string imagePathBobs = @"S:\Shared\Engagement Letters\Signatures\Bob Bjelke Signature.tiff";
                    string imagePathGabes = @"S:\Shared\Engagement Letters\Signatures\Gabe Shurek Signature.tif";
                    string imagePathBruces = @"S:\Shared\Engagement Letters\Signatures\Signature - Bruce.tiff";
                    string imagePathMarcuss = @"S:\Shared\Engagement Letters\Signatures\Steven Marcus Signature.tif";
                    string imagePathHowards = @"S:\Shared\Engagement Letters\Signatures\Howard Fine Signature.tiff";
                    string imagePathRobins = @"S:\Shared\Engagement Letters\Signatures\Robin Rokuson Signature.tiff";
                    string imagePathMikeBlooms = @"S:\Shared\Engagement Letters\Signatures\Michael.tiff";
                    string imagePathPeterMarxs = @"S:\Shared\Engagement Letters\Signatures\Signature - Peter.tiff";
                    string imagePathJeds = @"S:\Shared\Engagement Letters\Signatures\Jed Dallek Signature.tiff";
                    string imageHappens = @"S:\Shared\Engagement Letters\Signatures\Marc Heppen Signature.tiff";
                    string imageDolingers = @"S:\Shared\Engagement Letters\Signatures\Mark Dolinger Signature.tiff";
                    string imageWarshavskys = @"S:\Shared\Engagement Letters\Signatures\Mark Warshavsky Signature.tif";
                    string imageSanerss = @"S:\Shared\Engagement Letters\Signatures\Scott Sanders Signature.tiff";
                    string imagePeters = @"S:\Shared\Engagement Letters\Signatures\Signature - Peter.tiff";
                    string imageOppenheims = @"S:\Shared\Engagement Letters\Signatures\Steven Oppenheim Signature.tiff";
                    string imagePaulBellas = @"S:\Shared\Engagement Letters\Signatures\Paul Bella.tiff";
                    string imageLeeFerbers = @"S:\Shared\Engagement Letters\Signatures\Lee.tiff";
                    string imageJoelDressners = @"S:\Shared\Engagement Letters\Signatures\Joel.tiff";
                    string imageRussGlazer = @"S:\Shared\Engagement Letters\Signatures\Russ Glazer Signature.tiff";


                    string DesignationRoss = "CPA, CFE, CVA, PFS";
                    string DesignationRubin = "CPA";
                    string DesignationShurek = "CPA, CFE, CVA";
                    string DesignationFine = "CPA/ABV/CFF, CVA";
                    string DesignationDallek = "CPA, MST";
                    string DesignationDressner = "CPA";
                    string DesignationFerber = "CPA";
                    string DesignationDolinger = "CPA";
                    string DesginationHeppen = "CPA";
                    string DesignationWarshavsky = "CPA/ABV/CFF, CVA, CFE";
                    string DesignationBella = "CPA, CVA";
                    string DesginationBjelke = "CPA";
                    string DesginationRokuson = "CPA";
                    string DesignationGlazer = "MCBA, ASA, CPA/ABV, CVA, ABAR";
                    string DesignationSanders = "CPA, PFS, CGMA, CFP©, CFS";
                    string DesignationOppenheim = "CPA, TEP";
                    string DesingationMarcus = "CPA";
                    string DesignationKertzner = "CPA/ABV, CVA";     // There is no signature 11/14/2018
                    string DesignationWillinger = "CPA, JD"; // There is no signature 11/14/2018
                    string DesignationEller = "CPA, JD";    // There is no signature 11/14/2018
                    string DesignationBibas = "CPA";        // There is no signature 11/14/2018
                    string DesignationMarx = "CPA";
                    string DesignationLange = "CPA";
                    string DesignationWeingarten = "CPA";        // There is no signature 11/14/2018
                    string DesignationBloom = "CPA";
                    string DesignationGreenbaum = "CPA, CFP, PFS";  // There is no signature 11/14/2018









                    if (RatesYes.Checked)
                    {
                        try
                        {
                            document = application.Documents.Add(Template: @"C:\Users\Will Norales\Downloads\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return_450.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\Engagement Letters\Templates\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return_450.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }


                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\wnorales\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return_450.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                    }


                    else if (RatesNo.Checked)
                    {
                        try
                        {
                            document = application.Documents.Add(Template: @"C:\Users\Will Norales\Downloads\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return_495.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }
                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\Engagement Letters\Templates\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return_495.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\wnorales\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return_495.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                    }


                    else if (RatesOther.Checked)
                    {
                        try
                        {
                            document = application.Documents.Add(Template: @"C:\Users\Will Norales\Downloads\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }
                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\Engagement Letters\Templates\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }
                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\wnorales\Business Tax Return Indivdiual\Business Tax Return-With Indivdiual Tax Return.docx");
                            document.GrammarChecked = true;
                            document.SpellingChecked = true;
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                    }


                    if (dialogResult == DialogResult.No)
                        try
                        {

                            if (Mr_Button.Checked)
                            {


                                foreach (Section section in document.Sections)
                                {
                                    //Get the header range and add the header details.
                                    var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);

                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                                    headerRange.Font.Size = 11;
                                    headerRange.Font.Name = "Arial";
                                    headerRange.Font.Bold = 0;
                                    headerRange.Text = "Mr." + ClientName.Text + ' ' + ClientLastName.Text;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd1 = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd1);
                                    headerRange.Text = CompanyName.Text;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd);
                                    headerRange.Text = myvalue;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();
                                }
                            }

                            else if (Ms_Button.Checked)
                            {
                                foreach (Section section in document.Sections)
                                {
                                    //Get the header range and add the header details.
                                    var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);

                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                                    headerRange.Font.Size = 11;
                                    headerRange.Font.Name = "Arial";
                                    headerRange.Font.Bold = 0;
                                    headerRange.Text = "Mrs. " + ClientName.Text + ' ' + ClientLastName.Text;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd1 = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd1);
                                    headerRange.Text = CompanyName.Text;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd);
                                    headerRange.Text = myvalue;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();
                                }
                            }

                            else if (Mrs_Button.Checked)
                            {
                                foreach (Section section in document.Sections)
                                {
                                    //Get the header range and add the header details.
                                    var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);

                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                                    headerRange.Font.Size = 11;
                                    headerRange.Font.Name = "Arial";
                                    headerRange.Font.Bold = 0;
                                    headerRange.Text = "Mrs. " + ClientName.Text + ' ' + ClientLastName.Text;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd1 = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd1);
                                    headerRange.Text = CompanyName.Text;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd);
                                    headerRange.Text = myvalue;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();
                                }
                            }



                            else if (RemoveButton.Checked)
                            {
                                foreach (Section section in document.Sections)
                                {
                                    //Get the header range and add the header details.
                                    var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);

                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                                    headerRange.Font.Size = 11;
                                    headerRange.Font.Name = "Arial";
                                    headerRange.Font.Bold = 0;
                                    headerRange.Text = ClientName.Text + ' ' + ClientLastName.Text;
                                    headerRange.InsertParagraphAfter();



                                    object oCollapseEnd1 = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd1);
                                    headerRange.Text = CompanyName.Text;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd);
                                    headerRange.Text = myvalue;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();


                                }
                            }

                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }









                    else if (dialogResult == DialogResult.Yes)
                        try
                        {
                            if (Mr_Button.Checked)
                            {
                                foreach (Section section in document.Sections)
                                {
                                    //Get the header range and add the header details.
                                    var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);

                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                                    headerRange.Font.Size = 11;
                                    headerRange.Font.Name = "Arial";
                                    headerRange.Font.Bold = 0;
                                    headerRange.Text = "Mr. " + ClientName.Text + ' ' + ClientLastName.Text;
                                    headerRange.InsertParagraphAfter();



                                    object oCollapseEnd1 = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd1);
                                    headerRange.Text = CompanyName.Text;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();

                                    object oCollapseEnd = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd);
                                    headerRange.Text = (DateTime.Now.ToString("MMMM d, yyyy"));
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();
                                }

                            }

                            else if (Ms_Button.Checked)
                            {

                                foreach (Section section in document.Sections)
                                {
                                    //Get the header range and add the header details.
                                    var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);

                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                                    headerRange.Font.Size = 11;
                                    headerRange.Font.Name = "Arial";
                                    headerRange.Font.Bold = 0;
                                    headerRange.Text = "Ms. " + ClientName.Text + ' ' + ClientLastName.Text;
                                    headerRange.InsertParagraphAfter();

                                    object oCollapseEnd1 = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd1);
                                    headerRange.Text = CompanyName.Text;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();

                                    object oCollapseEnd = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd);
                                    headerRange.Text = (DateTime.Now.ToString("MMMM d, yyyy"));
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();
                                }

                            }

                            else if (Mrs_Button.Checked)
                            {
                                foreach (Section section in document.Sections)
                                {
                                    //Get the header range and add the header details.
                                    var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);

                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                                    headerRange.Font.Size = 11;
                                    headerRange.Font.Name = "Arial";
                                    headerRange.Font.Bold = 0;
                                    headerRange.Text = "Mrs. " + ClientName.Text + ' ' + ClientLastName.Text;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd1 = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd1);
                                    headerRange.Text = CompanyName.Text;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd);
                                    headerRange.Text = (DateTime.Now.ToString("MMMM d, yyyy"));
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();
                                }
                            }



                            else if (RemoveButton.Checked)
                            {
                                foreach (Section section in document.Sections)
                                {
                                    //Get the header range and add the header details.
                                    var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);

                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.Font.ColorIndex = WdColorIndex.wdBlack;
                                    headerRange.Font.Size = 11;
                                    headerRange.Font.Name = "Arial";
                                    headerRange.Font.Bold = 0;
                                    headerRange.Text = ClientName.Text + ' ' + ClientLastName.Text;
                                    headerRange.InsertParagraphAfter();

                                    object oCollapseEnd1 = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd1);
                                    headerRange.Text = CompanyName.Text;
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();


                                    object oCollapseEnd = WdCollapseDirection.wdCollapseEnd;
                                    headerRange.Collapse(ref oCollapseEnd);
                                    headerRange.Text = (DateTime.Now.ToString("MMMM d, yyyy"));
                                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                    headerRange.InsertParagraphAfter();


                                }
                            }

                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                    try
                    {

                        foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                        {

                            Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                            footerRange.Collapse(Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseEnd);

                            Microsoft.Office.Interop.Word.Range headerRange = wordSection.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                            headerRange.Collapse(Microsoft.Office.Interop.Word.WdCollapseDirection.wdCollapseEnd);

                            headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldNumPages);
                            Microsoft.Office.Interop.Word.Paragraph p4 = headerRange.Paragraphs.Add();
                            p4.Range.Text = " of ";
                            headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                            headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                            Microsoft.Office.Interop.Word.Paragraph p1 = headerRange.Paragraphs.Add();
                            p1.Range.Text = "Page ";
                            headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;



                            headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;



                        }
                    }
                    catch (System.Runtime.InteropServices.COMException ex)
                    {

                    }


                    try
                    {

                        foreach (Section section in document.Sections)
                        {
                            var headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                            object CollapseEnd = WdCollapseDirection.wdCollapseEnd;
                            headerRange.Collapse(ref CollapseEnd);
                            headerRange.Text = ("");
                            headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                            headerRange.InsertParagraphAfter();

                        }
                    }
                    catch (System.Runtime.InteropServices.COMException ex)
                    {

                    }

                    try
                    {

                        foreach (Microsoft.Office.Interop.Word.Field field in document.Fields)
                        {
                            if (field.Code.Text.Contains("Company"))
                            {
                                field.Select();
                                string name = CompanyName.Text;
                                application.Selection.TypeText(name);
                            }




                            else if (field.Code.Text.Contains("ContactName"))
                            {
                                field.Select();
                                string ContactName1 = ClientName.Text + ' ' + ClientLastName.Text;
                                application.Selection.TypeText(ContactName1);
                            }




                            else if (field.Code.Text.Contains("FirstName"))
                            {
                                field.Select();
                                string ContactName = ClientName.Text;
                                application.Selection.TypeText(ContactName);
                            }





                            else if (field.Code.Text.Contains("ClientAddress"))
                            {
                                field.Select();
                                string Lname = CompanyAddress.Text;
                                application.Selection.TypeText(Lname);
                            }




                            else if (field.Code.Text.Contains("Addressed"))
                            {
                                field.Select();
                                string Addressed;
                                if (Mr_Button.Checked)
                                {
                                    Addressed = "Mr.";
                                    application.Selection.TypeText(Addressed + ' ' + ClientName.Text + ' ' + ClientLastName.Text);

                                }

                                else if (Ms_Button.Checked)
                                {
                                    Addressed = "Ms.";
                                    application.Selection.TypeText(Addressed + ' ' + ClientName.Text + ' ' + ClientLastName.Text);
                                }

                                else if (Mrs_Button.Checked)
                                {
                                    Addressed = "Mrs.";
                                    application.Selection.TypeText(Addressed + ' ' + ClientName.Text + ' ' + ClientLastName.Text);

                                }

                                else
                                {
                                    application.Selection.TypeText( ClientName.Text + ' ' + ClientLastName.Text);
                                }
                            }



                            else if (field.Code.Text.Contains("Designations"))
                            {
                                string Designations;
                                field.Select();

                                if (BillingManager.Text == "Fine, Howard" || BillingManager.Text == "Fine" || BillingManager.Text == "fine")

                                {
                                    Designations = DesignationFine;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Rokuson, Robin" || BillingManager.Text == "Rokuson" || BillingManager.Text == "rokuson")
                                {
                                    Designations = DesginationRokuson;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Bloom, Michael" || BillingManager.Text == "Bloom" || BillingManager.Text == "bloom")
                                {
                                    Designations = DesignationBloom;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Lange, Bruce T." || BillingManager.Text == "Lange" || BillingManager.Text == "lange")
                                {
                                    Designations = DesignationLange;
                                    application.Selection.TypeText(Designations);
                                }


                                else if (BillingManager.Text == "Marcus, Steven L." || BillingManager.Text == "Marcus" || BillingManager.Text == "marcus")
                                {
                                    Designations = DesingationMarcus;
                                    application.Selection.TypeText(Designations);

                                }

                                else if (BillingManager.Text == "Marx, Peter S." || BillingManager.Text == "Marx" || BillingManager.Text == "marx")
                                {
                                    Designations = DesignationMarx;
                                    application.Selection.TypeText(Designations);

                                }


                                else if (BillingManager.Text == "Rubin, Andrew J." || BillingManager.Text == "Rubin" || BillingManager.Text == "rubin")
                                {

                                    Designations = DesignationRubin;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Oppenheim, Steven" || BillingManager.Text == "Oppenheim" || BillingManager.Text == "oppenheim")
                                {

                                    Designations = DesignationOppenheim;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Dolinger, Mark" || BillingManager.Text == "Dolinger" || BillingManager.Text == "dolinger")

                                {

                                    Designations = DesignationDolinger;
                                    application.Selection.TypeText(Designations);
                                }


                                else if (BillingManager.Text == "Sanders, Scott" || BillingManager.Text == "Sanders" || BillingManager.Text == "sanders")

                                {
                                    Designations = DesignationSanders;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Warshavsky, Mark" || BillingManager.Text == "Warshavsky" || BillingManager.Text == "warshavsky")

                                {
                                    Designations = DesignationWarshavsky;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Bjelke, Robert" || BillingManager.Text == "Bjelke" || BillingManager.Text == "bjelke")

                                {
                                    Designations = DesginationBjelke;
                                    application.Selection.TypeText(Designations);
                                }


                                else if (BillingManager.Text == "Ross, Andrew" || BillingManager.Text == "Ross" || BillingManager.Text == "ross")

                                {
                                    Designations = DesignationRoss;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Ferber, Lee" || BillingManager.Text == "Ferber" || BillingManager.Text == "ferber")

                                {
                                    Designations = DesignationFerber;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Dressner, Joel" || BillingManager.Text == "Dressner" || BillingManager.Text == "dressner")

                                {
                                    Designations = DesignationDressner;
                                    application.Selection.TypeText(Designations);
                                }


                                else if (BillingManager.Text == "Bella, Paul" || BillingManager.Text == "Bella" || BillingManager.Text == "bella")


                                {
                                    Designations = DesignationBella;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Dallek, Jed" || BillingManager.Text == "Dallek" || BillingManager.Text == "dallek")
                                {
                                    Designations = DesignationDallek;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Shurek, Gabe" || BillingManager.Text == "Shurek" || BillingManager.Text == "shurek")

                                {
                                    Designations = DesignationShurek;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Heppen, Marc" || BillingManager.Text == "Heppen" || BillingManager.Text == "heppen")

                                {
                                    Designations = DesginationHeppen;
                                    application.Selection.TypeText(Designations);
                                }



                                else if (BillingManager.Text == "Glazer, Russ" || BillingManager.Text == "Glazer" || BillingManager.Text == "glazer")

                                {
                                    Designations = DesignationGlazer;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Glazer, Russ" || BillingManager.Text == "Glazer" || BillingManager.Text == "glazer")

                                {
                                    Designations = DesignationGlazer;
                                    application.Selection.TypeText(Designations);
                                }


                                else if (BillingManager.Text == "Greenbaum, Benjamin" || BillingManager.Text == "Greenbaum" || BillingManager.Text == "greenbaum")

                                {
                                    Designations = DesignationGreenbaum;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Willinger, Alan" || BillingManager.Text == "Willinger" || BillingManager.Text == "willinger")

                                {
                                    Designations = DesignationWillinger;
                                    application.Selection.TypeText(Designations);
                                }



                                else if (BillingManager.Text == "Bibas, Steve" || BillingManager.Text == "Bibas" || BillingManager.Text == "bibas")

                                {
                                    Designations = DesignationBibas;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Weingarten, Lester" || BillingManager.Text == "Weingarten" || BillingManager.Text == "weingarten")

                                {
                                    Designations = DesignationWeingarten;
                                    application.Selection.TypeText(Designations);
                                }

                                else if (BillingManager.Text == "Eller, Steven" || BillingManager.Text == "Eller" || BillingManager.Text == "eller")

                                {
                                    Designations = DesignationEller;
                                    application.Selection.TypeText(Designations);
                                }


                            }



                            else if (field.Code.Text.Contains("City"))
                            {

                                field.Select();
                                string city = City.Text;
                                application.Selection.TypeText(city);
                            }
                            else if (field.Code.Text.Contains("State"))
                            {

                                field.Select();
                                string state = State.Text;
                                application.Selection.TypeText(state);
                            }

                            else if (field.Code.Text.Contains("YearEndDate"))
                            {

                                field.Select();

                                try
                                {
                                    string YearEndDate = YearEnd.Text;
                                    DateTime dt = Convert.ToDateTime(YearEndDate);
                                    string YearEndDate2 = dt.ToString("MMMM d, yyyy");
                                    application.Selection.TypeText(YearEndDate2);
                                }

                                catch (Exception ex) when (ex is System.FormatException)
                                {
                                    if (ex is System.FormatException)
                                    {
                                        string YearEndDate = YearEnd.Text;
                                        application.Selection.TypeText(YearEndDate);
                                    }
                                }
                            }


                            else if (field.Code.Text.Contains("Individual"))
                            {
                                String child;
                                field.Select();

                                if (FirstChild.Text != "Individual#1" && SecondChild.Text != "Individual#2" && ThridChild.Text != "Individual#3")
                                {
                                    //child = "We will also prepare the individual" + " " + (DateTime.Now.ToString("yyyy")  + " Federal and state income tax returns for " + FirstChild.Text + ", " + SecondChild.Text + " and " + ThridChild.Text + "." + " Should you be required to make quarterly estimated tax payments, we will calculate these payments for the subsequent tax year.");
                                    child = "We will also prepare the individual 2018 Federal and state income tax returns for " + FirstChild.Text + ", " + SecondChild.Text + " and " + ThridChild.Text + "." + " Should you be required to make quarterly estimated tax payments, we will calculate these payments for the subsequent tax year.";

                                    application.Selection.TypeText(child);
                                }



                                else if (FirstChild.Text != "Individual#1" && SecondChild.Text != "Individual#2")
                                {

                                    //child = "We will also prepare the individual" + " " +  (DateTime.Now.ToString("yyyy")  + " Federal and state income tax returns for " + FirstChild.Text  + " and "  + SecondChild.Text + "." + " Should you be required to make quarterly estimated tax payments, we will calculate these payments for the subsequent tax year.");
                                    child = "We will also prepare the individual 2018 Federal and state income tax returns for " + FirstChild.Text + " and " + SecondChild.Text + "." + " Should you be required to make quarterly estimated tax payments, we will calculate these payments for the subsequent tax year.";

                                    application.Selection.TypeText(child);

                                }


                                else if (FirstChild.Text != "Individual#1")
                                {
                                    //child = "We will also prepare the individual" + " " + (DateTime.Now.ToString("yyyy")  + " Federal and state income tax returns for " + FirstChild.Text + "." + " Should you be required to make quarterly estimated tax payments, we will calculate these payments for the subsequent tax year.");
                                    child = "We will also prepare the individual 2018 Federal and state income tax returns for " + FirstChild.Text + "." + " Should you be required to make quarterly estimated tax payments, we will calculate these payments for the subsequent tax year.";

                                    application.Selection.TypeText(child);

                                }
                            }



                            else if (field.Code.Text.Contains("Zip"))
                            {
                                field.Select();
                                string zip = Zip.Text;
                                application.Selection.TypeText(zip);
                            }



                            else if (field.Code.Text.Contains("SecondaryAddress"))
                            {
                                field.Select();
                                string SecondaryAddress = ClientAddress_Second.Text;

                                if (SecondaryAddress == "")
                                {
                                    field.Delete();

                                }
                                else
                                {

                                    application.Selection.TypeText("\n" + SecondaryAddress);
                                }

                            }





                            else if (field.Code.Text.Contains("Date"))
                            {
                                if (dialogResult == DialogResult.No)
                                {
                                    field.Select();
                                    application.Selection.TypeText(myvalue);

                                }

                                else
                                {
                                    field.Select();
                                    application.Selection.TypeText(DateTime.Now.ToString("MMMM d, yyyy"));
                                }
                            }

                            else if (field.Code.Text.Contains("year"))
                            {
                                field.Select();
                                application.Selection.TypeText("2018");
                                //application.Selection.TypeText(DateTime.Now.ToString("yyyy"));
                            }

                            else if (field.Code.Text.Contains("Rates"))
                            {
                                string Rates;

                                if (RatesOther.Checked)
                                {
                                    field.Select();
                                    Rates = "We estimate our fee for these services to be $" + AmountBox.Text + ". We will bill you $" + RetainerFeild.Text + " as a retainer, payable upon signing of this letter, which will be applied against the actual time incurred.  You will also be billed for out-of-pocket costs such as report production, work processing, postage, etc.";
                                    application.Selection.TypeText(Rates);
                                }
                            }

                            else if (field.Code.Text.Contains("PartnerName"))
                            {
                                field.Select();
                                string PartnerName = Responsible_FirstName.Text + ' ' + Responsible_LastName.Text;
                                application.Selection.TypeText(PartnerName);
                            }


                        }


                        if (BillingManager.Text == "Fine, Howard" || BillingManager.Text == "Fine" || BillingManager.Text == "fine")
                        {
                            try
                            {

                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathHoward);
                                shape1.Width = 150;
                                shape1.Height = 30;

                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathHowards);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }




                        else if (BillingManager.Text == "Rokuson, Robin" || BillingManager.Text == "Rokuson" || BillingManager.Text == "rokuson")
                        {

                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathRobin);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathRobins);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }





                        else if (BillingManager.Text == "Bloom, Michael" || BillingManager.Text == "Bloom" || BillingManager.Text == "bloom")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathMikeBloom);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }

                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                            try
                            {


                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathMikeBlooms);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }

                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }





                        else if (BillingManager.Text == "Lange, Bruce T." || BillingManager.Text == "Lange" || BillingManager.Text == "lange")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathBruce);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathBruces);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }


                        else if (BillingManager.Text == "Marcus, Steven L." || BillingManager.Text == "Marcus" || BillingManager.Text == "marcus")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathMarcus);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathMarcuss);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }







                        else if (BillingManager.Text == "Marx, Peter S." || BillingManager.Text == "Marx" || BillingManager.Text == "marx")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathPeterMarx);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathPeterMarxs);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }





                        else if (BillingManager.Text == "Rubin, Andrew J." || BillingManager.Text == "Rubin" || BillingManager.Text == "rubin")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathAndy);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathAndys);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }




                        else if (BillingManager.Text == "Oppenheim, Steven" || BillingManager.Text == "Oppenheim" || BillingManager.Text == "oppenheim")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageOppenheim);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageOppenheims);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }




                        else if (BillingManager.Text == "Marx, Peter S." || BillingManager.Text == "Marx" || BillingManager.Text == "marx")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePeter);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }

                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePeters);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }

                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }






                        else if (BillingManager.Text == "Dolinger, Mark" || BillingManager.Text == "Dolinger" || BillingManager.Text == "dolinger")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageDolinger);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }

                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageDolingers);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }

                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }




                        else if (BillingManager.Text == "Sanders, Scott" || BillingManager.Text == "Sanders" || BillingManager.Text == "sanders")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageSaners);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageSanerss);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }


                        else if (BillingManager.Text == "Warshavsky, Mark" || BillingManager.Text == "Warshavsky" || BillingManager.Text == "warshavsky")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageWarshavsky);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageWarshavskys);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }

                        else if (BillingManager.Text == "Bjelke, Robert" || BillingManager.Text == "Bjelke" || BillingManager.Text == "bjelke")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathBob);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathBobs);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                        }


                        else if (BillingManager.Text == "Ross, Andrew" || BillingManager.Text == "Ross" || BillingManager.Text == "ross")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathAndrew);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathAndrews);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }


                        else if (BillingManager.Text == "Ferber, Lee" || BillingManager.Text == "Ferber" || BillingManager.Text == "ferber")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageLeeFerber);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageLeeFerbers);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }


                        else if (BillingManager.Text == "Dressner, Joel" || BillingManager.Text == "Dressner" || BillingManager.Text == "dressner")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageJoelDressner);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageJoelDressners);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }


                        else if (BillingManager.Text == "Bella, Paul" || BillingManager.Text == "Bella" || BillingManager.Text == "bella")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePaulBella);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePaulBellas);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }

                        else if (BillingManager.Text == "Dallek, Jed" || BillingManager.Text == "Dallek" || BillingManager.Text == "dallek")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathJed);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathJeds);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }

                        else if (BillingManager.Text == "Shurek, Gabe" || BillingManager.Text == "Shurek" || BillingManager.Text == "shurek")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathGabe);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imagePathGabes);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }



                        else if (BillingManager.Text == "Heppen, Marc" || BillingManager.Text == "Heppen" || BillingManager.Text == "heppen")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageHappen);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageHappens);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }




                        else if (BillingManager.Text == "Glazer, Russ" || BillingManager.Text == "Glazer" || BillingManager.Text == "glazer")
                        {
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageGlazer);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }
                            try
                            {
                                var shape1 = document.Bookmarks["PicHere"].Range.InlineShapes.AddPicture(imageRussGlazer);
                                shape1.Width = 150;
                                shape1.Height = 30;
                            }
                            catch (System.Runtime.InteropServices.COMException ex)
                            {

                            }

                        }



                        try
                        {

                            foreach (Paragraph P in document.Paragraphs)
                            {
                                P.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
                            }

                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }
                    }

                    catch (Exception ex) when (ex is System.Runtime.InteropServices.COMException || ex is System.InvalidCastException)
                    {

                    }
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {

                }
            }
        }



        private void ChildYes_CheckedChanged(object sender, EventArgs e)
        {
            FirstChild.Visible = true;
            SecondChild.Visible = true;
            ThridChild.Visible = true;
        }

        private void ChildNo_CheckedChanged(object sender, EventArgs e)
        {
            FirstChild.Visible = false;
            SecondChild.Visible = false;
            ThridChild.Visible = false;
        }

        private void No_NewLine(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void Name_Enter(object sender, EventArgs e)
        {
            if (FirstChild.Text == "Individual#1")
            {
                FirstChild.Text = "";
                FirstChild.ForeColor = Color.Black;
            }
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (FirstChild.Text == "")
            {
                FirstChild.Text = "Individual#1";
                FirstChild.ForeColor = Color.Black;
            }

        }

        private void Name_Enter2(object sender, EventArgs e)
        {
            if (SecondChild.Text == "Individual#2")
            {
                SecondChild.Text = "";
                SecondChild.ForeColor = Color.Black;
            }
        }

        private void Name_Leave2(object sender, EventArgs e)
        {
            if (SecondChild.Text == "")
            {
                SecondChild.Text = "Individual#2";
                SecondChild.ForeColor = Color.Black;
            }

        }

        private void Name_Enter3(object sender, EventArgs e)
        {
            if (ThridChild.Text == "Individual#3")
            {
                ThridChild.Text = "";
                ThridChild.ForeColor = Color.Black;
            }

        }

        private void Name_Leave3(object sender, EventArgs e)
        {
            if (ThridChild.Text == "")
            {
                ThridChild.Text = "Individual#3";
                ThridChild.ForeColor = Color.Black;
            }
        }

        private void RatesOther_CheckedChanged(object sender, EventArgs e)
        {
            if (RatesOther.Checked)
            {
                AmountBox.Visible = true;
                RetainerYes.Checked = true;
                RetainerFeild.Visible = true;

            }
        }

        private void RatesYes_CheckedChanged(object sender, EventArgs e)
        {
            if (RatesYes.Checked)
            {
                AmountBox.Visible = false;
                RetainerNo.Checked = true;
                RetainerFeild.Visible = false;
            }
        }

        private void RatesNo_CheckedChanged(object sender, EventArgs e)
        {
            if (RatesNo.Checked)
            {
                AmountBox.Visible = false;
                RetainerNo.Checked = true;
                RetainerFeild.Visible = false;
            }
        }

        private void Enter4(object sender, EventArgs e)
        {
            if (AmountBox.Text == "Fee Amount")
            {
                AmountBox.Text = "";
                AmountBox.ForeColor = Color.Black;
            }
        }

        private void Leave4(object sender, EventArgs e)
        {
            if (AmountBox.Text == "")
            {
                AmountBox.Text = "Fee Amount";
                AmountBox.ForeColor = Color.Black;
            }

        }

        private void Enter5(object sender, EventArgs e)
        {
            if (RetainerFeild.Text == "Please Enter Amount")
            {
                RetainerFeild.Text = "";
                RetainerFeild.ForeColor = Color.Black;
            }
        }

        private void Leave5(object sender, EventArgs e)
        {
            if (RetainerFeild.Text == "")
            {
                RetainerFeild.Text = "Please Enter Amount";
                RetainerFeild.ForeColor = Color.Black;
            }

        }

        private void Business_Tax_Return__With_Individual(object sender, EventArgs e)
        {

        }
    }
}