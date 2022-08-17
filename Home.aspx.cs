using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Server
{

    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ManagementObjectSearcher searcher =
        new ManagementObjectSearcher("root\\CIMV2",
        "SELECT * FROM Win32_UserAccount WHERE LocalAccount=True");
            foreach (ManagementObject envVar in searcher.Get())
            {
                ListBox1.Items.Add(envVar["Name"].ToString());

            }
        }

        string str = "";

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (ListBox1.Items[i].Text.ToString() == TextBox1.Text.ToString())
                {
                    str = ListBox1.Items[i].Text.ToString();
                    break;
                }
            }

            if (str != "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert(\"пользователь '" + TextBox1.Text + "' найден!\")", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert(\"пользователь '" + TextBox1.Text + "' не найден!\")", true);
            }
        }
    }
}