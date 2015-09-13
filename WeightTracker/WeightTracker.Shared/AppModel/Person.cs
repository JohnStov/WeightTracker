using System;
using System.Collections.Generic;

namespace WeightTracker.AppModel
{
    public class Person
    {
        public Person()
        {
            WeightHistory = new Dictionary<DateTime, float>
            {
                { new DateTime(2015, 9, 4), 96.4f },
                { new DateTime(2015, 9, 5), 96.2f },
                { new DateTime(2015, 9, 7), 95.8f },
                { new DateTime(2015, 9, 8), 95.8f },
                { new DateTime(2015, 9, 9), 96.0f },
                {  new DateTime(2015, 9, 10), 96.6f },
                {  new DateTime(2015, 9, 11), 97.0f },
                { new DateTime(2015, 9, 12), 96.6f },
                { new DateTime(2015, 9, 13), 96.8f },
            };
        }
        
        public float Height { get; private set; } = (float) 1.76;

        public IDictionary<DateTime, float> WeightHistory { get; private set; }
    }
}