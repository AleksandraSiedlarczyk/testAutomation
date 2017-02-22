using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace Herokuapp.Pages
{
    public class SortableTablesPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "table1")]
        public IWebElement Table { get; set; }

        public List<IWebElement> TableRows
        {
            get { return Table.FindElements(By.TagName("tr")).ToList(); }
        }

        private const string URL = @"http://the-internet.herokuapp.com/tables";

        public SortableTablesPage(IWebDriver driver) : base(driver)
        {
        }

        public void Navigate()
        {
            WebDriver.Navigate().GoToUrl(URL);
        }

        public string GetEmailOf(string name)
        {
            string firstName = name.Split(' ').First();
            string lastName = name.Split(' ').Last();
            IWebElement row = TableRows.Find(x => x.Text.Contains(firstName) && x.Text.Contains(lastName));
            return row.FindElement(By.CssSelector("td:nth-of-type(3)")).Text;
        }

    }
}
