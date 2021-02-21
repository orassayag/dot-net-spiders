using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    private List<string> list = new List<string>();
    private CVBillyDataContext cvList = new CVBillyDataContext();


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
        if (this.Session["list"] != null)
        {
            this.list = (List<string>)this.Session["list"];
        }

        int count = 0;
        int totalCount = 0;

        if (this.Session["total"] != null)
        {
            totalCount = (int)this.Session["total"];
        }

        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(@"C:\Works\CV\spider.txt", true);

            //string g = this.getPageSource(this.getAddress.Text);

            for (int i = 1; i < 70; i++)
            {
                string g = this.getPageSource("http://www.shohamnet.co.il/BoardView.asp?page=" + i + "&numType=11");


            LastID lastID = this.cvList.LastIDs.SingleOrDefault(y => y.sdfsdgdf == "1");
            if (lastID == null)
            {
                return;
            }

            long result = 0;

            Regex t = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            foreach (Match m in t.Matches(g))
            {
                //if (!list.Contains(m.Value))
                //{
                    CVMail f = cvList.CVMails.SingleOrDefault(b => b.Mail == m.Value);
                    if (f == null)
                    {
                        try
                        {
                            result = lastID.LastID1;

                            cvList.CVMails.InsertOnSubmit(new CVMail
                            {
                                Mail = m.Value,
                                asdws = result
                            });

                            lastID.LastID1++;

                            cvList.SubmitChanges();

                            this.list.Add(m.Value);
                            writer.Write(m.Value + ", ");
                            count++;
                        }
                        catch (Exception) { }
                        //}
                        //}
                    }
                }
            }

            totalCount += count;
            this.Session["total"] = totalCount;

            this.doneLabel.Text = count.ToString();
            this.totalLabel.Text = totalCount.ToString();

            this.Session["list"] = this.list;
        }
        catch (Exception p)
        {
            string f = p.Message;
        }

        finally
        {
            if (writer != null)
            {
                writer.Close();
            }
        }

        this.getAddress.Text = "";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<string> list = new List<string>();
            StreamReader r = new StreamReader(@"C:\Works\CV\spider.txt");

            StringBuilder build = new StringBuilder();

            while (!r.EndOfStream)
            {
                build.Append(r.ReadLine());
            }

            string[] stringer = build.ToString().Split(',');
            foreach (string m in stringer)
            {
                if (m == "shik_c@walla.com" || m == "Lianab@walla.net.il" || m == "shimritush3@walla.com")
                {
                    continue;
                }

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
}
