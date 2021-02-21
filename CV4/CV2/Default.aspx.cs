using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = ""; // path of text file

        StringBuilder build = new StringBuilder();

        StreamReader reader = null;
        try
        {

            reader = new StreamReader(path + @"\mails.txt");
            while (!reader.EndOfStream)
            {
                build.Append(reader.ReadLine());
            }

        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
            }
        }

        string[] mails = build.ToString().Split(',');

        Dictionary<string, string> list = new Dictionary<string, string>();
        foreach (string a in mails)
        {
            string f = a.ToLower();

            if (!list.ContainsKey(f))
            {
                list.Add(f, f);
            }
        }

        StreamWriter writer = null;

        try
        {
            writer = new StreamWriter(path + @"\fixed.txt");

            foreach (var b in list)
            {
                writer.Write(b.Key + ", ");
            }
        }
        finally
        {
            if (writer != null)
            {
                writer.Close();
            }
        }

        this.labelDone.Text = "Done!";
    }
}
