using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumReact
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
                IWebDriver chromedriver = new ChromeDriver();
                chromedriver.Manage().Window.Maximize();

                //Register
                chromedriver.Navigate().GoToUrl("http://localhost:3000/seekersignup");
                Thread.Sleep(2000);

                IWebElement fname = chromedriver.FindElement(By.Id("firstname"));
                fname.SendKeys("Rajakumari");
                Thread.Sleep(2000);

                IWebElement lname = chromedriver.FindElement(By.Id("lname"));
                lname.SendKeys("B");
                Thread.Sleep(2000);

                IWebElement registeremail = chromedriver.FindElement(By.Id("email"));
                registeremail.SendKeys("kumari100@gmail.com");
                Thread.Sleep(2000);

            IWebElement phnumber = chromedriver.FindElement(By.Id("phoneNumber"));
            phnumber.SendKeys("9876543212");
            Thread.Sleep(2000);

            IWebElement qualifications = chromedriver.FindElement(By.Id("qualification"));
            qualifications.SendKeys("BSC");
            Thread.Sleep(2000);

            IWebElement registerpassword = chromedriver.FindElement(By.Id("password"));
                registerpassword.SendKeys("Kumari@100");
                Thread.Sleep(2000);

                IWebElement confirmpassword = chromedriver.FindElement(By.Id("confirmPassword"));
                confirmpassword.SendKeys("Kumari@100");
                Thread.Sleep(2000);

                IWebElement register = chromedriver.FindElement(By.Id("btn"));
                register.Click();
                Thread.Sleep(2000);

                // Handle alert
                try
                {
                    IAlert alert = chromedriver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    Console.WriteLine("Alert text: " + alertText);
                    alert.Accept(); // To accept the alert (click OK)
                                    //alert.Dismiss(); // To dismiss the alert (click Cancel)

                    string nextPageUrl = "http://localhost:3000/seekerlogin";
                    chromedriver.Navigate().GoToUrl(nextPageUrl);

                }
                catch (NoAlertPresentException)
                {
                    // No alert present, continue with the rest of the code
                }



                //Login
                chromedriver.Navigate().GoToUrl("http://localhost:3000/seekerlogin");
                Thread.Sleep(2000);

                IWebElement loginemail = chromedriver.FindElement(By.Id("emailid"));
                loginemail.SendKeys("Kumari100@gmail.com");
                Thread.Sleep(2000);

                IWebElement loginpassword = chromedriver.FindElement(By.Id("pswd"));
                loginpassword.SendKeys("Kumari@100");
                Thread.Sleep(2000);

                IWebElement login = chromedriver.FindElement(By.Id("loginbtn"));
                login.Click();
                Thread.Sleep(2000);

                // Handle alert
                try
                {
                    IAlert alert = chromedriver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    Console.WriteLine("Alert text: " + alertText);
                    alert.Accept(); // To accept the alert (click OK)
                                    //alert.Dismiss(); // To dismiss the alert (click Cancel)

                    string nextPageUrl = "http://localhost:3000/SDashboard";
                    chromedriver.Navigate().GoToUrl(nextPageUrl);

                }
                catch (NoAlertPresentException)
                {
                    // No alert present, continue with the rest of the code
                }
            }
        }
    }


   