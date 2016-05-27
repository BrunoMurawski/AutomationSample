        public IWebElement SearchInGrid(String stringPresentInGridElement)
        {
            try
            {
                var selector = "//*[contains(text(), '" + stringPresentInGridElement + "')]";
                var gridSelector = driver.FindElement(By.XPath(selector));
                return gridSelector;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public void Click(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until((l) => { return element; });
            element.Click();
        }
        
        public void ClickClickable(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until((l) => { return element; });
            element.Click();
        }
        
        public void InputText(IWebElement element, string text)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until((l) => { return element; });
            element.Clear();
            element.SendKeys(text);
        }
        
        public void PressEnterInField(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until((l) => { return element; });
            element.SendKeys(Keys.Return);
        }
        
        public void Wait(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until((l) => { return element; });
        }
        
        public void WaitVisible(String element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }

        public void WaitClickable(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void WaitExists(String element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector(element)));
        }
        
        public void WaitForElementLoad(String element, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
            }
        }

        public void WaitFrame(String element)
        {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.CssSelector(element)));
        }
        
        public void Hover(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void GoToIframe(String element)
        {
            driver.SwitchTo().Frame(driver.FindElement(By.CssSelector(element)));
        }

        public void GoOutIframe()
        {
            driver.SwitchTo().DefaultContent();
        }
        
        public bool ElementExists(IWebElement element)
        {
            if (element == null)
            {
                return false;
            }
            return true;
        }
        
        public Boolean ElementDisplayed(IWebElement element)
        {
            Boolean elementDisplayed = false;
            if (element.Displayed)
            {
                elementDisplayed = true;
            }
            return elementDisplayed;
        }
