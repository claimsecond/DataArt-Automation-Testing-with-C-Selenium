using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using static Framework2.Pages.BasePage;

namespace Framework2.Pages;

public class ButtonsPage : BasePage
{
    public ButtonsPage(IWebDriver driver) : base(driver) { }
    
    // Locators
    private IWebElement DoubleClickButton => driver.FindElement(By.Id("doubleClickBtn"));
    private IWebElement RightClickButton => driver.FindElement(By.Id("rightClickBtn"));
    private IWebElement DynamicButton => driver.FindElement(By.XPath("//*[contains(text(), 'Click Me')]"));
    private IWebElement DoubleClickMessage => driver.FindElement(By.Id("doubleClickMessage"));
    private IWebElement RightClickMessage => driver.FindElement(By.Id("rightClickMessage"));
    private IWebElement DynamicClickMessage => driver.FindElement(By.Id("dynamicClickMessage"));
    
    //Interactions
    public void clickDoubleClickButton()
    {
        Actions action = new Actions(driver); 
        action.DoubleClick(DoubleClickButton).Perform();
    }
    
    public string GetDoubleClickMessage()
    {
        return DoubleClickMessage.Text;
    }

    public void clickRightClickButton()
    {
        Actions actions = new Actions(driver);
        actions.ContextClick(RightClickButton).Perform();
    }

    public string GetRightClickMessage()
    {
        return RightClickMessage.Text;
    }

    public void clickDynamicClickButton()
    {
        DynamicButton.Click();
    }

    public string GetDynamicClickMessage()
    {
        return DynamicClickMessage.Text;
    }
}