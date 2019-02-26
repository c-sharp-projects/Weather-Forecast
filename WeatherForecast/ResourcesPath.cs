using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class WeatherPath
    {
        public static string path = AppDomain.CurrentDomain.BaseDirectory + @"\Theme 1";
        public static string BgDaySky = path + @"\Weather Forecast\Background\DaySky.jpg";
        public static string BgNightSky = path + @"\Weather Forecast\Background\NightSky.jpg";

        public static string DayClearSky = path + @"\Weather Forecast\Images\DayClearSky.png";
        public static string DayClouds = path + @"\Weather Forecast\Images\DayClouds.png";
        public static string NightClearSky = path + @"\Weather Forecast\Images\NightClearSky.png";
        public static string NightClouds = path + @"\Weather Forecast\Images\NightClouds.png";
        public static string ScatteredClouds = path + @"\Weather Forecast\Images\ScatteredClouds.png";
        public static string BrokenClouds = path + @"\Weather Forecast\Images\BrokenClouds.png";

        public static string SearchIcon = path + @"\Weather Forecast\Icon\Search.png";


    }
}
