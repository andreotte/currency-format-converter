using System;

namespace currency_format_converter
{
    public class CurrencyCalculator
    {
        //Parameters
        private readonly double[] _values;

        //Constructor
        public CurrencyCalculator(double[] values)
        {
            _values = values;
        }
        //Method to find total
        public double ReturnTotal() 
        {
            double total = 0.0;
            for (int i = 0; i < _values.Length; i++)
            {
                total += _values[i];
            }
            return (double)total;
        }

        //Method to find average
        public double ReturnMean()
        {
            double total = 0.0;
            for (int i = 0; i < _values.Length; i++)
            {
                total += _values[i];
            }
            return (double)total / _values.Length;
        }

        //Method to find latgest
        public double ReturnLargest()
        {
            double largest = 0;
            for (int i = 0; i < _values.Length; i++)
            {
                if(_values[i] > largest) 
                {
                    largest = _values[i];
                }
            }
            return largest;
        }

        //Method to find smallest
        public double ReturnSmallest()
        {
            double smallest = _values[0];
            for (int i = 0; i < _values.Length; i++)
            {
                if (_values[i] < smallest)
                {
                    smallest = _values[i];
                }
            }
            return smallest;
        }
    }
}
