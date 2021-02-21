using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

public partial class _Default : System.Web.UI.Page
{
    private List<string> list = new List<string>();
    private CVYaelDataContext dal = new CVYaelDataContext();


    /// <summary>
    /// Get a string representation of a webpage's source.
    /// </summary>
    /// <param name="URL">The URL to get the source from.</param>
    /// <returns></returns>
    public string getPageSource(string URL)
    {
        WebClient webClient = new WebClient();
        string strSource = webClient.DownloadString(URL);
        webClient.Dispose();
        return strSource;
    }

    protected void runJob_Click(object sender, EventArgs e)
    {

        LastID lastID = this.dal.LastIDs.SingleOrDefault(y => y.LastIDr == "1");
        if (lastID == null)
        {
            return;
        }

        StreamWriter writer = null;

        try
        {
            writer = new StreamWriter(@"C:\Works\CV\Or\works.txt", true);

            int count = 0;
            int totalCount = 0;

            if (this.Session["total"] != null)
            {
                totalCount = (int)this.Session["total"];
            }

            if (this.getAddress1.Text != "")
            {
                count += this.GetMails(this.getAddress1.Text, writer, lastID);
            }
            if (this.getAddress2.Text != "")
            {
                count += this.GetMails(this.getAddress2.Text, writer, lastID);
            }
            if (this.getAddress3.Text != "")
            {
                count += this.GetMails(this.getAddress3.Text, writer, lastID);
            }
            if (this.getAddress4.Text != "")
            {
                count += this.GetMails(this.getAddress4.Text, writer, lastID);
            }
            if (this.getAddress5.Text != "")
            {
                count += this.GetMails(this.getAddress5.Text, writer, lastID);
            }
            if (this.getAddress6.Text != "")
            {
                count += this.GetMails(this.getAddress6.Text, writer, lastID);
            }
            if (this.getAddress7.Text != "")
            {
                count += this.GetMails(this.getAddress7.Text, writer, lastID);
            }
            if (this.getAddress8.Text != "")
            {
                count += this.GetMails(this.getAddress8.Text, writer, lastID);
            }
            if (this.getAddress9.Text != "")
            {
                count += this.GetMails(this.getAddress9.Text, writer, lastID);
            }
            if (this.getAddress10.Text != "")
            {
                count += this.GetMails(this.getAddress10.Text, writer, lastID);
            }

            totalCount += count;
            this.Session["total"] = totalCount;

            this.doneLabel.Text = count.ToString();
            this.totalLabel.Text = totalCount.ToString();

            this.getAddress1.Text = "";
            this.getAddress2.Text = "";
            this.getAddress3.Text = "";
            this.getAddress4.Text = "";
            this.getAddress5.Text = "";
            this.getAddress6.Text = "";
            this.getAddress7.Text = "";
            this.getAddress8.Text = "";
            this.getAddress9.Text = "";
            this.getAddress10.Text = "";
        }
        catch (Exception) { }
        finally
        {
            if (writer != null)
            {
                writer.Close();
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            List<string> list = new List<string>();
            StreamReader r = new StreamReader(@"C:\Works\CV\Or\works.txt");

            StringBuilder build = new StringBuilder();

            while (!r.EndOfStream)
            {
                build.Append(r.ReadLine());
            }

            string[] stringer = build.ToString().Split(',');
            foreach (string m in stringer)
            {
                if (!list.Contains(m))
                {
                    this.list.Add(m);
                }
            }

            this.doneLabel.Text = "0";
            this.totalLabel.Text = stringer.Count().ToString();

            this.Session["total"] = stringer.Count();
            this.Session["list"] = list;

            r.Close();
        }
    }

    private int GetMails(string source, StreamWriter writer, LastID lastID)
    {
        if (this.Session["list"] != null)
        {
            this.list = (List<string>)this.Session["list"];
        }

        string g = this.getPageSource(source);

        long? result = 0;
        int count = 0;

        Regex t = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        foreach (Match m in t.Matches(g))
        {
            if (!list.Contains(m.Value))
            {
                Mail f = dal.Mails.SingleOrDefault(b => b.Mail1 == m.Value);
                if (f == null)
                {
                    try
                    {
                        result = lastID.LastIDID;

                        dal.Mails.InsertOnSubmit(new Mail
                        {
                            Mail1 = m.Value,
                            MailID = (result + 1).ToString(),
                        });

                        lastID.LastIDID++;

                        dal.SubmitChanges();

                        this.list.Add(m.Value);
                        writer.Write(m.Value + ", ");
                        count++;
                    }
                    catch (Exception) { }
                }
            }
        }

        this.Session["list"] = this.list;
        return count;
    }
}