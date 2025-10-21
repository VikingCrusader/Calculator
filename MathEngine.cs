using System;

//此程序：运算核心逻辑
namespace ModernCalculator
{
    // 计算引擎类
    public static class MathEngine
    {
        // 加法
        public static double Add(double x, double y) { return x + y; }

        // 减法
        public static double Subtract(double x, double y) { return x - y; }

        // 乘法
        public static double Multiply(double x, double y) { return x * y; }

        // 除法
        public static double Divide(double x, double y) { return x / y; }

        // x的y次方
        public static double Power(double x, double y) { return Math.Pow(x, y); }

        // x的y次方根
        public static double Root(double x, double y) { return Math.Pow(x, 1.0 / y); }

        // 字符串转变为double类型，再用加法
        public static string Add(string x, string y)
        {
            return Add(double.Parse(x), double.Parse(y)).ToString();
        }

        // 字符串转变为double类型，再用减法
        public static string Subtract(string x, string y)
        {
            return Subtract(double.Parse(x), double.Parse(y)).ToString();
        }

        // 字符串转变为double类型，再用乘法
        public static string Multiply(string x, string y)
        {
            return Multiply(double.Parse(x), double.Parse(y)).ToString();
        }

        // 字符串转变为double类型，再用除法
        public static string Divide(string x, string y)
        {
            return Divide(double.Parse(x), double.Parse(y)).ToString();
        }

        // 字符串转变为double类型，再用乘方
        public static string Power(string x, string y)
        {
            return Power(double.Parse(x), double.Parse(y)).ToString();
        }

        // 字符串转变为double类型，再用开根
        public static string Root(string x, string y)
        {
            return Root(double.Parse(x), double.Parse(y)).ToString();
        }
    }
}