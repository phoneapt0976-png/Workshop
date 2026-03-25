namespace MoviesMiniProject.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }

        // ⭐ คะแนนหนัง
        public double Rating { get; set; }

        // 🎬 ลิงก์ตัวอย่างหนัง
        public string TrailerUrl { get; set; }
    }
}