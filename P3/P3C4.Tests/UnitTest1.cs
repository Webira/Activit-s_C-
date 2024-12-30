using NUnit.Framework;
using System.Numerics;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3C4;

namespace P3C4.Tests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
        [Test]
        public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
        {
            await Page.GotoAsync("https://playwright.dev");

            // Expect a title "to contain" a substring.
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // create a locator
            var getStarted = Page.Locator("text=Get Started");

            // Expect an attribute "to be strictly equal" to the value.
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // Click the get started link.
            await getStarted.ClickAsync();

            // Expects the URL to contain intro.
            await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        }

    }
    [TestFixture]
    public class CompteTests
    {
        [Test]
        public void ConsulterSoldo_ReturnsInitialSoldo()
        {
            // Arrange
            Compte compte = new Compte("Bover", "123456a789", 1000.00f);

            // Act
            float result = compte.ConsulterSoldo();

            // Assert
            Assert.AreEqual(1000.00f, result, "Le solde initial devrait être 1000.00");
        }

        [Test]
        public void Depot_AddsAmountToSoldo()
        {
            // Arrange
            Compte compte = new Compte("Bover", "123456a789", 1000.00f);

            // Act
            compte.Depot(500.00);
            float result = compte.ConsulterSoldo();

            // Assert
            Assert.AreEqual(1500.00f, result, "Après un dépôt de 500, le solde devrait être 1500.00");
        }
    }

}
