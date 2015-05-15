using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        DataClassesDataContext objcon = new DataClassesDataContext();
        Contact contact = new Contact();
        contact.name = txtName.Text;

        objcon.Contacts.InsertOnSubmit(contact);
        objcon.SubmitChanges();
    }
}