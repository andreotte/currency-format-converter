using System;

namespace currency_format_converter
{
    public class FormattedCurrency
    {
        // parameter
        private readonly double _usd;

        // Constructor
        public FormattedCurrency(double usd)
        {
             _usd = usd;
        }

        // Methods to format different currencies
        public string ToSwedishKrona()
        {
            string krona = string.Format("{0:n}", _usd).Replace( ',', ' ');
            return "Sweedish: " + krona + " kr";
        }
        public string ToUsd()
        {
            return "US: $" + string.Format("{0:n}", _usd);
        }
        public string ToJapanese()
        {
            return  "Japanese: ￥"  + string.Format("{0:n}", _usd);
        }
        public string ToThai()
        {
            return "Thai: ฿" + string.Format("{0:n}", _usd);
        }
    }
}
