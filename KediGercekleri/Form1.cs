using System.Net.Http.Json;

namespace KediGercekleri
{
    public partial class Form1 : Form
    {
        string adres = "https://cat-fact.herokuapp.com/facts";
        string adres2 = "https://raw.githubusercontent.com/hjorturlarsen/IMDB-top-100/master/data/movies.json";

        public Form1()
        {
            InitializeComponent();
            GercekleriGetirVeYukle();
        }

        private void GercekleriGetirVeYukle()
        {
            using (var client = new HttpClient())
            {
                List<Fact> gercekler = client
                    .GetFromJsonAsync<List<Fact>>(adres)
                    .GetAwaiter()
                    .GetResult()!;

                dgvGercekler.DataSource = gercekler;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using(var client = new HttpClient())
            {
                List<Movie>? movies = await client.GetFromJsonAsync<List<Movie>>(adres2);

                if (movies != null)
                {
                    dgvMovies.DataSource = movies;
                }
            }
        }
    }
}