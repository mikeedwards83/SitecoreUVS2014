using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using NSubstitute;
using NUnit.Framework;
using Summit2015.Controllers;
using Summit2015.Models;
using TweetSharp;

namespace Summit2015.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerFixture
    {
        [Test]
        public void Index_TwitterSettingsIsNull_DoNotSendTweet()
        {
            //Arrange

            var context = Substitute.For<ISitecoreContext>();
            var service = Substitute.For<ITwitterService>();

            var page = new Home();
            context.GetCurrentItem<Home>().Returns(page);

            var controller = new HomeController(context, service);
            var model = new Form();

            //Act
            var result = controller.Index(model) as ViewResult;

            //Assert
            Assert.IsNotNull(result.Model);

            var resultModel = result.Model as Form;

            Assert.IsFalse(resultModel.Completed);

        }

    }
}
