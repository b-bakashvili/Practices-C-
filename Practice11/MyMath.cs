using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11;

internal class MyMath
{
    public static int Min(int num1, int num2) // 1st task
    {
        return num1 < num2 ? num1 : num2;
    }
    public static int Max(int num1, int num2) // 2nd task
    {
        return num1 > num2 ? num1 : num2;
    }
    public static int Clamp(int value, int min, int max) // 3rd task
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }
    public static int sqrt(int value) // 4th task
    {
        if (value < 0) return -1;
        for (int i = 0; i <= value / 2; i++)
        {
            if (i * i == value) return i;
        }
        return -1;
    }

    public static int Pow(int value, int power) // 5th task
    {
        int result = value;

        for (int i = 0; i < power - 1; i++)
        {
            result *= value;
        }
        return result;
    }

    public static int Round(double value) // 6th task
    {
        int num = (int)value;
        double number = value - num;

        if (number < 0.5)
        {
            return num;
        }
        else return num + 1;
    }

    public static int Floor(double value) // 7th task
    {
        return (int)value;
    }

    public static int Ceiling(double value) // 8th task
    {
        return (int)value + 1;
    }

    public static double Abs(double value) // 9th task
    {
        if (value < 0)
        {
            return value * -1;
        }
        else
        {
            return value;
        }
    }
}
