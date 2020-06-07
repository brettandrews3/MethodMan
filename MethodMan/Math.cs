using System;
namespace MethodMan
{
    public class Math
    {
        public static int Num1 { get; set; }
        public static int Num2 { get; set; }
        public object Sum(int sum) => Num1 + Num2;
    }
}
