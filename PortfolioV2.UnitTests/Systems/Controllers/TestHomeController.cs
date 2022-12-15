using PortfolioV2.WebApp.Controllers;
namespace PortfolioV2.UnitTests.Systems.Controllers;

public class TestDashboardController
{
    [Fact]
    public void Get_OnSuccess_ReturnsStatusCode200(){
        // Arrange
        var controller = new DashboardController();

        // Act
        var result = controller.Index();

        // Assert
        result.StatusCode.Should().Be(200);
    }
}