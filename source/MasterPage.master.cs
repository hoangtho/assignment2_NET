using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class MasterPage : System.Web.UI.MasterPage
{
    private DataClassesDataContext objcon = new DataClassesDataContext();


    protected void Page_Load(object sender, EventArgs e)
    {
        //Display information in the About section
        var path = from o in objcon.Abouts
                   where o.id == 1
                   select o;
        foreach (var detail in path)
        {
            Img1.ImageUrl = detail.img;
            NameT.InnerText = detail.name;
            ClassT.InnerText = detail.@class;
            InterestT.InnerText = detail.information;
        }

        var path1 = from o in objcon.Abouts
                    where o.id == 2
                    select o;
        foreach (var detail in path1)
        {
            Image2.ImageUrl = detail.img;
            NameD.InnerText = detail.name;
            ClassD.InnerText = detail.@class;
            InterestD.InnerText = detail.information;
        }

        //Display information at the Portfolio section (Portfolio Modal 6)
        var path2 = from o in objcon.Portfolios
                    where o.id == 3
                    select o;
        foreach (var detail in path2)
        {
            //Home Page
            ImagePr6.ImageUrl = detail.imageS;
            ProjectName6S.InnerText = detail.projectName;

            //Detail Page
            ImagePr6L.ImageUrl = detail.imageL;
            ProjectName6.InnerText = detail.projectName;
            BriefDescription6.InnerText = detail.briefDescription;
            Pr6Detail.InnerText = detail.detail;
        }

        //Display information at the Portfolio section (Portfolio Modal 5)
        var path3 = from o in objcon.Portfolios
                    where o.id == 2
                    select o;
        foreach (var detail in path3)
        {
            //Home Page
            ImagePr5.ImageUrl = detail.imageS;
            ProjectName5S.InnerText = detail.projectName;

            //Detail Page
            ImagePr5L.ImageUrl = detail.imageL;
            ProjectName5.InnerText = detail.projectName;
            BriefDescription5.InnerText = detail.briefDescription;
            Pr5Detail.InnerText = detail.detail;
        }

        //Display information at the Portfolio section (Portfolio Modal 4)
        var path4 = from o in objcon.Portfolios
                    where o.id == 1
                    select o;
        foreach (var detail in path4)
        {
            //Home Page
            ImagePr4.ImageUrl = detail.imageS;
            ProjectName4S.InnerText = detail.projectName;

            //Detail Page
            ImagePr4L.ImageUrl = detail.imageL;
            ProjectName4.InnerText = detail.projectName;
            BriefDescription4.InnerText = detail.briefDescription;
            Pr4Detail.InnerText = detail.detail;
        }
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        Contact contact = new Contact();
        contact.name = txtName.Text;
        contact.email = txtEmail.Text;
        contact.phone = Convert.ToInt32(txtPhone.Text);
        contact.message = txtMessage.Text;
        objcon.Contacts.InsertOnSubmit(contact);
        objcon.SubmitChanges();
    }
}
