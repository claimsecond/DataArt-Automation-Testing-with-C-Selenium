using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Framework2.Settings;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework2.Tests;

public class BaseTest
{
    protected IWebDriver driver;
    protected ExtentReports extentReports;
    protected ExtentTest extentTest;

    [OneTimeSetUp]
    public void SetupReporting()
    {
        extentReports = new ExtentReports();

        string reportPath = @"/home/claim/Documents/MyReport.html";
        var htmlReporter = new ExtentHtmlReporter(reportPath);
        extentReports.AttachReporter(htmlReporter);
    }
    
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://demoqa.com/buttons");
        extentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.FullName);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
        {
            extentTest.Log(Status.Pass);
        }
        else
        {
            var path = DriverHelper.MakeScreenshot(driver, TestContext.CurrentContext.Test.MethodName);
            extentTest.AddScreenCaptureFromPath(path);
            extentTest.Log(Status.Fail);
        }
        driver.Quit();
    }

    [OneTimeTearDown]
    public void FlushReport()
    {
        extentReports.Flush();
    }
}