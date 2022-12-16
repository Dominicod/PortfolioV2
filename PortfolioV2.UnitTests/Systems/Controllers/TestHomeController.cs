using PortfolioV2.WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using System.Threading.Tasks;
namespace PortfolioV2.UnitTests.Systems.Controllers;

public class TestDashboardController
{
    [Fact]
    public void Controller_Index_Returns_Vie(){
        var controller = new DashboardController();
        var result = controller.Index();
        var viewResult = Assert.IsType<ViewResult>(result);
        Assert.Equal("Index", viewResult?.ViewName);
    }
}