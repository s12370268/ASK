﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASK.TestDrivenDevelopment
{
    public static class ROCDateTimeExtensions
    {

        public static string UtcDate(this DateTime target)
        {
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            var result = target.ToLocalTime().ToString("yyy.MM.dd", culture);
            return result;
        }


        public static string LittleBitDate(this DateTime target)
        {
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            var result = target.ToString("yyy.MM.dd", culture);
            return result;
        }


        public static string ShortDate(this DateTime target)
        {
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            var result = target.ToString("yyy年MM月dd日", culture);
            return result;
        }


        public static string LognData(this DateTime target)
        {
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            var result = target.ToString("民國yyy年MM月dd日", culture);
            return result;
        }


        public static string LongDateAndWeek(this DateTime target)
        {
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            var result = target.ToString("民國yyy年MM月dd日 ddd", culture);
            return result;
        }



        public static string LongDateAndLongWeek(this DateTime target)
        {
            CultureInfo culture = new CultureInfo("zh-TW");
            culture.DateTimeFormat.Calendar = new TaiwanCalendar();
            var result = target.ToString("民國yyy年MM月dd日 dddd ", culture);
            return result;
        }
    }
}
