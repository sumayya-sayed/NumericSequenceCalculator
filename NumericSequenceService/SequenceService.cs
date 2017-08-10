using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceService
{
    public class SequenceService
    {
        public string GetAllNumbers(int num)
        {
            var allNumberList = new List<int>();

            int i = 1;
            while (i <= num)
            {
                allNumberList.Add(i);
                i++;
            }

            return string.Join(",", allNumberList.ToArray());

        }

        public string GetOddNumbers(int num)
        {

            var oddNumberList = new List<int>();


            int i = 1;
            while (i <= num)
            {
                if (i % 2 != 0)
                    oddNumberList.Add(i);

                i++;
            }
            if (!oddNumberList.Contains(num))
                oddNumberList.Add(num);
            return string.Join(",", oddNumberList.ToArray());
        }

        public string GetEvenNumbers(int num)
        {

            var evenNumberList = new List<int>();

            int i = 1;
            while (i <= num)
            {

                if (i % 2 == 0)
                    evenNumberList.Add(i);

                i++;
            }
            if (!evenNumberList.Contains(num))
                evenNumberList.Add(num);
            return string.Join(",", evenNumberList.ToArray());
        }

        public string GetSpecialCode(int num)
        {
            var specialNumber = string.Empty;
            if (num % 3 == 0)
            {
                if (num % 5 == 0)
                    specialNumber = "Z";
                else specialNumber = "C";
            }
            if (num % 5 == 0)
            {
                if (num % 3 == 0)
                    specialNumber = "Z";
                else specialNumber = "E";

            }
            if (string.IsNullOrEmpty(specialNumber))
                specialNumber = GetAllNumbers(num);

            return specialNumber;
        }

        public string GetFibonacciSeries(int num)
        {
            return Fibonacci_Rec_Temp(0, 1, 1, num, new List<int>());
        }

        private string Fibonacci_Rec_Temp(int a, int b, int counter, int len, List<int> febSeries)
        {
            if (febSeries == null)
                febSeries = new List<int>();
            if (a <= len)
            {
                febSeries.Add(a);

                Fibonacci_Rec_Temp(b, a + b, counter + 1, len, febSeries);
            }

            if (!febSeries.Contains(len))
                febSeries.Add(len);
            return string.Join(",", febSeries.ToArray());
        }


    }
}
