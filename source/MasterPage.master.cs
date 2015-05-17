using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        DataClassesDataContext objcon = new DataClassesDataContext();
        Contact contact = new Contact();
        contact.name = txtName.Text;
        contact.email = txtEmail.Text;
        contact.phone = Convert.ToInt32(txtPhone.Text);
        contact.message = txtMessage.Text;
        objcon.Contacts.InsertOnSubmit(contact);
        objcon.SubmitChanges();
    }
}
