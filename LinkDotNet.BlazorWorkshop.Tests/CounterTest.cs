using Bunit;
using Bunit.Rendering;
using LinkDotNet.BlazorWorkshop.Client.Pages;
using LinkDotNet.BlazorWorkshop.Client.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkDotNet.BlazorWorkshop.Tests
{
    [TestClass]
    public class CounterTest : ComponentTestBase
    {
        [TestMethod]
        public void GivenCounter_WhenSettingState_ThenCounterShouldStartThere()
        {
            // Arrange
            var componentParameter = ComponentParameter.CreateParameter("CurrentCount", 100);
            var cut = RenderComponent<Counter>(componentParameter);
            cut.SaveSnapshot();

            // Act
            cut.Find("button").Click();

            // Assert
            var currentCount = cut.GetChangesSinceSnapshot().ShouldHaveSingleChange();
            currentCount.ShouldBeTextChange("Current count: 101");
        }

        [TestMethod]
        public void GivenCounter_WhenAddingNegativeValues_ThenSetBackToZero()
        {
            // Arrange
            var componentParameter = ComponentParameter.CreateParameter("CurrentCount", -100);
            var cut = RenderComponent<Counter>(componentParameter);
            cut.SaveSnapshot();

            // Act
            cut.Find("button").Click();

            // Assert
            var currentCount = cut.GetChangesSinceSnapshot().ShouldHaveSingleChange();
            currentCount.ShouldBeTextChange("Current count: 1");
        }
    }
}