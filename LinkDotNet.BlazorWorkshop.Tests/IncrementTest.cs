using AngleSharp.Dom;
using Bunit;
using LinkDotNet.BlazorWorkshop.Client.Pages;
using LinkDotNet.BlazorWorksop.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace LinkDotNet.BlazorWorkshop.Tests
{
    [TestClass]
    public class IncrementTest : ComponentTestBase
    {
        [TestMethod]
        public void GivenTwoNumbers_WhenAdding_ThenResultShouldBeShown()
        {
            // Arrange
            var cut = RenderComponent<Increment>();
            var button1 = cut.Find("#number-1");
            var button2 = cut.Find("#number-2");
            button1.Change("1");
            button2.Change("5");
            cut.SaveSnapshot();

            // Act
            cut.Find("button").Click();
            var diff = cut.GetChangesSinceSnapshot().ShouldHaveSingleChange();

            // Assert
            diff.ShouldBeTextChange("6");
        }
    }
}