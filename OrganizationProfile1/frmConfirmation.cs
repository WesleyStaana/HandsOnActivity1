using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile1
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = OrganizationProfile1.frmRegistration.StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = OrganizationProfile1.frmRegistration.StudentInformationClass.SetFullName;
            lblProgram.Text = OrganizationProfile1.frmRegistration.StudentInformationClass.SetProgram;
            lblBirthday.Text = OrganizationProfile1.frmRegistration.StudentInformationClass.SetBirthday;
            lblGender.Text = OrganizationProfile1.frmRegistration.StudentInformationClass.SetGender;
            lblContactNo.Text = OrganizationProfile1.frmRegistration.StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = OrganizationProfile1.frmRegistration.StudentInformationClass.SetAge.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
