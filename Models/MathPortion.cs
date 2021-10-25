using System.Collections.Generic;
using static System.Math;

namespace CodeDivise.Models
{

    public class MathPortion 
    {
        public List<decimal> Portions { get; private set; }
        public decimal Value { get; }
        public decimal Input { get; }
        public decimal Difference { get; }
        public int Divise { get; }
        public MathPortion(decimal value, int divise, decimal input = 0)
        {
            if (divise <= 1) throw new System.Exception("More than 1");
            Portions = new List<decimal>();
            Value = value;
            Input = input;
            Divise = divise;
            Difference = value - input;
        }
        public void Run()
        {
            Portions.Clear();
            decimal portion = Round(Difference / Divise, 2);
            decimal sumPortion = portion * Divise;
            Portions.Add(portion, Divise);
            decimal rest = Difference - sumPortion;
            if (rest > 0)
            {
                Portions[0] += rest;
            } 
            else 
            {
                if (rest < 0)
                {
                    Portions[Divise - 1] += rest;
                }
            }
        }
    }
}