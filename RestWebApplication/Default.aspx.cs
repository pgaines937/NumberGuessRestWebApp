using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Net.Http;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Runtime.Serialization;

namespace RestWebApplication
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSecretNumber_Click(object sender, EventArgs e)
        {
            Uri baseUri = new Uri("http://localhost:60001/Service.svc/");
            UriTemplate secretNumberTemplate = new UriTemplate("SecretNumber?lower={lower}&upper={upper}");
            NameValueCollection parameters = new NameValueCollection();
            parameters.Add("lower", TextBoxLower.Text);
            parameters.Add("upper", TextBoxUpper.Text);

            Uri completeSecretUri = secretNumberTemplate.BindByName(baseUri, parameters);
            WebClient proxy = new WebClient(); // create proxy
            LabelSecret.Text = proxy.DownloadString(completeSecretUri);
        }

        protected void ButtonPlay_Click(object sender, EventArgs e)
        {
            Uri baseUri = new Uri("http://localhost:60001/Service.svc");
            UriTemplate checkNumberTemplate = new UriTemplate("CheckNumber?userNum={userNum}&secretNum={secretNum}");
            int attempts = Convert.ToInt32(LabelAttemptsCount.Text);
            attempts += 1;
            LabelAttemptsCount.Text = Convert.ToString(attempts);

            NameValueCollection parameters = new NameValueCollection();
            parameters.Add("userNum", TextBoxMakeGuess.Text);
            parameters.Add("secretNum", LabelSecret.Text);

            Uri completeCheckUri = checkNumberTemplate.BindByName(baseUri, parameters);
            WebClient proxy = new WebClient(); // create proxy
            LabelNum.Text = proxy.DownloadString(completeCheckUri);
        }
    }
}