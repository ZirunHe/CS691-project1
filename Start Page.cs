using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gettry_Engagement_Letter
{
    public partial class Start_Page : Form
    {
        public Start_Page()
        {
            InitializeComponent();
        }



        private void New_Home_Page_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }




        private void TileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Business_Tax_Return_Without_Indivdiual_Tax_Return business_Tax_Return_Without_Indivdiual_Tax_Return = new Business_Tax_Return_Without_Indivdiual_Tax_Return();
            business_Tax_Return_Without_Indivdiual_Tax_Return.Show();
        }




        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Audit_Income_Tax audit_Income_Tax = new Audit_Income_Tax();
            audit_Income_Tax.Show();
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Complication_Income_Tax_Basis complication_Income_Tax_Basis = new Complication_Income_Tax_Basis();
            complication_Income_Tax_Basis.Show();
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {


            //Consulting consulting = new Consulting();
            //consulting.Show();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Fiduciary fiduciary = new Fiduciary();
            fiduciary.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Individual_Tax_Return individual_Tax_Return = new Individual_Tax_Return();
            individual_Tax_Return.Show();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Visible = false;
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Business_Tax_Return_Without_Indivdiual_Tax_Return business_Tax_Return_Without_Indivdiual_Tax_Return = new Business_Tax_Return_Without_Indivdiual_Tax_Return();
            business_Tax_Return_Without_Indivdiual_Tax_Return.Show();
        }

        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tileItem27_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Review_Income_Tax_Basis review_Income_Tax_Basis = new Review_Income_Tax_Basis();
            review_Income_Tax_Basis.Show();
        }

        private void tileItem11_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Business_Tax_Return__With_Individual_ business_Tax_Return__With_Individual_ = new Business_Tax_Return__With_Individual_();
            business_Tax_Return__With_Individual_.Show();
        }

        private void tileItem14_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Audit_CO_OP_GAAP_Basis audit_Of_Co_Op_GAAP_Basis = new Audit_CO_OP_GAAP_Basis();
            audit_Of_Co_Op_GAAP_Basis.Show();
        }

        private void tileItem15_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Audit_Of_Co_Op_Income_Tax_Basis audit_Of_Co_Op_Income_Tax_Basis = new Audit_Of_Co_Op_Income_Tax_Basis();
            audit_Of_Co_Op_Income_Tax_Basis.Show();
        }

        private void tileItem16_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Audit_Certiorari audit_Certiorari = new Audit_Certiorari();
            audit_Certiorari.Show();
        }

        private void tileItem17_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
         
               
        }

        private void tileControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void tileItem29_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Audit_GAAP_Basis audit_GAAP_Basis = new Audit_GAAP_Basis();
            audit_GAAP_Basis.Show();
        }

        private void tileItem28_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Review_GAAP_Bsis review_GAAP_Bsis = new Review_GAAP_Bsis();
            review_GAAP_Bsis.Show();
        }
    }
}
