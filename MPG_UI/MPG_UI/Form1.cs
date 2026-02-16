using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;


namespace MPG_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPredict_Click(object sender, EventArgs e)
        {

            const string apiKey = "HxvfnmInRAy9tL2VGbgQkbnSqGbfIEGk";
            const string uri = "http://0a7c2f24-6907-48d8-9214-3b4575e324a8.polandcentral.azurecontainer.io/score";

            const double CM3_TO_CUBIC_INCH = 0.0610237;
            const double KG_TO_LBS = 2.20462;

            if (!double.TryParse(textDisplacement.Text, out double displacementCm3) || !double.TryParse(textWeight.Text, out double weightKg))
            {
                MessageBox.Show("Molimo unesite ispravne brojèane vrijednosti.");
                return;
            }

            double displacementInches = displacementCm3 * CM3_TO_CUBIC_INCH;
            double weightLbs = weightKg * KG_TO_LBS;


            string jsonBody = $@"{{
                ""Inputs"": {{
                ""input1"": [
                    {{
                    ""mpg"": 0,
                    ""cylinders"": {textNmbrCylinders.Text},
                    ""displacement"": {textDisplacement.Text},
                    ""horsepower"": {textHorsepowers.Text},
                    ""weight"": {textWeight.Text},
                    ""acceleration"": {textAcceleration.Text}
                    }}
                ]
                }},
                ""GlobalParameters"": {{}}
            }}";

            lblResult.Text = "Raèunam...";

            try
            {
                // Koristimo HttpClientHandler jer Azureov predložak to preporuèuje za SSL
                var handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
                };

                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(uri, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        responseString = await response.Content.ReadAsStringAsync();

                        using JsonDocument doc = JsonDocument.Parse(responseString);

                        double mpg = doc
                            .RootElement
                            .GetProperty("Results")
                            .GetProperty("WebServiceOutput0")[0]
                            .GetProperty("Scored Labels")
                            .GetDouble();

                        double kmPerLiter = mpg * 0.425144;

                        lblResult.Text = $"MPG: {mpg:F2}  |  {kmPerLiter:F2} km/l";
                    }
                    else
                    {
                        MessageBox.Show("Greška: " + response.StatusCode + "\n" + responseString);
                        lblResult.Text = "Greška u zahtjevu.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistemska greška: " + ex.Message);
            }
        }

        private void textWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
