using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Twilio;
using Twilio.Jwt.AccessToken;
using Twilio.Rest.Api.V2010.Account;
using TwilioVideoServerApp.Abstractions;
using TwilioVideoServerApp.Options;
using TwilioVideoServerApp.Services;

namespace TwilioVideoServerApp.Controllers
{
    public class VideoController : ApiController
    {
        // GET api/<controller>
        private readonly IVideoService _videoService;

        public VideoController()
        {
            _videoService = new VideoService(new TwilioSettings());
        }

        public string GetToken(string identity)
        {
            var grant = new VideoGrant();
            grant.Room = "cool room";
            var grants = new HashSet<IGrant> { grant };

            return _videoService.GetTwilioJwt(identity, grants);
        }

    }
}