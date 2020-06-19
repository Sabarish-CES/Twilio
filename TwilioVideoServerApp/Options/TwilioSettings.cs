using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TwilioVideoServerApp.Options
{
    public class TwilioSettings
    {
        public string AccountSid { get { return System.Configuration.ConfigurationManager.AppSettings["AccountSID"]; } }
        public string AuthToken { get { return System.Configuration.ConfigurationManager.AppSettings["AuthToken"]; } }
        public string ApiSID { get { return System.Configuration.ConfigurationManager.AppSettings["APISID"]; } }
        public string ApiKey { get { return System.Configuration.ConfigurationManager.AppSettings["APIKey"]; } }
    }
}