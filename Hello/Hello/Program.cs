using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public static void Main(String[] args)
    {
        IWebDriver webDriver = new ChromeDriver();
        webDriver.Navigate().GoToUrl("http://bigbasket.com");
        IWebElement searchBox = webDriver.FindElement(By.Id("input"));
        searchBox.SendKeys("Potato");
        System.Threading.Thread.Sleep(1000);
        IWebElement searchBtn = webDriver.FindElement(By.XPath("//button[@qa='searchBtn']"));
        searchBtn.Click();
        //System.Threading.Thread.Sleep(1000);
        //int[] A = { 2, 1, 3, 4, 6 };
        //Solution s = new Solution();
        //int answer = s.solution(A);
        webDriver.Quit(); 
    }

    public int solution(int[] A)
    {
        Array.Sort(A);
        int minPosotivieTillyet = 1;
        foreach (int i in A)
        {
            if (i <= 0) continue;
            else if (i == minPosotivieTillyet)
            {
                minPosotivieTillyet += 1;
            }
        }

        return minPosotivieTillyet;
    }
}
