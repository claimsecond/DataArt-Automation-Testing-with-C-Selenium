using System;
using System.IO;
using OpenQA.Selenium;

namespace Framework2.Settings;

public class DriverHelper
{
    internal static string MakeScreenshot(IWebDriver driver, string testName)
    {
        string screenshotFolder = @"/home/claim/Documents";
        string screenshotPath = string.Empty;

        if (driver != null)
        {
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            var dateTimeStr = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            var screenshotName = $"{testName}-{dateTimeStr}.png";

            screenshotPath = Path.Combine(screenshotFolder, screenshotName);
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
        }

        return screenshotPath;
    }
}