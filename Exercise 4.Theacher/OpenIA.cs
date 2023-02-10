using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Exercise_4.Theacher
{
    public partial class OpenIA : Form
    {
        public OpenIA()
        {
            InitializeComponent();
        }
        //
        private static string callOpenAI(int tokens, string input, string engine,
                  double temperature, int topP, int frequencyPenalty, int presencePenalty)
        {

            var openAiKey = "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";

            var apiCall = "https://api.openai.com/v1/engines/" + engine + "/completions";

            try
            {

                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), apiCall))
                    {
                        request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + openAiKey);
                        request.Content = new StringContent("{\n  \"prompt\": \"" + input + "\",\n  \"temperature\": " +
                                                            temperature.ToString(CultureInfo.InvariantCulture) + ",\n  \"max_tokens\": " + tokens + ",\n  \"top_p\": " + topP +
                                                            ",\n  \"frequency_penalty\": " + frequencyPenalty + ",\n  \"presence_penalty\": " + presencePenalty + "\n}");

                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                        var response = httpClient.SendAsync(request).Result;
                        var json = response.Content.ReadAsStringAsync().Result;

                        dynamic dynObj = JsonConvert.DeserializeObject(json);

                        if (dynObj != null)
                        {
                            return dynObj.choices[0].text.ToString();
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return null;


        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
            
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            
            var question = textBox1.Text;
            //call the open ai
            var answer = callOpenAI(250, question, "text-davinci-002", 0.7, 1, 0, 0);
           
            //
            textBox2.Text = answer;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //call the open ai
           
            //
        }

        


        //
    }
}
