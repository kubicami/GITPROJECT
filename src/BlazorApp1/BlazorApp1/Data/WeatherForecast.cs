namespace BlazorApp1.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC = 150;

        public int TemperatureF => 9001;

        public int WindSpeedM { get; set; }

        public int WindSpeedKph => WindSpeed * 3.6;

        public string? Summary { get; set; }

        public int DewPoint { get; set; }
    }

    /*
⡿⡿⠟⠓⠛⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣷⣶⣾⣿⣷⣶⣤⣬⣟⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣟⣱⡿⠿⠿⠿⣮⣻⣿⣿⣿⣿⣏⢿⣿⡿⢁⢀⣀⣀⣀⣬⣉⣙⠋⠛⠿⢿⣿
⣟⣛⣡⣤⣤⣁⣀⣄⣉⣻⣿⣿⣿⣿⠛⡿⠻⠛⠭⠿⡿⠯⣭⣟⡻⢿⣶⣦⣀⢙
⣿⣿⣿⣯⣝⣛⣛⣛⣭⣾⣿⣿⣿⢇⣨⢶⣿⣶⡾⢶⣶⡶⢤⣤⣤⣀⠟⢉⣛⣓
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣿⠿⠻⠿⢿⣿⣷⣶⣮⣭⣭⣭⣴⣾⡻⣮⣵
⣿⣿⣿⣿⣿⠟⢋⣽⣿⣿⣿⣿⡿⢿⡿⠿⠿⣆⣉⠻⣿⣿⣿⣿⣿⣿⣿⣷⣽⣿
⣿⣿⣿⠟⢁⣶⣿⣿⣿⣿⣟⢋⣀⣒⣀⣐⣫⡍⠛⠿⠪⠻⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⢏⠀⣿⣏⣠⣽⣍⣍⣡⣾⣿⣿⣟⣋⣋⣓⣓⣼⣥⣤⡈⠻⣿⣿⣿⡏⣿⣿
⣿⣿⡌⢦⢻⣮⡁⣼⣿⢭⣭⣉⣭⣭⣭⣉⣭⢛⡉⣛⢛⡛⠛⣠⡌⣿⣿⣧⣿⣿
⣙⢿⣿⡜⣿⣿⣷⡹⠿⠿⠿⠿⠿⠟⠿⠛⠿⠻⠿⠿⠿⢃⣴⣿⢣⣿⣿⣿⣿⣿
⣿⣿⣿⣿⡜⣿⣿⡗⠦⣀⣀⢀⠐⠒⠀⠀⠀⢀⡀⠀⣠⣾⣿⢏⣾⢏⢽⣻⣿⣿
⣿⣿⣿⠈⠙⣾⣏⢧⣼⣿⣟⣛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣼⡋⠿⣾⣿⣿⣾
⢿⣿⣿⠐⠄⠺⣿⣾⢟⣻⣿⣿⣛⡿⠿⢿⣾⣟⣭⡾⣿⣿⣿⡟⣿⣾⡻⣿⠿⠛
⠀⡹⣿⡆⠈⣠⣿⣷⣿⣿⣿⣿⣿⣿⣿⣷⣬⡛⣻⣿⣿⣿⣿⣹⢖⠝⠁⡳⣾⣾
      */
}