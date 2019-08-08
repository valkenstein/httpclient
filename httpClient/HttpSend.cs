using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httpClient
{
    class HttpSend
    {
        public string param = "";
        public string url;
        public HttpClient client;
        public HttpWebRequest request;
        private Control.ControlCollection paramsItem;
        private Control.ControlCollection HeaderItem;
        public string result;
      

        public void Start(string url, Control.ControlCollection paramsItem, Control.ControlCollection HeaderItem) {


             
            this.url = url;
            this.paramsItem = paramsItem;
            this.HeaderItem = HeaderItem;
            param = "";
            result = "";

            client = new HttpClient();


            foreach (Panel item in paramsItem)
            {
                TableLayoutPanel table = (TableLayoutPanel)item.Controls[0];
                TextBox txt1 = (TextBox)table.GetControlFromPosition(0, 0);
                TextBox txt2 = (TextBox)table.GetControlFromPosition(1, 0);

                if (txt1.Text != "key" && txt2.Text != "value")
                {
                    param += "&" + txt1.Text + "=" + txt2.Text;

                }
                else if (txt1.Text != "key" && txt2.Text == "value") {
                    param += "&" + txt1.Text + "=" + "";
                }
            }
            param = param.Trim(new char[] { '&' });
            
            if (!url.Contains('?'))
                param = "?" + param;


            try
            {
                request = (HttpWebRequest)WebRequest.Create(url + param);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
                
            }
             
             

            foreach (Panel item in HeaderItem)
            {
                TableLayoutPanel table = (TableLayoutPanel)item.Controls[0];
                TextBox txt1 = (TextBox)table.GetControlFromPosition(0, 0);
                TextBox txt2 = (TextBox)table.GetControlFromPosition(1, 0);

                if (txt1.Text != "key" && txt2.Text != "value")
                {
                    try
                    {
                        client.DefaultRequestHeaders.Add(txt1.Text, txt2.Text);
                        request.Headers.Add(txt1.Text, txt2.Text);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("упс"+ex.Message);
                        return;
                    } 
                } 
            } 
            Console.WriteLine();
        }

        string FormatJson(string json )
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }
        public async void GetAsync(string uri, RichTextBox box, string MethodType)
        {


            if (request == null) return;


            request.Method = MethodType;
            request.ContentType = "application/json";
            request.ContentLength = 0;
            request.Expect = "application/json";

            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    //   MessageBox.Show(stream..ToString());
                    var json = await reader.ReadToEndAsync();
                    try
                    {
                        box.Text = $"length={FormatJson(json).Length}+ \n" + FormatJson(json);
                    }
                    catch (Exception)
                    {

                        var url = uri;
                        var web = new HtmlWeb();
                        var doc = web.Load(url);

                      
                        box.Text = doc.ParsedText;


                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
             
        }
        
        public async void RequestServer (RichTextBox ResultRequestBox, string methodType)
        { 
            try
            {
               // var json   = await client.GetStringAsync(url+param);
                // SearchResult resultt = JsonConvert.DeserializeObject<SearchResult>(json);
                 GetAsync(url + param, ResultRequestBox, methodType);

               // box.Text = FormatJson(json);

            }
            catch (Exception ex)
            {
                MessageBox.Show("упс "+ex.Message);
                return;
            }
             
            Console.WriteLine();
        }

    }
    class SearchResult
    {
        [JsonProperty("readLink")]
        public string ReadLink { get; set; }
        [JsonProperty("webSearchUrl")]
        public string WebSearchUrl { get; set; }
        [JsonProperty("totalEstimatedMatches")]
        public int TotalEstimatedMatches { get; set; }
        [JsonProperty("value")]
        public List<Image> Images { get; set; }

        [JsonProperty("nextOffsetAddCount")]
        public int NextOffsetAddCount { get; set; }
        [JsonProperty("displayShoppingSourcesBadges")]
        public bool DisplayShoppingSourcesBadges { get; set; }
        [JsonProperty("displayRecipeSourcesBadges")]
        public bool DisplayRecipeSourcesBadges { get; set; }
    }
}
