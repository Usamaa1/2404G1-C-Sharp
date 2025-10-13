// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//var c = 'a';
//var b = false;





//'a'
//"klfdsgklfdk"

//int number;

//number = "h";
//number = 'h';
//Console.WriteLine(number);

// Datatypes 

//string str = 'j';
//string str = "fdjksjfkjsdkjfsdkj";
//bool b = false;
//char c = 'a';
//float f = 2.3f;
//decimal d = 2.3m;
//double db = 2.4;
//long l = 2343242342343;
//var v = 435;

//string? z = "jfkdsjf";
//Type type;


//Console.WriteLine(f);
//Console.WriteLine(db);







//functions

//int fun()
//{
//    return 23;
//}

//string fun2()
//{
//    return "jfksdjfkjsd";
//}

//bool fun3()
//{
//    return true;
//}


//int add(int x, int y) 
//{ 

//    return x + y;

//}

//Console.WriteLine(add(3, 4));
//int x=5; int y=76;
//void add()
//{

//   Console.WriteLine(x + y);

//}

//add();





//var name = "Arif";
//var age = 23;


//Console.WriteLine("My name is: " + name + " and my age is: " + age);

//Console.WriteLine("My name is: {0} and my age is: {1}", name, age);
//Console.WriteLine($"My name is: {name} and my age is: {age}");
//Console.WriteLine($"My name is: {name}\n\r and my age is:\n {age}");


//int num1 = 23;
//int num2 = 5;

//Console.WriteLine(num1 + num2);
//Console.WriteLine(num1 - num2);
//Console.WriteLine(num1 * num2);
//Console.WriteLine(Convert.ToDecimal(num1) / Convert.ToDecimal(num2));
//Console.WriteLine(Convert.ToDecimal(num1) % Convert.ToDecimal(num2));



//Console.WriteLine("Enter your Name ");
//var userInput = Console.ReadLine();

//Console.WriteLine($"My name Is: {userInput}");


//Console.WriteLine("Enter your age: ");

//string userAge = Console.ReadLine();

//if(Convert.ToInt64(userAge) >= 18)
//    Console.WriteLine("You are eligible");
//else
//    Console.WriteLine("You are not eligible");



//Modulus with if else statement

//int num = Convert.ToInt32(Console.ReadLine());


//if (num % 2 == 1)
//    Console.WriteLine("Odd Number");
//else
//    Console.WriteLine("Even Number");

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"Item: {i}");
//}




//Console.WriteLine("Enter years of service: ");
//int yearsOfServices = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter your salary: ");
//int salary = Convert.ToInt32(Console.ReadLine());
//int bonus = 0;


//if(yearsOfServices >= 2)
//{

//    if(salary <= 50000)
//    {
//        bonus = 5000;
//    }
//    else if(salary > 50000 && salary <= 100000)
//    {
//        bonus = 4000;
//    }
//    else
//    {
//        bonus = 3000;
//    }
//    Console.WriteLine($"You are eligible for bonus: {bonus}");



//}
//else
//{
//    Console.WriteLine("You are not eligible for bonus");
//}





//int[] numbers = { 23, 45, 67, 89, 12 };

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}


//int[] numbers = new int[2] {12, 12};

//numbers[0] = 23;
//numbers[1] = 45;
//numbers[2] = 67;
//numbers[3] = 89;
//numbers[4] = 12;
//numbers[5] = 100; // This will cause an IndexOutOfRangeException

//numbers = [23, 45];

//numbers = [23, 45, 67, 89, 12];



//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}



//string[] names = new string[3];
//names = ["Arif", "Khan", "Developer", "Age: 23","hello"];




//foreach(var item in names)
//{
//    Console.WriteLine(item);
//}



//Multidimensional array 
//int[,] numbers = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}

//Jagged Array
//int[][] numbers = new int[3][];
//numbers[0] = new int[2] { 1, 2 };
//numbers[1] = new int[3] { 3, 4, 5 };
//numbers[2] = new int[4] { 6, 7, 8, 9 };
//foreach (var arr in numbers)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}




//int[] arr = [1, 3, 4, 6, 7, 78];


// foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

// Console.WriteLine(String.Join(", ",arr));


//int[] numbers = new int[2] { 23, 45 };

//numbers = [ ..numbers, 28, 46, 67, 43 ];

//numbers[0] = 100;
//numbers[1] = 2300;
//numbers[2] = 3400;
//numbers[3] = 4500;
//numbers[4] = 5600;
//numbers[5] = 6700;
//numbers[6] = 3500;
//numbers[7] = 3500;
//numbers[8] = 3500;
//numbers[9] = 3500;
//numbers[10] = 3500;



//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//int[] nums = [1, 2, 3, 4, 5];
//int[] nums = [3, 4, 5,1, 2, 3];

//Console.WriteLine(nums.Length); ---> for length of array
//Console.WriteLine(nums.Contains(4)); ---> to check if array contains a value
//Console.WriteLine(Array.IndexOf(nums,4)); ---> to get index of a value
//Array.Clear(nums); ---> to clear all values in array
//Console.WriteLine(String.Join(", ", nums)); ---> to print array values
//Array.Sort(nums); ---> to sort array in ascending order
//Console.WriteLine(String.Join(" - ",nums)); ---> to print array values with custom separator
//Console.WriteLine(String.Join(" , ", nums.Reverse())); ---> to print array values in reverse order
//Console.WriteLine(String.Join(" , ", nums.Distinct())); ---> to print distinct values in array


// List
//List<int> numbers = new List<int>() { 23, 45, 67, 89, 12 };

//numbers.Add(100); --> to add elements in List
//numbers.Clear(); --> to Clear all elements from list
//numbers.RemoveAll(a => a > 50); --> to Remove elements from list according to specific condition
//numbers.Remove(12); --> to Remove specific element from list
//Console.WriteLine(numbers.Contains(67)); --> to check if element is present in a list or not
//numbers.RemoveAt(4); --> to remove element from list according to indexes


//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}


//List<String> names = ["Arif", "Zahid", "Haris","Hina"];

//foreach (String name in names)
//{
//Console.WriteLine(names);
//}




//*********************************************
//*********************************************
//************ CLASSES AND OOP'S **************
//*********************************************
//*********************************************






//Person person1 =  new(); --> Object Initialization
//person1.name = "zahid"; --> Property Initialization
//person1.age = 24;
//person1.height = 60;
//person1.weight = 70;
//person1.gender = "Male";


//Person person1 = new() --> Object Initialization with Property Initialization
//{
//    name = "Arif",
//    age = 10,
//    gender = "Male",
//    height = 10,
//    weight = 1,

//};

//Console.WriteLine($"Person name: {person1.name}, Person Age: {person1.age}, Person Height: {person1.height}, Person Weight: {person1.weight}");



// Creating Class named Person
class Person 
{
   public string name;
   public int age;
   public string gender;
   public double height;
   public double weight;
}











