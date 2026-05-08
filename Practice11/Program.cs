using Practice11;
using System;
using System.Globalization;

// MyString Methods

// 1 Creation & Basic Properties

//MyString newString1 = new MyString("Hello World!");
//string s = "Hello World!";
//
//Console.WriteLine(newString1.Length); // use of 1st task
//Console.WriteLine(s.Length);

// 2

//string s = "";
//
//Console.WriteLine(String.IsNullOrEmpty(s));
//Console.WriteLine(MyString.IsNullOrEmpty(s));

// 3

//string s = "  ";
//
//Console.WriteLine(String.IsNullOrWhiteSpace(s));
//Console.WriteLine(MyString.IsNullOrWhiteSpace(s));

// 4

//char c = '#';
//int count = 5;
//
//MyString newString4 = new MyString(c, count);
//
//Console.WriteLine(newString4._value);

// 5 Comparison & Searching

//MyString newString5 = new MyString("Hello World!");
//string s1 = "Hello World!", s2 = "Hello World!";
//
//Console.WriteLine(newString5.Equals(s1));
//Console.WriteLine(s1.Equals(s2));

// 6 1st part

//string s1 = "house", s2 = "home";
//
//Console.WriteLine(MyString.Compare(s1, s2));
//Console.WriteLine(String.Compare(s1,s2));

// 6 2nd part

//MyString newString6 = new MyString("house");
//
//Console.WriteLine(s1.CompareTo(s2));
//Console.WriteLine(newString6.CompareTo(s2));

// 7

//MyString newString7 = new MyString("airplane");
//string s = "airplane";
//
//Console.WriteLine(s.StartsWith("air"));
//Console.WriteLine(newString7.StartsWith("air"));

// 8

//MyString newString8 = new MyString("airplane");
//string s = "airplane";
//
//Console.WriteLine(s.EndsWith('e'));
//Console.WriteLine(newString8.EndsWith('e'));

// 9

//MyString newString9 = new MyString("Hello");
//string s = "Hello";
//
//Console.WriteLine(s.Contains('l'));
//Console.WriteLine(newString9.Contains('l'));

// 10

//MyString newString10 = new MyString("Hello World!");
//string s1 = "Hello World!";
//
//Console.WriteLine(s1.IndexOf('l'));
//Console.WriteLine(newString10.IndexOf('l'));

// 11

//MyString newString11 = new MyString("Hello World!");
//string s1 = "Hello World!";
//
//Console.WriteLine(s1.LastIndexOf('l'));
//Console.WriteLine(newString11.LastIndexOf('l'));

// 12 Manipulation / Modification

//MyString newString12 = new MyString("Hello World!");
//string s = "Hello World!";
//
//Console.WriteLine(s.Substring(0, 5));
//Console.WriteLine(s.Substring(6));
//
//Console.WriteLine(newString12.SubString(0, 5));
//Console.WriteLine(newString12.SubString(6));

// 13

//MyString newString13 = new MyString("boo");
//
//string result;
//string s = "boo";
//char o = 'o', e = 'e';
//
//Console.WriteLine(s.Replace(o, e));
//Console.WriteLine(newString13.Replace(o, e));

// 14

//MyString newString14 = new MyString("Hello");
//
//string s = "Hello";
//string val = "World!";
//
//Console.WriteLine(s.Insert(s.Length, " " + val));
//Console.WriteLine(newString14.Insert(newString14.Length, " " + val));

// 15

//MyString newString15 = new MyString("Hello World!");
//string s = "Hello World!";
//
//Console.WriteLine(s.Remove(5));
//Console.WriteLine(s.Remove(5, 6));
//
//Console.WriteLine(newString15.Remove(5));
//Console.WriteLine(newString15.Remove(5, 6));

// 16

//MyString newString16 = new MyString("    Hello World!    ");
//string s = "    Hello World!    ";
//
//Console.WriteLine(s.Trim());
//Console.WriteLine(s.Trim().Length);
//
//Console.WriteLine(newString16.Trim());
//Console.WriteLine(newString16.Trim().Length);

// 17

//MyString newString17 = new MyString("    Hello World!    ");
//string s = "    Hello World!    ";
//
//Console.WriteLine(s.TrimStart());
//Console.WriteLine(s.TrimStart().Length);
//
//Console.WriteLine(newString17.TrimStart());
//Console.WriteLine(newString17.TrimStart().Length);

// 18

//MyString newString18 = new MyString("    Hello World!    ");
//string s = "    Hello World!    ";
//
//Console.WriteLine(s.TrimEnd());
//Console.WriteLine(s.TrimEnd().Length);
//
//Console.WriteLine(newString18.TrimEnd());
//Console.WriteLine(newString18.TrimEnd().Length);

// 19

//MyString newString19 = new MyString("Hello World!");
//string s = "Hello World!";
//
//Console.WriteLine(s.ToUpper());
//Console.WriteLine(s.ToLower());
//
//Console.WriteLine(newString19.ToUpper());
//Console.WriteLine(newString19.ToLower());

// 20 Splitting & Joining

//MyString newString20 = new MyString("Hello,World!;Hello World!");
//string s = "Hello,World!;Hello World!";
//char[] separators = { ',', ';', ' ' };
//
//string[] words1 = s.Split(separators);
//string[] words2 = newString20.Split(separators);
//
//foreach (string word in words1)
//{
//    Console.WriteLine(word);
//}
//
//Console.WriteLine('\n');
//
//foreach (string word in words2)
//{
//    Console.WriteLine(word);
//}

// 21

//char separator = '\\';
//string[] words = { "hello", "hey", "hi" };
//
//Console.WriteLine(String.Join(separator, words));
//Console.WriteLine(MyString.Join(separator, words));

// 22 Formatting & Conversion

//string tobeformatted = "dfgewyu {3} db 0 gyt {0} fdew {2} {3} hcdwujh {4}";
//
//string formattedValue = String.Format(tobeformatted, new string[] { "nuli", "erti", "ori", "sami", "otxi" });
//string myFormattedValue = MyString.Format(tobeformatted, new string[] { "nuli", "erti", "ori", "sami", "otxi" });
//
//Console.WriteLine(formattedValue);
//Console.WriteLine(myFormattedValue);

// 23 used some online sources

// $"{var}"

//MyString newString23 = new MyString("Hello World!");
//
//Console.WriteLine($"{newString23}");

// 24

//MyString newString23 = new MyString();
//int num = 10;
//
//Console.WriteLine(num.ToString());
//Console.WriteLine(num.ToString());

// 25

//string s = "Hello";
//int totalWidth = 10;
//
//Console.WriteLine(s.PadLeft(totalWidth));
//
//Console.Write(s.PadRight(totalWidth));
//Console.Write("end\n\n\n");
//
//
//MyString newString25 = new MyString("Hello");
//
//Console.WriteLine(newString25.PadLeft(totalWidth));
//
//Console.Write(newString25.PadRight(totalWidth));
//Console.Write("end");

// 26 Checking / Validation

//string s = "Hello";
//Console.WriteLine(s.All(char.IsLetter));
//
//MyString newString26 = new MyString("Hello");
//Console.WriteLine(newString26.AllCharIsLetter());

// 27

//string s = "595";
//Console.WriteLine(s.Any(char.IsDigit));
//
//MyString newString27 = new MyString("595");
//Console.WriteLine(newString27.AnyCharIsDigit());

// 28

//string s1 = "Hello";
//string s2 = "hello";
//bool ignoreCase = true;
//
//Console.WriteLine(string.Compare(s1, s2, ignoreCase));
//Console.WriteLine(MyString.Compare(s1, s2, ignoreCase));

// 29 Other Useful Methods

//string s = "Hello World!";
//
//char[] charArr = s.ToCharArray();
//
//foreach(char c in charArr)
//{
//    Console.Write(c + "  ");
//}
//
//MyString newString29 = new MyString("Hello World!");
//
//char[] myCharArr = newString29.ToCharArray();
//
//Console.Write('\n');
//foreach (char c in myCharArr)
//{
//    Console.Write(c + "  ");
//}

// 30

//string s = "Hello World!";
//Console.WriteLine(s.Contains('l'));
//
//MyString newString30 = new MyString(s);
//Console.WriteLine(s.Contains('l')); // es funqcia meordeba (ukve gviweria)

// 31

//string s = "Hello World!";
//char[] destination = new char[15];
//
//s.CopyTo(6, destination, 0, 6);
//foreach(char c in destination)
//{
//    Console.Write(c);
//}
//
//
//MyString newString31 = new MyString("Hello World!");
//char[] myDestination = new char[15];
//
//newString31.CopyTo(6, myDestination, 0, 6);
//Console.Write('\n');
//foreach (char c in myDestination)
//{
//    Console.Write(c);
//}

// 32

//string str = "Hello World!";
//
//object clonedObj = str.Clone();
//string clonedStr = (string)str.Clone();
//
//Console.WriteLine(clonedObj);
//Console.WriteLine(clonedStr);
//
//MyString newString32 = new MyString("Hello World!");
//
//object myClonedObj = newString32.Clone();
//string myClonedStr = (string)newString32.Clone();
//
//Console.WriteLine(myClonedObj);
//Console.WriteLine(myClonedStr);

// 33

// Intern()

//String c = new String("apple");
//String d = new String("apple");
//
//String z = String.Intern(c);
//String w = String.Intern(d);
//
//Console.WriteLine(Object.ReferenceEquals(z, w));
//
//
//MyString a = new MyString("apple");
//MyString b = new MyString("apple");
//
//MyString x = MyString.Intern(a);
//MyString y = MyString.Intern(b);
//
//Console.WriteLine(Object.ReferenceEquals(x, y));

// MyInt Methods

// 1 && 2 Properties

//MyInts myInt1 = new MyInts(20);
//MyInts myInt2 = new MyInts(20, 15);
//
//Console.WriteLine("Min: " + myInt1.MinValue);
//Console.WriteLine("Max: " + myInt1.MaxValue);
//
//Console.WriteLine("Min: " + myInt2.MinValue);
//Console.WriteLine("Max: " + myInt2.MaxValue);

// 3 Convert to string

//int num = 30;
//Console.WriteLine(num.ToString());
//
//MyInts myInt3 = new MyInts(30);
//Console.WriteLine(myInt3.ToString());

// 4 Methods

//int num1 = 10, num2 = 20;
//Console.WriteLine(num1.Equals(num2));
//
//MyInts newInt4 = new MyInts(10);
//Console.WriteLine(newInt4.Equals(20));

// 5

//int num1 = 10, num2 = 20;
//Console.WriteLine(num1.CompareTo(num2));
//
//MyInts newInt5 = new MyInts(10);
//Console.WriteLine(newInt5.CompareTo(20));

// 6 Parsing

//string number = "123";
//Console.WriteLine(int.Parse(number));
//
//Console.WriteLine(MyInts.Parse("123"));

// 7

//string number = "123";
//int parsedNumber;
//
//Console.WriteLine(int.TryParse(number, out parsedNumber));
//Console.WriteLine(parsedNumber);
//
//double myParsedNumber;
//Console.WriteLine(MyInts.TryParse("123", out myParsedNumber));
//Console.WriteLine(myParsedNumber);

// MyMath Methods

// 1

//int num1 = 10, num2 = 15;
//
//Console.WriteLine(Math.Min(num1, num2));
//Console.WriteLine(MyMath.Min(num1, num2));

// 2

//int num1 = 10, num2 = 15;
//
//Console.WriteLine(Math.Max(num1, num2));
//Console.WriteLine(MyMath.Max(num1, num2));

// 3

//int value = 10, min = 1, max = 15;
//
//Console.WriteLine(Math.Clamp(value, min, max));
//Console.WriteLine(MyMath.Clamp(value, min, max));

// 4

//int value = 25;
//
//Console.WriteLine(Math.Sqrt(value));
//Console.WriteLine(MyMath.sqrt(value));

// 5

//int value = 5;
//int power = 2;
//
//Console.WriteLine(Math.Pow(value, power));
//Console.WriteLine(Math.Pow(value, power));

// 6

//double value = 5.4;
//
//Console.WriteLine(Math.Round(value));
//Console.WriteLine(Math.Round(value));

// 7

//double value = 5.9;
//
//Console.WriteLine(Math.Floor(value));
//Console.WriteLine(MyMath.Floor(value));

// 8

//double value = 5.4;
//
//Console.WriteLine(Math.Ceiling(value));
//Console.WriteLine(MyMath.Ceiling(value));

// 9

//double value = -5.5;
//
//Console.WriteLine(Math.Abs(value));
//Console.WriteLine(MyMath.Abs(value));