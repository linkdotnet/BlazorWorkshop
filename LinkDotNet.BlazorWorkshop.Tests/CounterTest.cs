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
        public void GivenIndexPage_WhenResettingCounter_ThenValueIsZero()
        {
            // Arrange
            var cut = RenderComponent<Index>();
            cut.SaveSnapshot();
            cut.Find("#increment-counter").Click();
            cut.GetChangesSinceSnapshot().ShouldHaveSingleTextChange("Current count: 1");

            // Act
            cut.SaveSnapshot();
            cut.Find("#reset-counter").Click();
            var diff = cut.GetChangesSinceSnapshot().ShouldHaveSingleChange();

            // Assert
            diff.ShouldBeTextChange("Current count: 0");
        }
    }
}