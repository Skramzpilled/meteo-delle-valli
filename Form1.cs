using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taizzor;
using System.IO;
using System.Diagnostics;
using System.Threading;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;
using ImageResizer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace taizzor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
       

        private int num = 0;



       private void Form1_resize(object sender, EventArgs e)
        {
            this.Size = new Size(800, 800);
        }
        private async void btncerca_Click(object sender, EventArgs e)
        {

            var luogo = dungeonComboBox1.Text;
            luogo = luogo.Replace(" ", "_");

            string url = $"https://www.dovesciare.it/webcam/{luogo}";
            var img1 = "";  



            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;
            try
            {
                WebPage webpage = await browser.NavigateToPageAsync(new Uri(url));

                var webcam = webpage.Html.OwnerDocument.DocumentNode.CssSelect("div.row").ToList()[1];
                var urlImg = webpage.Html.OwnerDocument.DocumentNode.CssSelect("section.col-sm-12");
                var region = urlImg.CssSelect("div.region");
                var webc = region.CssSelect("article.webcam");
                var jumbotron = webc.CssSelect("div.jumbotron");
                var container = jumbotron.CssSelect("div.container");
                var row = container.CssSelect("div.row");
                var blocco = row.CssSelect("div#webcam_intro_left").ToList();
                var img = blocco.CssSelect("img.img-responsive").First().GetAttributeValue("src");
                img1 = $"https://www.dovesciare.it{img}";
                var request = WebRequest.Create(img1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {

                using (WebClient webClient = new WebClient())
                using (MemoryStream originalStream = new MemoryStream(webClient.DownloadData(img1)))
                {

                    using (Image originalImage = Image.FromStream(originalStream))
                    {

                        int newWidth = 400;
                        int newHeight = 400;

                        // Resize the image
                        using (Image resizedImage = new Bitmap(newWidth, newHeight))
                        using (Graphics graphics = Graphics.FromImage(resizedImage))
                        {
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);


                            Bitmap bitmap = new Bitmap(resizedImage);


                            hopePictureBox1.Image = bitmap;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }






        }

        private void dungeonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }









        private async void lostCancelButton2_Click(object sender, EventArgs e)
        {
            var luogo = dungeonComboBox1.Text;

            string url = $"https://www.google.com/search?q={luogo}+piste+sci&tbm=isch&source=lnms";
            //textBox1.Text = url;

            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;

            WebPage webpage = await browser.NavigateToPageAsync(new Uri(url));

            //rg_i

            //var prova = webpage.Html.OwnerDocument.DocumentNode.CssSelect("div.BnJWBc").ToList();
            var html = webpage.Html.OwnerDocument.DocumentNode.CssSelect("html").First().InnerHtml;

            System.IO.File.WriteAllText(@"test.html", html);

            var prova = webpage.Html.OwnerDocument.DocumentNode.CssSelect("img.DS1iW").ToList();
            var urlImg = webpage.Html.OwnerDocument.DocumentNode.CssSelect("img.DS1iW").First().GetAttributeValue("src");



            var request = WebRequest.Create(urlImg);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                hopePictureBox2.Image = Bitmap.FromStream(stream);
            }
            try
            {

                using (WebClient webClient = new WebClient())
                using (MemoryStream originalStream = new MemoryStream(webClient.DownloadData(urlImg)))
                {

                    using (Image originalImage = Image.FromStream(originalStream))
                    {

                        int newWidth = 400;
                        int newHeight = 400;

                        // Resize the image
                        using (Image resizedImage = new Bitmap(newWidth, newHeight))
                        using (Graphics graphics = Graphics.FromImage(resizedImage))
                        {
                            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);


                            Bitmap bitmap = new Bitmap(resizedImage);


                            hopePictureBox2.Image = bitmap;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private async void lostCancelButton1_Click(object sender, EventArgs e)
        {
            var luogo = dungeonComboBox1.Text;
            luogo = luogo.Replace(" ", "+");
            string url = $"https://www.3bmeteo.com/meteo/{luogo}";




            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;


     
            // Inizializza il WebDriver di Chrome
            ChromeOptions options = new ChromeOptions();
          
            options.AddArgument("--headless"); // Esegui Chrome in modalità headless
           
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true; // Nascondi la finestra della riga di comando di Chrome

            IWebDriver driver = new ChromeDriver(driverService,options);

            // Naviga verso la pagina web
            driver.Navigate().GoToUrl($"https://www.3bmeteo.com/meteo/{luogo}");



            try
            {
                // Trova il bottone tramite il selettore CSS, XPath o altri metodi di localizzazione
                var button = driver.FindElement(By.CssSelector("div#iubenda-cs-banner"));
                var button1 = button.FindElement(By.CssSelector("div.iubenda-cs-container"));
                var button2 = button1.FindElement(By.CssSelector("div.iubenda-cs-content"));
                var button3 = button2.FindElement(By.CssSelector("div.iubenda-cs-rationale"));
                var button4 = button3.FindElement(By.CssSelector("div.iubenda-cs-opt-group"));
                var button5 = button4.FindElement(By.CssSelector("div.iubenda-cs-opt-group-consent"));
                var button6 = button5.FindElement(By.CssSelector("button.iubenda-cs-accept-btn"));


                // Esegui il clic sul bottone
                button6.Click();

                IWebElement divElement = driver.FindElement(By.XPath("//div[@id='wrapper']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child = divElement.FindElement(By.XPath(".//section[@id='main']")); // Cambia 'tuo_id_div' con l'id effettivo del tuo div
                IWebElement child1 = child.FindElement(By.XPath(".//div[@class='box noMarg']"));
                //IWebElement child2 = child1.FindElement(By.XPath(".//div[@class='noMarg']"));


                Screenshot screenshot = ((ITakesScreenshot)child1).GetScreenshot();

                // Converti lo screenshot in un'immagine
                using (MemoryStream stream = new MemoryStream(screenshot.AsByteArray))
                using (Image image = Image.FromStream(stream))
                {
                    // Ridimensiona l'immagine
                    int newWidth = 400; // Larghezza desiderata
                    int newHeight = 400; // Altezza desiderata
                    using (Bitmap resizedImage = new Bitmap(image, newWidth, newHeight))
                    {
                        // Salva l'immagine ridimensionata
                        resizedImage.Save($"div_screenshot{num}.png", ImageFormat.Png);
                    }
                }
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Uno dei div non è stato trovato: " + ex.Message);
            }
            finally
            {
                driver.Quit();
                hopePictureBox3.Image = Image.FromFile($"div_screenshot{num}.png");
                num++;
            }


        }
    }




}




