using System;
using AutoSandbox.Units;

namespace AutoSandbox.Demo {
    class Program {
        static void Main(string[] args) {
            MeasuringUnit<double, LengthUnits> diameter;

            diameter.Unit = LengthUnits.Inches;
            diameter.Value = 3D;

            Console.WriteLine(diameter.Notation());
            Console.ReadLine();
        }
    }
}
