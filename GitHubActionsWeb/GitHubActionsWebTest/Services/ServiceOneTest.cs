using System;
using GitHubActionsWeb.Services;
using Xunit;

namespace GitHubActionsWebTest
{
    public class ServiceOneTest
    {
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void MethodOne_ReturnsInput(bool input, bool output)
        {
            //Arrange
            var service = new ServiceOne();

            //Act
            var result = service.MethodOne(input);

            //Assert
            Assert.Equal(output, result);

        }
    }
}
