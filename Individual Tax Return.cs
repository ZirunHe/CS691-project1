using System;
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
    public partial class Individual_Tax_Return : Form
    {
        public Individual_Tax_Return()
        {
            InitializeComponent();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source = GETT17E-SQL03\\CCHAXCESS; Initial Catalog = CCH_ENT;User ID=cch_user;Password=cch_user");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CorrespondenceName,ClientFirstName,ClientLastName,AddressLine1,AddressLine2,CityName,StateProvinceCode,PostalCode,ClientType,ClientStatus,BillManagerName,StaffFirstName,StaffLastName FROM CLIENT JOIN CLIENTADDRESS ON CLIENT.ClientIdent = CLIENTADDRESS.ReferenceIdent JOIN CLIENTINDIVIDUAL ON CLIENT.ClientIdent = CLIENTINDIVIDUAL.ClientIdent JOIN CLIENTPRACTICE ON CLIENT.ClientIdent = CLIENTPRACTICE.ClientIdent JOIN CLIENTCRS ON CLIENT.ClientIdent = CLIENTCRS.ClientIdent JOIN STAFF ON STAFF.StaffIdent = CLIENTCRS.StaffIdent WHERE FirmClientStaffAssignmentName = 'Responsible Person' AND ClientSubId = '" + SearchBox.Text + "'", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                CorrespondenceName.Text = dt.Rows[0][0].ToString();
                ClientFirstName.Text = dt.Rows[0][1].ToString();
                ClientLastName.Text = dt.Rows[0][2].ToString();
                ClientsAddressBox.Text = dt.Rows[0][3].ToString();
                ClientAddress_Second.Text = dt.Rows[0][4].ToString();
                citybox.Text = dt.Rows[0][5].ToString();
                statebox.Text = dt.Rows[0][6].ToString();
                czipcodebox.Text = dt.Rows[0][7].ToString();
                ClientGroup.Text = dt.Rows[0][8].ToString();
                ClientStatus.Text = dt.Rows[0][9].ToString();
                BillingManager.Text = dt.Rows[0][10].ToString();
                Responsible_FirstName.Text = dt.Rows[0][11].ToString();
                Responsible_LastName.Text = dt.Rows[0][12].ToString();


            }
            catch (Exception ex) when (ex is System.Data.SqlClient.SqlException || ex is System.IndexOutOfRangeException)

            {
                MessageBox.Show("The client could not be found. It is either not an individual client or you are using the wrong engagement number. Please check Axcess. If the issue continues, please contact your IT Department ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                if (ex is System.Data.SqlClient.SqlException)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source = NY-L-WNORALES\\SQLEXPRESS; Initial Catalog = CCH_ENT; Integrated Security = True");
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT CorrespondenceName,ClientFirstName,ClientLastName,AddressLine1,AddressLine2,CityName,StateProvinceCode,PostalCode,ClientType,ClientStatus,BillManagerName,StaffFirstName,StaffLastName FROM CLIENT JOIN CLIENTADDRESS ON CLIENT.ClientIdent = CLIENTADDRESS.ReferenceIdent JOIN CLIENTINDIVIDUAL ON CLIENT.ClientIdent = CLIENTINDIVIDUAL.ClientIdent JOIN CLIENTPRACTICE ON CLIENT.ClientIdent = CLIENTPRACTICE.ClientIdent JOIN CLIENTCRS ON CLIENT.ClientIdent = CLIENTCRS.ClientIdent JOIN STAFF ON STAFF.StaffIdent = CLIENTCRS.StaffIdent WHERE FirmClientStaffAssignmentName = 'Responsible Person' AND ClientSubId = '" + SearchBox.Text + "'", con);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        sda.Fill(dt);

                        CorrespondenceName.Text = dt.Rows[0][0].ToString();
                        ClientFirstName.Text = dt.Rows[0][1].ToString();
                        ClientLastName.Text = dt.Rows[0][2].ToString();
                        ClientsAddressBox.Text = dt.Rows[0][3].ToString();
                        ClientAddress_Second.Text = dt.Rows[0][4].ToString();
                        citybox.Text = dt.Rows[0][5].ToString();
                        statebox.Text = dt.Rows[0][6].ToString();
                        czipcodebox.Text = dt.Rows[0][7].ToString();
                        ClientGroup.Text = dt.Rows[0][8].ToString();
                        ClientStatus.Text = dt.Rows[0][9].ToString();
                        BillingManager.Text = dt.Rows[0][10].ToString();
                        Responsible_FirstName.Text = dt.Rows[0][11].ToString();
                        Responsible_LastName.Text = dt.Rows[0][12].ToString(); ;
                    }

                    catch (Exception ext) when (ext is System.Data.SqlClient.SqlException || ext is System.IndexOutOfRangeException)
                    {
                        //  MessageBox.Show("The client could not be found. It is either not an individual client or you are using the wrong engagement number. Please check Axcess. If the issue continues, please contact your IT Department ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }

                }
            }
        }




        string myvalue;
        string valuebox;
        DialogResult dialogResult2;


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
                    string DesginationHeppen = "CPA";
                    string DesignationWarshavsky = "CPA/ABV/CFF, CVA, CFE";
                    string DesignationBella = "CPA, CVA";
                    string DesginationBjelke = "CPA";
                    string DesginationRokuson = "CPA";
                    string DesignationGlazer = "MCBA, ASA, CPA/ABV, CVA, ABAR";
                    string DesignationSanders = "CPA, PFS, CGMA, CFP©, CFS";
                    string DesignationOppenheim = "CPA, TEP";
                    string DesingationMarcus = "CPA";
                    string DesignationKertzner = "CPA/ABV, CVA";     // There is no signature 
                    string DesignationWillinger = "CPA, JD"; // There is no signature 
                    string DesignationEller = "CPA, JD";    // There is no signature 
                    string DesignationBibas = "CPA";        // There is no signature 
                    string DesignationMarx = "CPA";
                    string DesignationLange = "CPA";
                    string DesignationWeingarten = "CPA";        // There is no signature 
                    string DesignationBloom = "CPA";
                    string DesignationGreenbaum = "CPA, CFP, PFS";  // There is no signature








                    if (RatesYes.Checked)
                    {

                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\Engagement Letters\Templates\Individual_Tax_Return_450.docx");
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\wnorales\Individual\Individual_Tax_Return_450.docx");
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"C:\Users\Will Norales\Downloads\Individual\Individual_Tax_Return_450.docx");
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
                            document = application.Documents.Add(Template: @"S:\Shared\Engagement Letters\Templates\Individual_Tax_Return_495.docx");
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\wnorales\Individual\Individual_Tax_Return_495.docx");
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"C:\Users\Will Norales\Downloads\Individual\Individual_Tax_Return_495.docx");
                            application.Visible = true;

                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }
                    }





                    else if (RemoveRates.Checked)
                    {
                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\Engagement Letters\Templates\Individual_Tax_Return_NoRates.docx");
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\wnorales\Individual\Individual_Tax_Return_NoRates.docx");
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"C:\Users\Will Norales\Downloads\Individual\Individual_Tax_Return_NoRates.docx");
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
                            document = application.Documents.Add(Template: @"S:\Shared\Engagement Letters\Templates\Individual_Tax_Return.docx");
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"S:\Shared\wnorales\Individual\Individual_Tax_Return.docx");
                            application.Visible = true;
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {

                        }

                        try
                        {
                            document = application.Documents.Add(Template: @"C:\Users\Will Norales\Downloads\Individual\Individual_Tax_Return.docx");
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
                                    headerRange.Text = "Mr." + ClientFirstName.Text + ' ' + ClientLastName.Text;
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
                                    headerRange.Text = "Mrs. " + ClientFirstName.Text + ' ' + ClientLastName.Text;
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
                                    headerRange.Text = "Mrs. " + ClientFirstName.Text + ' ' + ClientLastName.Text;
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
                                    headerRange.Text = ClientFirstName.Text + ' ' + ClientLastName.Text;
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
                                    headerRange.Text = "Mr. " + ClientFirstName.Text + ' ' + ClientLastName.Text;
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
                                    headerRange.Text = "Ms. " + ClientFirstName.Text + ' ' + ClientLastName.Text;
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
                                    headerRange.Text = "Mrs. " + ClientFirstName.Text + ' ' + ClientLastName.Text;
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
                                    headerRange.Text = ClientFirstName.Text + ' ' + ClientLastName.Text;
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
                            if (field.Code.Text.Contains("ClientName"))
                            {
                                field.Select();
                                string name = ClientFirstName.Text;
                                application.Selection.TypeText(name);
                            }



                            else if (field.Code.Text.Contains("ClientLastName"))
                            {
                                field.Select();
                                string lname = ClientLastName.Text;
                                application.Selection.TypeText(lname);

                            }




                            else if (field.Code.Text.Contains("Addressed"))
                            {
                                field.Select();
                                string Addressed;
                                if (Mr_Button.Checked)
                                {
                                    Addressed = "Mr.";
                                    application.Selection.TypeText(Addressed + ClientFirstName.Text + " " + ClientLastName.Text);

                                }

                                else if (Ms_Button.Checked)
                                {
                                    Addressed = "Ms.";
                                    application.Selection.TypeText(Addressed + ClientFirstName.Text + " " + ClientLastName.Text);
                                }

                                else if (Mrs_Button.Checked)
                                {
                                    Addressed = "Mrs.";
                                    application.Selection.TypeText(Addressed + ClientFirstName.Text + " " + ClientLastName.Text);

                                }

                                else
                                {
                                    application.Selection.TypeText(ClientFirstName.Text + " " + ClientLastName.Text);

                                }
                            }




                            else if (field.Code.Text.Contains("ClientAddress"))
                            {
                                field.Select();
                                string Lname = ClientsAddressBox.Text;
                                application.Selection.TypeText(Lname);

                            }



                            else if (field.Code.Text.Contains("Secondary"))
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



                            else if (field.Code.Text.Contains("ServiceFee"))
                            {
                                field.Select();

                                if (dialogResult2 == DialogResult.Yes)
                                {

                                    string Service = "Our fee for these services will be $" + valuebox + "." + " You will also be billed for out-of-pocket costs such as report production, work processing, postage, etc.if applicable.";
                                    application.Selection.TypeText(Service);
                                }

                                else
                                {
                                    field.Delete();
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
                                string city = citybox.Text;
                                application.Selection.TypeText(city);
                            }
                            else if (field.Code.Text.Contains("State"))
                            {

                                field.Select();
                                string state = statebox.Text;
                                application.Selection.TypeText(state);
                            }


                            else if (field.Code.Text.Contains("PartnerName"))
                            {

                                field.Select();
                                string PartnerName = Responsible_FirstName.Text + ' ' + Responsible_LastName.Text;
                                application.Selection.TypeText(PartnerName);
                            }


                            else if (field.Code.Text.Contains("Zip"))
                            {

                                field.Select();
                                string zip = czipcodebox.Text;
                                application.Selection.TypeText(zip);

                            }
                            else if ((field.Code.Text.Contains("children")))
                            {
                                String child;
                                field.Select();

                                if (ChildYes.Checked && FirstChild.Text != "Individual#1" && SecondChild.Text != "Individual#2" && ThridChild.Text != "Individual#3")
                                {
                                    child = " From information you provide,we will also prepare the Federal and State income tax returns for " + FirstChild.Text + "," + SecondChild.Text + " and " + ThridChild.Text + " for the year ended 2018. ";
                                    //child = " From information you provide,we will also prepare the Federal and State income tax returns for " + FirstChild.Text + "," + SecondChild.Text + " and " + ThridChild.Text + " for the year ended " + (DateTime.Now.ToString("yyyy") + ".");
                                    application.Selection.TypeText(child);
                                }



                                else if (ChildYes.Checked && FirstChild.Text != "Individual#1" && SecondChild.Text != "Individual#2")
                                {
                                    child = " From information you provide,we will also prepare the Federal and State income tax returns for " + FirstChild.Text + " and " + SecondChild.Text + " for the year ended 2018. ";

                                    // child = " From information you provide,we will also prepare the Federal and State income tax returns for " + FirstChild.Text + " and " + SecondChild.Text + " for the year ended " + (DateTime.Now.ToString("yyyy") + ".");
                                    application.Selection.TypeText(child);

                                }


                                else if (ChildYes.Checked && FirstChild.Text != "Individual#1")
                                {
                                    child = " From information you provide,we will also prepare the Federal and State income tax returns for " + FirstChild.Text + "" + " for the year ended 2018.";

                                    //  child = " From information you provide,we will also prepare the Federal and State income tax returns for " + FirstChild.Text + "" + " for the year ended " + (DateTime.Now.ToString("yyyy") + ".");
                                    application.Selection.TypeText(child);

                                }


                                else if (ChildNo.Checked)
                                {
                                    field.Delete();
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
                            else if (field.Code.Text.Contains("Year"))
                            {
                                field.Select();
                                application.Selection.TypeText("2018");
                              // Replace the code above with this code if you want the current year. //application.Selection.TypeText(DateTime.Now.ToString("yyyy"));
                            }



                            else if (field.Code.Text.Contains("Rates"))
                            {
                                string Rates;

                                if (RatesOther.Checked)
                                {

                                    field.Select();
                                    try
                                    {


                                        string LetterDate = LetterDated.Text;
                                        DateTime dt4 = Convert.ToDateTime(LetterDate);
                                        string LetterDate2 = dt4.ToString("MMMM d, yyyy");

                                        Rates = "Our fee for the above services is included with our fee arrangements as outlined in the " + EngagementName.Text + " engagement letter dated " + LetterDate2 + ".";
                                        application.Selection.TypeText(Rates);

                                    }

                                    catch (Exception ex) when (ex is System.FormatException)
                                    {
                                        if (ex is System.FormatException)
                                        {
                                            Rates = "Our fee for the above services is included with our fee arrangements as outlined in the " + EngagementName.Text + " engagement letter dated " + LetterDated.Text + ".";
                                            application.Selection.TypeText(Rates);
                                        }


                                    }


                                }

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

        private void Name_Leave(object sender, EventArgs e)
        {
            if (FirstChild.Text == "")
            {
                FirstChild.Text = "Individual#1";
                FirstChild.ForeColor = Color.Black;
            }
        }

        private void Name_Enter(object sender, EventArgs e)
        {
            if (FirstChild.Text == "Individual#1")
            {
                FirstChild.Text = "";
                FirstChild.ForeColor = Color.Black;
            }
        }

        private void EnterName(object sender, EventArgs e)
        {
            if (SecondChild.Text == "Individual#2")
            {
                SecondChild.Text = "";
                SecondChild.ForeColor = Color.Black;
            }

        }
        private void LeaveName(object sender, EventArgs e)
        {
            if (SecondChild.Text == "")
            {
                SecondChild.Text = "Individual#2";
                SecondChild.ForeColor = Color.Black;
            }
        }
        private void Enter3Name(object sender, EventArgs e)
        {
            if (ThridChild.Text == "Individual#3")
            {
                ThridChild.Text = "";
                ThridChild.ForeColor = Color.Black;
            }
        }

        private void Enter3Leave(object sender, EventArgs e)
        {
            if (ThridChild.Text == "")
            {
                ThridChild.Text = "Individual#3";
                ThridChild.ForeColor = Color.Black;
            }
        }

        private void enter(object sender, EventArgs e)
        {

        }

        private void Individual_Tax_Return_Load(object sender, EventArgs e)
        {

        }

        private void FixedRateBox_Enter(object sender, EventArgs e)
        {
            if (EngagementName.Text == "Please Enter the Amount")
            {
                EngagementName.Text = "";
            }
        }

        private void FixedRateBox_Leave(object sender, EventArgs e)
        {
            if (EngagementName.Text == "")
            {
                EngagementName.Text = "Please Enter the Amount";
                EngagementName.ForeColor = Color.Black;
            }
        }
        private void Name_of_Engagement(object sender, EventArgs e)
        {
            if (EngagementName.Text == "Name of the Engagement Letter")
            {
                EngagementName.Text = "";
                EngagementName.ForeColor = Color.Black;
            }
        }


        private void Name_of_Engagement_leave(object sender, EventArgs e)
        {

            if (EngagementName.Text == "")
            {
                EngagementName.Text = "Name of the Engagement Letter";
                FirstChild.ForeColor = Color.Black;
            }

        }


        private void Letter_Enter(object sender, EventArgs e)
        {
            if (LetterDated.Text == "Letter Dated")
            {
                LetterDated.Text = "";
                LetterDated.ForeColor = Color.Black;

            }
        }


        private void Letter_Leave(object sender, EventArgs e)
        {

            if (LetterDated.Text == "")
            {
                LetterDated.Text = "Letter Dated";
                LetterDated.ForeColor = Color.Black;


            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ChildYes_CheckedChanged(object sender, EventArgs e)
        {
            FirstChild.Visible = true;
            SecondChild.Visible = true;
            ThridChild.Visible = true;
        }

        private void ChildNo_CheckedChanged_1(object sender, EventArgs e)
        {
            FirstChild.Visible = false;
            SecondChild.Visible = false;
            ThridChild.Visible = false;
        }

        private void RatesOther_CheckedChanged_1(object sender, EventArgs e)
        {
            EngagementName.Visible = true;
            LetterDated.Visible = true;
        }

        private void No_New_Line(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void Leaved(object sender, EventArgs e)
        {

        }

        private void BillingManager_TextChanged(object sender, EventArgs e)
        {

        }

        private void RatesYes_CheckedChanged(object sender, EventArgs e)
        {
            EngagementName.Visible = false;
            LetterDated.Visible = false;
        }

        private void RatesNo_CheckedChanged(object sender, EventArgs e)
        {
            EngagementName.Visible = false;
            LetterDated.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void RemoveRates_CheckedChanged(object sender, EventArgs e)
        {
            EngagementName.Visible = false;
            LetterDated.Visible = false;
        }
    }
}