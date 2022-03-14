using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using PricingTool.API.Controllers;
using PricingTool.Models.DAO;
using PricingTool.Services.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricingTool.API.Test
{
    public class ProposalsControllerTest
    {
        ProposalsController _controller;
        Mock<IProposalService> _service;
        Mock<ILogger<ProposalsController>> _logger;

        [SetUp]
        public void Setup()
        {
            _service = new Mock<IProposalService>();
            _logger = new Mock<ILogger<ProposalsController>>();           

            var result = new List<Proposal>() { new Proposal { CustomerGrpName = "Group1", Date = System.DateTime.Now, Description = "Description1", ID=0, ProposalName ="Proposal1", Status = "Status1"  } };

            _service.Setup(c => c.GetProposals()).ReturnsAsync(result);
            _service.SetReturnsDefault(true);

            _controller = new ProposalsController(_service.Object, _logger.Object);
            _controller.ControllerContext = new ControllerContext();
            _controller.ControllerContext.HttpContext = new DefaultHttpContext();
        }

        [Test]
        public async Task Test1()
        {
            var result = await _controller.GetData();
            Assert.NotNull(result);
            Assert.AreEqual(0, result.First(r => r.ID == 0).ID);            
        }
    }
}