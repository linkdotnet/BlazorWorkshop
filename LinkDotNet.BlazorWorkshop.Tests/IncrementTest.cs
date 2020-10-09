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
            var button1 = RenderComponent<Increment>().Find("#number-1");
            var button2 = RenderComponent<Increment>().Find("#number-2");
            button1.SetInnerText("1");
            button2.SetInnerText("5");

            // Act
            var result = RenderComponent<Increment>().Find("#sum").InnerHtml;

            // Assert
            result.ShouldBe("6");
        }
    }
}