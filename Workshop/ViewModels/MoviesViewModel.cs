using System.Collections.ObjectModel;
using MoviesMiniProject.Models;

namespace MoviesMiniProject.ViewModels
{
    public class MoviesViewModel
    {
        public ObservableCollection<Movie> Movies { get; set; }

        public MoviesViewModel()
        {
            Movies = new ObservableCollection<Movie>
            {
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    Year = "1994",
                    Genre = "Drama",
                    Category = "Drama",
                    Poster = "the_shawshank_redemption.png",
                    Rating = 9.3,
                    TrailerUrl = GetYoutubeEmbed("6hB3S9bIaco"),
                    Description = "เรื่องราวของชายคนหนึ่งที่ถูกตัดสินจำคุกอย่างไม่เป็นธรรม แต่เขาไม่ยอมแพ้ ใช้ความหวัง ความฉลาด และมิตรภาพกับเพื่อนนักโทษเพื่อค้นหาหนทางหลุดพ้นและการไถ่บาป"
                },

                new Movie
                {
                    Title = "The Godfather",
                    Year = "1972",
                    Genre = "Crime",
                    Category = "Crime",
                    Poster = "the_godfather.png",
                    Rating = 9.2,
                    TrailerUrl = GetYoutubeEmbed("sY1S34973zA"),
                    Description = "มหากาพย์ชีวิตของตระกูลมาเฟีย คอเลโอเน่ ที่ต้องต่อสู้รักษาอำนาจและเกียรติยศของตระกูล"
                },

                new Movie
                {
                    Title = "The Dark Knight",
                    Year = "2008",
                    Genre = "Action",
                    Category = "Action",
                    Poster = "the_dark_knight.png",
                    Rating = 9.0,
                    TrailerUrl = GetYoutubeEmbed("EXeTwQWrcwY"),
                    Description = "แบทแมนเผชิญหน้ากับวายร้ายจอมวางแผนจิตวิปลาสที่ทำให้เมืองตกอยู่ในความโกลาหล"
                },

                new Movie
                {
                    Title = "Pulp Fiction",
                    Year = "1994",
                    Genre = "Crime",
                    Category = "Crime",
                    Poster = "pulp_fiction.png",
                    Rating = 8.9,
                    TrailerUrl = GetYoutubeEmbed("s7EdQ4FqbhY"),
                    Description = "เรื่องราวแบบไม่เรียงลำดับของตัวละครในโลกอาชญากรรม"
                },

                new Movie
                {
                    Title = "Fight Club",
                    Year = "1999",
                    Genre = "Drama",
                    Category = "Drama",
                    Poster = "fight_club.png",
                    Rating = 8.8,
                    TrailerUrl = GetYoutubeEmbed("qtRKdVHc-cE"),
                    Description = "ชายหนุ่มที่หมดหวังในชีวิตตั้งชมรมต่อสู้ใต้ดินเพื่อระบายความเป็นชาย"
                },

                new Movie
                {
                    Title = "Forrest Gump",
                    Year = "1994",
                    Genre = "Drama",
                    Category = "Drama",
                    Poster = "forrest_gump.png",
                    Rating = 8.8,
                    TrailerUrl = GetYoutubeEmbed("bLvqoHBptjg"),
                    Description = "ชีวิตของชายธรรมดาที่เข้าไปเกี่ยวข้องกับเหตุการณ์สำคัญของโลก"
                },

                new Movie
                {
                    Title = "Inception",
                    Year = "2010",
                    Genre = "Sci-Fi",
                    Category = "SciFi",
                    Poster = "inception.png",
                    Rating = 8.8,
                    TrailerUrl = GetYoutubeEmbed("YoHD9XEInc0"),
                    Description = "ทีมโจรกรรมที่บุกเข้าไปในความฝันเพื่อฝังความคิด"
                },

                new Movie
                {
                    Title = "The Matrix",
                    Year = "1999",
                    Genre = "Sci-Fi",
                    Category = "SciFi",
                    Poster = "the_matrix.png",
                    Rating = 8.7,
                    TrailerUrl = GetYoutubeEmbed("vKQi3bBA1y8"),
                    Description = "โลกที่มนุษย์อยู่จริง ๆ เป็นเพียงการจำลองของคอมพิวเตอร์"
                },

                new Movie
                {
                    Title = "Interstellar",
                    Year = "2014",
                    Genre = "Sci-Fi",
                    Category = "SciFi",
                    Poster = "interstellar.png",
                    Rating = 8.6,
                    TrailerUrl = GetYoutubeEmbed("zSWdZVtXT7E"),
                    Description = "การเดินทางข้ามกาแล็กซีเพื่อค้นหาบ้านใหม่ของมนุษยชาติ"
                },

                new Movie
                {
                    Title = "Parasite",
                    Year = "2019",
                    Genre = "Thriller",
                    Category = "Thriller",
                    Poster = "parasite.png",
                    Rating = 8.5,
                    TrailerUrl = GetYoutubeEmbed("5xH0HfJHsaY"),
                    Description = "ครอบครัวยากจนแทรกซึมเข้าไปในชีวิตของครอบครัวร่ำรวย"
                }
            };
        }

        string GetYoutubeEmbed(string id)
        {
            return $@"
            <html>
            <body style='margin:0;padding:0;background:black;'>
            <iframe width='100%' height='220'
            src='https://www.youtube.com/embed/{id}'
            frameborder='0'
            allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
            allowfullscreen>
            </iframe>
            </body>
            </html>";
        }
    }
}