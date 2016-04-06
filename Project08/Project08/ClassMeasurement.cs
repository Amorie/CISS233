/*
Paul Adams
Project 8
4/5/16
*/
using System;

namespace Project08
{
    public class ClassMeasurement
    {
        public ClassMeasurement(DateTime precipDate, Decimal precipAmount)
        {
            PrecipDate = precipDate;
            PrecipAmount = precipAmount;
        }

        public DateTime PrecipDate { get; set; }
        public Decimal PrecipAmount { get; set; }
    }
}
