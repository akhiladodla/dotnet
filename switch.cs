// See https://aka.ms/new-console-template for more information


/**** Variables ****/
//int age = 25;
//double salary = 55000.75;
//bool isActive = true;
//string name = "John";

//Console.WriteLine(age);
//Console.WriteLine(salary);
//Console.WriteLine(isActive);
//Console.WriteLine(name);

/**** Variables - var ****/
//var city = "London";   // compiler infers string
//var points = 120;      // compiler infers int

//Console.WriteLine(city);
//Console.WriteLine(points);

/**** Value Types - int, char, double, bool etc ****/
//int a = 10;
//int b = a;
//b = 20;
//Console.WriteLine(a);

/**** Reference Types - string, arrays, List<T>, Class ****/
//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = arr1;  // arr2 points to SAME ARRAY

//arr2[0] = 999;

//Console.WriteLine(arr1[0]); 
//Console.WriteLine(arr2[0]); 


/**** Operators ****/
/**** Arithmatic ****/
//int x = 10, y = 3;

//Console.WriteLine(x + y);  // 13
//Console.WriteLine(x - y);  // 7
//Console.WriteLine(x * y);  // 30
//Console.WriteLine(x / y);  // 3  (integer division)
//Console.WriteLine(x / 3.0); // 3.33 (floating point)
//Console.WriteLine(x % y); // remainder = 1

/**** Comparison ****/
//Console.WriteLine(x > y);   // true
//Console.WriteLine(x == y);  // false
//Console.WriteLine(x != y);  // true

/**** Logical ****/
//bool a = true, b = false;
//Console.WriteLine(a && b); // false
//Console.WriteLine(a || b); // true
//Console.WriteLine(!a);     // false


/**** Conditional logic ****/

int score = 82;

switch (score / 10)
{
    case 10:    // 100
    case 9:     // 90–99
        Console.WriteLine("Grade A");
        break;

    case 8:     // 80–89
    case 7:     // 70–79
        Console.WriteLine("Grade B");
        break;

    case 6:     // 60–69
    case 5:     // 50–59
        Console.WriteLine("Grade C");
        break;

    default:
        Console.WriteLine("Fail");
        break;
}

/**** Switch ****/

//using System.Diagnostics;

//int points = 13;

//string output = points switch
//{
//    >= 15 => "Greater than or equal to 15",
//    >= 10 => "Greater than or equal to 10",
//    >= 5 => "Greater than or equal to 5",
//    _ => "None of these"
//};
//Console.WriteLine(output);


/**** Loop Examples ****/

/**** For Loop ****/

//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine(i);
//}


/**** While Loop ****/

//int n = 3;
//while (n > 0)
//{
//    Console.WriteLine(n);
//    n--;
//}


/**** Foreach Loop ****/

//int[] nums = { 1, 2, 3, 4 };
//foreach (var num in nums)
//{
//    Console.WriteLine(num);
//}

/****Simple Method Example:****/
//int Add(int a, int b)
//{
//    return a + b;
//}

//Console.WriteLine(Add(3, 4)); 

/****Method with array****/
// double Average(int[] nums)
// {
//     int sum = 0;
//     foreach (var n in nums) sum += n;

//     return (double)sum / nums.Length;
// }

// Console.WriteLine(Average(new[] { 10, 20, 30 }));

