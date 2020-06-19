using System;
using System.Collections.Generic;
using Twilio.Jwt.AccessToken;

namespace TwilioVideoServerApp.Abstractions
{
    public interface IVideoService
    {
        string GetTwilioJwt(string identity,HashSet<IGrant> grants);
    }
}
