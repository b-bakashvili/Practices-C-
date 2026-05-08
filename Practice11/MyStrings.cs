using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice11;

internal class MyStrings
{
    public string _value;
    public int _num;
    public int Length;

    // useful for 33rd task
    public static MyStrings[] pool = new MyStrings[100];
    public static int count = 0;

    public MyStrings() { } // default cunstructor // useful (sometimes)

    public MyStrings(string value) // constructor with 1 parameter // useful
    {
        _value = value;
        Length = GetLength(); // 1st task
    }
    public MyStrings(int num) // constructor with 1 parameter // useful
    {
        _num = num;
    }

    public MyStrings(char c, int count) // constructor with 2 parameters // 4th task
    {
        _value = "";
        for (int i = 0; i < count; i++) _value += c;
        Length = GetLength(); // 1st task
    }

    public static bool IsNullOrEmpty(string value) // 2nd task
    {
        return value == null || value == "";
    }

    public static bool IsNullOrWhiteSpace(string value) // 3rd task
    {
        int count = 0;
        int countWhiteSpaces = 0;

        if (value != null)
        {
            foreach (char c in value)
            {
                if (c == ' ')
                {
                    countWhiteSpaces++;
                }
                count++;
            }
        }

        bool condition = count - countWhiteSpaces == 0;
        return value == null || value == "" || condition;
    }

    public bool Equals(string value) // 5th task
    {
        if (value == null)
        {
            return false;
        }
        return _value == value;
    }

    public static int Compare(string value1, string value2) // 6th task 1st part
    {
        int result = 0;
        int length = 0;

        // logic to find smaller string
        if (value1.Length >= value2.Length) length = value2.Length;
        else length = value1.Length;

        // finds first different character (if there is) and compares
        for (int i = 0; i < length; i++)
        {
            if (value1[i] < value2[i])
            {
                result = -1;
                break;
            }
            else if (value1[i] > value2[i])
            {
                result = 1;
                break;
            }
        }

        // if both strings were identical to length (smaller string.Length) range:
        if (result == 0 && value1.Length > value2.Length) result = 1;
        else if (result == 0 && value1.Length < value2.Length) result = -1;

        return result;
    }

    public int CompareTo(string value) // 6th task 2nd part
    {
        int result = 0;
        int length = 0;

        if (_value.Length >= value.Length) length = value.Length;
        else length = _value.Length;

        for (int i = 0; i < length; i++)
        {
            if (_value[i] < value[i])
            {
                result = -1;
                break;
            }
            else if (_value[i] > value[i])
            {
                result = 1;
                break;
            }
        }

        if (result == 0 && _value.Length > value.Length) result = 1;
        else if (result == 0 && _value.Length < value.Length) result = -1;

        return result;
    }

    public bool StartsWith(string value) // 7th task
    {
        bool result = true;

        for (int i = 0; i < value.Length; i++)
        {
            if (_value[i] != value[i])
            {
                result = false;
                break;
            }
        }
        return result;
    }

    public bool EndsWith(char c) // 8th task
    {
        if (_value[_value.Length - 1] == c)
        {
            return true;
        }
        return false;
    }

    public bool Contains(char c) // 9th task
    {
        foreach (char ch in _value)
        {
            if (c == ch)
            {
                return true;
            }
        }
        return false;
    }

    public int IndexOf(char c) // 10th task
    {
        for (int i = 0; i < _value.Length; i++)
        {
            if (_value[i] == c)
            {
                return i;
            }
        }
        return -1;
    }

    public int LastIndexOf(char c) // 11th task
    {
        for (int i = _value.Length - 1; i >= 0; i--)
        {
            if (_value[i] == c)
            {
                return i;
            }
        }
        return -1;
    }

    public string Substring(int startIndex) // 12th task (1st part)
    {
        string result = "";
        for (int i = startIndex; i < _value.Length; i++)
        {
            result += _value[i];
        }

        return result;
    }

    public string Substring(int startIndex, int length) // 12th task overloaded function (2nd part)
    {
        string result = "";
        int cycleLength = startIndex + length;

        for (int i = startIndex; i < cycleLength; i++)
        {
            result += _value[i];
        }

        return result;
    }

    public string Replace(char oldChar, char newChar) // 13th task
    {
        string result = "";
        for (int i = 0; i < _value.Length; i++)
        {
            if (_value[i] == oldChar)
            {
                result += newChar;
            }
            else
            {
                result += _value[i];
            }
        }

        return result;
    }

    public string Insert(int startIndex, string value) // 14th task
    {
        string result = "";

        for (int i = 0; i < startIndex; i++)
        {
            result += _value[i];
        }

        result += value;

        for (int i = startIndex; i < _value.Length; i++)
        {
            result += _value[i];
        }

        return result;
    }

    public string Remove(int startIndex) // 15th task (1st part)
    {
        string result = "";

        for (int i = 0; i < startIndex; i++)
        {
            result += _value[i];
        }

        return result;
    }

    public string Remove(int startIndex, int count) // 15th task overloaded function (2nd part)
    {
        string result = "";

        for (int i = 0; i < startIndex; i++)
        {
            result += _value[i];
        }

        for (int i = startIndex + count; i < _value.Length; i++)
        {
            result += _value[i];
        }

        return result;
    }

    public string Trim() // 16th task
    {
        int start = 0, end = _value.Length - 1;

        for (int i = 0; i < _value.Length; i++)
        {
            if (_value[i] != ' ')
            {
                start = i;
                break;
            }
        }

        for (int i = _value.Length - 1; i >= 0; i--)
        {
            if (_value[i] != ' ')
            {
                end = i;
                break;
            }
        }

        string result = "";

        for (int i = start; i <= end; i++)
        {
            result += _value[i];
        }

        return result;
    }

    public string TrimStart() // 17th task
    {
        int start = 0;
        string result = "";

        for (int i = 0; i < _value.Length; i++)
        {
            if (_value[i] != ' ')
            {
                start = i;
                break;
            }
        }

        for (int i = start; i < _value.Length; i++)
        {
            result += _value[i];
        }

        return result;
    }

    public string TrimEnd() // 18th task
    {
        int end = _value.Length - 1;
        string result = "";

        for (int i = _value.Length - 1; i >= 0; i--)
        {
            if (_value[i] != ' ')
            {
                end = i;
                break;
            }
        }

        for (int i = 0; i <= end; i++)
        {
            result += _value[i];
        }

        return result;
    }

    public string ToUpper() // 19th task (1st part)
    {
        string result = "";

        for (int i = 0; i < _value.Length; i++)
        {
            if (_value[i] >= 'a' && _value[i] <= 'z')
            {
                result += Convert.ToChar(_value[i] - 32);
            }
            else
            {
                result += _value[i];
            }
        }

        return result;
    }

    public string ToLower() // 19th task (2nd part)
    {
        string result = "";

        for (int i = 0; i < _value.Length; i++)
        {
            if (_value[i] >= 'A' && _value[i] <= 'Z')
            {
                result += Convert.ToChar(_value[i] + 32);
            }
            else
            {
                result += _value[i];
            }
        }

        return result;
    }

    public string[] Split(char[] separators) // 20th task
    {
        int length = 1;

        for (int i = 0; i < _value.Length; i++)
        {
            foreach (char separator in separators)
            {
                if (_value[i] == separator)
                {
                    length++;
                    break;
                }
            }
        }

        string[] result = new string[length];

        int index = 0;
        string value = "";

        for (int i = 0; i < _value.Length; i++)
        {
            bool isSeparator = false;

            foreach (char separator in separators)
            {
                if (_value[i] == separator)
                {
                    isSeparator = true;
                    break;
                }
            }

            if (!isSeparator)
            {
                value += _value[i];
            }
            else
            {
                result[index] = value;
                value = "";
                index++;
            }
        }

        result[index] = value;

        return result;
    }

    public static string Join(char separator, string[] words) // 21st task
    {
        string result = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (i != words.Length - 1)
            {
                result += words[i] + separator;
            }
            else result += words[i];
        }

        return result;
    }

    public static string Format(string format, string[] arguments) // 22nd task
    {
        string result = format;

        for (int i = 1; i < format.Length; i++)
        {
            if (format[i - 1] == '{' && format[i + 1] == '}')
            {
                int index = Convert.ToInt32(format[i].ToString());
                string formatString = System.String.Concat(format[i - 1], format[i], format[i + 1]);
                result = result.Replace(formatString, arguments[index]);
            }
        }

        return result;
    }

    public override string ToString() // 23rd task (i couldnt do it any other way, used some sources)
    {
        return _value;
    }

    public string toString() // 24th task (couldnt give name - ToString cuz it already exists)
    {
        int num = _num;
        string result = "";

        if (num == 0)
        {
            return "0";
        }

        bool isNegative = false;
        if (num < 0)
        {
            isNegative = true;
            num = -num;
        }

        while (num > 0)
        {
            int digit = num % 10;
            result = (char)(digit + 48) + result;
            num /= 10;
        }

        if (isNegative)
        {
            result = "-" + result;
        }

        return result;
    }

    public string PadLeft(int totalWidth) // 25th task (1st part)
    {
        if (totalWidth < _value.Length)
        {
            return _value;
        }

        string result = "";

        for (int i = 0; i < totalWidth - _value.Length; i++)
        {
            result += " ";
        }

        result += _value;

        return result;
    }

    public string PadRight(int totalWidth) // 25th task (2nd part)
    {
        if (totalWidth < _value.Length)
        {
            return _value;
        }

        string result = _value;

        for (int i = _value.Length; i < totalWidth; i++)
        {
            result += " ";
        }

        return result;
    }

    public bool AllCharIsLetter() // 26th task
    {
        foreach (char c in _value)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }

    public bool AnyCharIsDigit() // 27th task
    {
        foreach (char c in _value)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }

    public static int Compare(string value1, string value2, bool ignoreCase) // 28th task
    {
        int result = 0;
        int length = 0;

        // logic to find smaller string
        if (value1.Length >= value2.Length) length = value2.Length;
        else length = value1.Length;

        // finds first different character (if there is) and compares
        if (ignoreCase)
        {
            for (int i = 0; i < length; i++)
            {
                if (value1.ToLower()[i] < value2.ToLower()[i])
                {
                    result = -1;
                    break;
                }
                else if (value1.ToLower()[i] > value2.ToLower()[i])
                {
                    result = 1;
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                if (value1[i] < value2[i])
                {
                    result = -1;
                    break;
                }
                else if (value1[i] > value2[i])
                {
                    result = 1;
                    break;
                }
            }
        }

        // if both strings were identical to length (smaller string.Length) range:
        if (result == 0 && value1.Length > value2.Length) result = 1;
        else if (result == 0 && value1.Length < value2.Length) result = -1;

        return result;
    }

    public char[] ToCharArray() // 29th task
    {
        char[] charArr = new char[_value.Length];

        for (int i = 0; i < _value.Length; i++)
        {
            charArr[i] += _value[i];
        }

        return charArr;
    }

    public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) // 31st task
    {
        for (int i = sourceIndex; i < sourceIndex + count; i++)
        {
            destination[i] = _value[i];
        }
    }

    public object Clone() // 32nd task (same as interpolation (used some sources))
    {
        return _value;
    }

    public static MyStrings Intern(MyStrings s) // 33rd task (same as interpolation & Clone (used some sources))
    {
        // check if same value already exists
        for (int i = 0; i < count; i++)
        {
            if (pool[i]._value == s._value)
            {
                return pool[i];
            }
        }

        // add new object
        pool[count] = s;
        count += 1;

        return s;
    }

    private int GetLength() // useful for 1st task
    {
        int length = 0;
        foreach (char c in _value) length++;
        return length;
    }
}
