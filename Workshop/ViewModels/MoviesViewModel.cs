using System.Collections.ObjectModel;
using System.ComponentModel;
using Workshop.Models;

namespace Workshop.ViewModels
{
    public class MoviesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Movie> Movies { get; } = new ObservableCollection<Movie>();

        public MoviesViewModel()
        {
            Movies.Add(new Movie {
                Title = "The Shawshank Redemption",
                Year = "1994",
                Genre = "Drama",
                Poster = "the_shawshank_redemption.png",
                Description = "เรื่องราวของชายคนหนึ่งที่ถูกตัดสินจำคุกอย่างไม่เป็นธรรม แต่เขาไม่ยอมแพ้ ใช้ความหวัง ความฉลาด และมิตรภาพกับเพื่อนนักโทษเพื่อค้นหาหนทางหลุดพ้นและการไถ่บาป"
            });

            Movies.Add(new Movie {
                Title = "The Godfather",
                Year = "1972",
                Genre = "Crime",
                Poster = "the_godfather.png",
                Description = "มหากาพย์ชีวิตของตระกูลมาเฟีย คอเลโอเน่ ที่ต้องต่อสู้รักษาอำนาจและเกียรติยศของตระกูล โดยเน้นเรื่องความจงรักภักดี ความละโมบ และการสืบทอดอำนาจ"
            });

            Movies.Add(new Movie {
                Title = "The Dark Knight",
                Year = "2008",
                Genre = "Action",
                Poster = "the_dark_knight.png",
                Description = "แบทแมนเผชิญหน้ากับวายร้ายจอมวางแผนจิตวิปลาส ที่บังคับให้เมืองต้องเผชิญกับความโกลาหล เรื่องนี้สำรวจความยุติธรรม ความรับผิดชอบ และเส้นแบ่งระหว่างฮีโร่กับผู้บ้า"
            });

            Movies.Add(new Movie {
                Title = "Pulp Fiction",
                Year = "1994",
                Genre = "Crime",
                Poster = "pulp_fiction.png",
                Description = "หนังที่เล่าเรื่องแบบไม่เรียงลำดับเกี่ยวกับกลุ่มตัวละครในโลกใต้ดินของอาชญากรรม เต็มไปด้วยบทสนทนาที่คมคาย สถานการณ์คาดเดาไม่ได้ และความตลกร้าย"
            });

            Movies.Add(new Movie {
                Title = "Fight Club",
                Year = "1999",
                Genre = "Drama",
                Poster = "fight_club.png",
                Description = "ชายหนุ่มที่หมดหวังในชีวิตร่วมตั้งชมรมต่อสู้ใต้ดินเพื่อระบายความเป็นชาย แต่เมื่อไอเดียนี้ลุกลามเป็นสิ่งที่ควบคุมไม่ได้ ก็เริ่มตั้งคำถามถึงตัวตนและสังคมทันสมัย"
            });

            Movies.Add(new Movie {
                Title = "Forrest Gump",
                Year = "1994",
                Genre = "Drama",
                Poster = "forrest_gump.png",
                Description = "เรื่องเล่าชีวิตของชายธรรมดาคนหนึ่งที่ไปเกี่ยวข้องกับเหตุการณ์สำคัญทางประวัติศาสตร์หลายเหตุการณ์ ด้วยมุมมองใสซื่อและความตั้งใจ ทำให้สะท้อนความรัก การสูญเสีย และความหมายของชีวิต"
            });

            Movies.Add(new Movie {
                Title = "Inception",
                Year = "2010",
                Genre = "Sci-Fi",
                Poster = "inception.png",
                Description = "ทีมโจรกรรมข้อมูลระหว่างความฝัน ใช้เทคนิคการบุกเข้าไปในจิตใต้สำนึกเพื่อฝังความคิด แต่ภารกิจนี้เต็มไปด้วยชั้นของความฝันและผลกระทบทางอารมณ์ที่ซับซ้อน"
            });

            Movies.Add(new Movie {
                Title = "The Matrix",
                Year = "1999",
                Genre = "Sci-Fi",
                Poster = "the_matrix.png",
                Description = "ชายหนุ่มค้นพบว่าโลกที่เขาอยู่เป็นเพียงการจำลองทางคอมพิวเตอร์ และต้องตัดสินใจต่อสู้เพื่อเสรีภาพของมนุษยชาติ เรื่องนี้ผสมแอคชัน ปรัชญา และเทคโนโลยี"
            });

            Movies.Add(new Movie {
                Title = "Interstellar",
                Year = "2014",
                Genre = "Sci-Fi",
                Poster = "interstellar.png",
                Description = "นักบินอวกาศออกเดินทางข้ามกาแล็กซีเพื่อค้นหาบ้านใหม่ให้มนุษยชาติ เรื่องเน้นการค้นพบทางวิทยาศาสตร์ การเสียสละ และความสัมพันธ์ระหว่างพ่อกับลูก"
            });

            Movies.Add(new Movie {
                Title = "Parasite",
                Year = "2019",
                Genre = "Thriller",
                Poster = "parasite.png",
                Description = "ละครเชิงเสียดสีสังคมเกี่ยวกับครอบครัวยากจนที่ค่อยๆ แทรกซึมเข้าไปในชีวิตของครอบครัวร่ำรวย เหตุการณ์บานปลายเป็นเรื่องร้อนแรงที่สะท้อนความเหลื่อมล้ำ"
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}