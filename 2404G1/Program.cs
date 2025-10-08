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


