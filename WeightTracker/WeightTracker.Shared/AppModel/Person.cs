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
                { new DateTime(2015, 9, 10), 96.6f },
                { new DateTime(2015, 9, 11), 97.0f },
                { new DateTime(2015, 9, 12), 96.6f },
                { new DateTime(2015, 9, 13), 96.8f },
                { new DateTime(2015, 9, 14), 96.2f },
                { new DateTime(2015, 9, 15), 95.8f },
                { new DateTime(2015, 9, 16), 95.6f },
                { new DateTime(2015, 9, 17), 95.4f },
                { new DateTime(2015, 9, 19), 96.0f },
            };

            HeightHistory = new Dictionary<DateTime, float>
            {
                { new DateTime(2015, 9, 4), 1.76f },
            };
        }
        
        public IDictionary<DateTime, float> HeightHistory { get; private set; }

        public IDictionary<DateTime, float> WeightHistory { get; private set; }
    }
}