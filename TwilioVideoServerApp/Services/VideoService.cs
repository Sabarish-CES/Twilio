using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Twilio;
using Twilio.Base;
using Twilio.Jwt.AccessToken;
using Twilio.Rest.Api.V2010.Account.Conference;
using Twilio.Rest.Video.V1;
using TwilioVideoServerApp.Abstractions;
using TwilioVideoServerApp.Options;

namespace TwilioVideoServerApp.Services
{
    public class VideoService : IVideoService
    {
        readonly TwilioSettings _twilioSettings;

        public VideoService(TwilioSettings twilioOptions)
        {
            _twilioSettings =
                twilioOptions
             ?? throw new ArgumentNullException(nameof(twilioOptions));

            TwilioClient.Init(_twilioSettings.AccountSid, _twilioSettings.AuthToken);
        }

        public string GetTwilioJwt(string identity, HashSet<IGrant> videoGrants)
        {

            return new Token(_twilioSettings.AccountSid,
                          _twilioSettings.ApiSID,
                          _twilioSettings.ApiKey, identity: identity, grants: videoGrants).ToJwt();
        }


    }
}
