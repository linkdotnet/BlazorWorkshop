using System;
using System.Linq;
using System.Reflection;
using AngleSharp.Diffing.Core;
using AngleSharp.Dom;
using Bunit;
using LinkDotNet.BlazorWorkshop.Client.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using static Bunit.ComponentParameterFactory;

namespace LinkDotNet.BlazorWorkshop.Tests
{
    [TestClass]
    public class CollapsibleComponentTest : ComponentTestBase
    {
        [TestMethod]
        public void GivenCollapsibleComponent_WhenPressing_ThenHeaderChangesAndInputCollapses()
        {
            const string childContent = "<p>Miau</p>";
            var renderFragmentPropertyName = GetNameOfRenderFragment();
            var cut = RenderComponent<Collapsible>(RenderFragment(renderFragmentPropertyName, childContent));
            cut.SaveSnapshot();

            cut.Find(":first-child").Click();
            cut.GetChangesSinceSnapshot().ShouldHaveChanges(diff => 
                diff.ShouldBeTextChange("Collapse"), diff => diff.ShouldBeAddition(childContent));
            cut.SaveSnapshot();

            cut.Find(":first-child").Click();
            cut.GetChangesSinceSnapshot().ShouldHaveChanges(diff =>
                diff.ShouldBeTextChange("Expand"), diff => diff.ShouldBeRemoval(childContent));
        }

        private static string GetNameOfRenderFragment()
        {
            return typeof(Collapsible)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .FirstOrDefault(p => p.PropertyType == typeof(RenderFragment))?.Name;
        }
    }
}