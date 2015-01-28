using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedicalCommunityAutomation.BLL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation
{
    public partial class doctorEntry : System.Web.UI.Page
    {
        DoctorManager aDoctorManager = new DoctorManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Doctor aDoctor = new Doctor();
            aDoctor.Name = nameTextBox.Text;
            aDoctor.Degree = degreeTextBox.Text;
            aDoctor.Specialization = specializationTextBox.Text;
            //aDoctor.CenterId = (int)Session["Center_Id"];
            string msg=aDoctorManager.Save(aDoctor);
            msgLabel.Text = msg;
        }
    }
}