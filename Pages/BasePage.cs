using OpenQA.Selenium;

namespace Framework2.Pages;

public class BasePage
{
    protected IWebDriver driver;

    public BasePage(IWebDriver driver)
    {
        this.driver = driver;
    }
}