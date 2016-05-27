        [TestInitialize]
        public void SetupTest()
        {

            switch (BrowserUtilizado())
            {
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "Chrome":
					driver = new ChromeDriver(caminhoCombinadoFinal);                    
                    break;
                case "IE":
					driver = new InternetExplorerDriver(caminhoCombinadoFinal);                    
                    break;
            }
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60)); 
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://" + baseURL);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
				Console.WriteLine("Iniciou TeardownTest");
                driver.Quit();
                Console.WriteLine("Encerrou o driver com driver.Quit();");
            }
            catch (Exception)
            {
                driver.Quit();
				Console.WriteLine("Encerrou o driver com driver.Quit();");
            }
        }
