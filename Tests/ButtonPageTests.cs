using Framework2.Pages;
using NUnit.Framework;

namespace Framework2.Tests
{
    public class ButtonPageTests : BaseTest
    {
        [Test]
        public void TestDoubleClickButton()
        {
            var buttonsPage = new ButtonsPage(driver); 
            buttonsPage.clickDoubleClickButton();
            string actualMessage = buttonsPage.GetDoubleClickMessage();
            string expectedMessage = "You have done a double click"; 
    
            Assert.AreEqual(expectedMessage, actualMessage, "The actual message is not 'You have done a double click'.");
            
        }

        [Test]
        public void TestRightClickButton()
        {
            var buttonsPage = new ButtonsPage(driver);
            buttonsPage.clickRightClickButton();
            string actualMessage = buttonsPage.GetRightClickMessage();
            string expectedMessage = "You have done a right click"; 
    
            Assert.AreEqual(expectedMessage, actualMessage, "The actual message is not 'You have done a right click'.");
        }

        [Test]
        public void TestDynamicClickButton()
        {
            var buttonsPage = new ButtonsPage(driver);
            buttonsPage.clickDynamicClickButton();
            string actualMessage = buttonsPage.GetDynamicClickMessage();
            string expectedMessage = "You have done a dynamic click"; 
    
            Assert.AreEqual(expectedMessage, actualMessage, "The actual message is not 'You have done a dynamic click'.");
        }
    }
}