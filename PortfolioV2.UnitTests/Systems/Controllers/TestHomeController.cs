using PortfolioV2.WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using System.Threading.Tasks;
namespace PortfolioV2.UnitTests.Systems.Controllers;

public class TestDashboardController
{
    [Fact]
    public void Controller_Index_Returns_ViewResult(){
        // Arrange
        var controller = new DashboardController();

        // Act
        var result = controller.Index();

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        Assert.Null(viewResult.ViewName);
    }
}