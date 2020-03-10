using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumOfTemps = 0;

            foreach (int temp in _temperatures)
            {
                sumOfTemps += temp;
            }

            int averageTemps = sumOfTemps / _temperatures.Count;
            return averageTemps; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int aboveCount = 0;

            foreach (int temp in _temperatures)
            {
                if (threshold < temp)
                {
                    aboveCount++;
                }
            }
            return aboveCount; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int belowCount = 0;

            foreach (int temp in _temperatures)
            {
                if (threshold > temp)
                {
                    belowCount++;
                }
            }
            return belowCount; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int atCount = 0;

            foreach (int temp in _temperatures)
            {
                if (threshold == temp)
                {
                    atCount++;
                }
            }
            return atCount; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            int tempNumber = _temperatures.Count;
            return tempNumber; // <-- Replace this with the number
        }
    }
}
