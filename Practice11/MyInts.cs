using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11;

internal class MyInts
{
    public int _value;
    public int _num1, _num2;
    public int MinValue, MaxValue; // useful for 1st && 2nd task

    public MyInts() { }

    public MyInts(int value) // 1st && 2nd task
    {
        _value = value;

        MinValue = value;
        MaxValue = value;
    }
    public MyInts(int num1, int num2) // 1st && 2nd task
    {
        _num1 = num1;
        _num2 = num2;

        MinValue = minValue();
        MaxValue = maxValue();
    }

    public string ToString() // 3rd task
    {
        if (_value == 0)
        {
            return "0";
        }

        string result = "";

        int digit = _value;
        int tempValue = _value;
        while (tempValue > 0)
        {
            digit = tempValue % 10;
            result = (char)(digit + '0') + result;
            tempValue /= 10;
        }

        return result;
    }

    public bool Equals(int number) // 4th task
    {
        if (_value == number)
        {
            return true;
        }
        return false;
    }

    public int CompareTo(int number) // 5th task
    {
        if (_value == number)
        {
            return 0;
        }
        else if (_value > number)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

    public static double Parse(string str) // 6th task
    {
        double result = 0;

        for (int i = 0; i < str.Length; i++)
        {
            double digit = str[i] - 48;

            digit = digit * (Math.Pow(10, str.Length - i - 1));

            result += digit;
        }

        return result;
    }

    public static bool TryParse(string str, out double result) // 7th task
    {
        result = 0;

        if (string.IsNullOrEmpty(str))
            return false;

        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];

            if (c < '0' || c > '9')
            {
                result = 0;
                return false;
            }

            double digit = c - '0';
            digit *= Math.Pow(10, str.Length - i - 1);

            result += digit;
        }

        return true;
    }

    private int minValue() // useful for 1st task
    {
        return _num1 < _num2 ? _num1 : _num2;
    }
    private int maxValue() // useful for 2nd task
    {
        return _num1 > _num2 ? _num1 : _num2;
    }
}
