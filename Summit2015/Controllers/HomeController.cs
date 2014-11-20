using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper;
using Glass.Mapper.Sc;
using Summit2015.Models;
using TweetSharp;

namespace Summit2015.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISitecoreContext _context;
        private readonly ITwitterService _twitterService;

        private IGlassHtml _glassHtml;

        public HomeController() : this(new SitecoreContext(), new TwitterService())
        {
            
        }
        public HomeController(ISitecoreContext context, ITwitterService twitterService)
        {
            _context = context;
            _twitterService = twitterService;

            _glassHtml = new GlassHtml(context);
        }


        [HttpGet]
        public ActionResult Index()
        {

            var model = new Form();

            model.Page = _context.GetCurrentItem<Home>();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Form model)
        {
            model.Page = _context.GetCurrentItem<Home>();

            if (ModelState.IsValid && model.Page.Settings != null)
            {

                _twitterService.AuthenticateWith(
                    model.Page.Settings.ConsumerKey,
                    model.Page.Settings.ConsumerSecret,
                    model.Page.Settings.ApiKey,
                    model.Page.Settings.ApiSecret
                    );

                SendTweetOptions sendTweet = model.Page.Tweet;

                sendTweet.Status = sendTweet.Status.Formatted(model.Name);

                _twitterService.SendTweet(sendTweet);

                model.Completed = true;
            }


            return View(model);
        }
        
        
    }
}