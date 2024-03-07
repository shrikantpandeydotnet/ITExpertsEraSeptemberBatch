// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); // to write in the console screen. 

//Console.WriteLine("Welcome to ITExpertsERa");
//Console.WriteLine("This is a new batch");

//Console.Write("This will write in same line. ");
//Console.WriteLine("I am console write statement");

// Datatype.. 

//int number1 = 10;

//int number2 = 20; 

//int result = number1 + number2;


//Console.WriteLine("The result of two number is " + result); // + is used to concatenate two string.


//string text = "This is a good boy";
//Console.WriteLine("Please enter your first number");

//int num1 = Convert.ToInt32( Console.ReadLine()); // convert user entry into integer and save into num1 variable.


//Console.WriteLine("Please enter your second number");

//int num2 = Convert.ToInt32( Console.ReadLine());


//Console.WriteLine("Please enter operation that you want to perform");

//string operation = Console.ReadLine();

//// Condition.. if else

//int result = 0; 

//if (operation == "Sum")
//{
//    result = num1 + num2;
//}
//else if (operation == "Subtract")
//{
//    result = num1 - num2;
//}
//else if (operation == "Multiply" )
//{
//    result  = num1 * num2;
//}
//else if (operation == "Divide")
//{
//    result = num1 / num2;
//}
//else 
//{
//    Console.WriteLine("You have entered wrong opration");
//}

// three brother find out eldest one.. 

//Console.WriteLine("Enter first child age");
//int Ramesh = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("Enter second child age");
//int Suresh = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter third child age");
//int Shyam = Convert.ToInt32(Console.ReadLine());


//if (Ramesh > Suresh && Ramesh > Shyam)
//{
//    Console.WriteLine("Ramesh is eldest child");
//}
//else if (Suresh > Shyam && Suresh > Ramesh)
//{
//    Console.WriteLine("Suresh is the eldest child");
//}
//else
//{
//    Console.WriteLine("Shyam is the eldest child");
//}




//if (num1 > 100 || num1 % 2 != 0 )
//{
//    Console.WriteLine(num1);
//}


//Console.WriteLine("The result of two numbers are " + result);



///////////////////////////////////////// 26th September 2023 ///////////////////////////////////////


// Array syntax or declaration
//int[] arrayInt = new int[1000]; // datatype default value, integer default value is 0.

//// Array Initialization..

//arrayInt[0] = 10;
//arrayInt[1] = 20;
//arrayInt[2] = 100;

//// Second way of initializing and declaring array together. 

//string[] arrayString = new string[] {"Raja", "Pooja", "Shyam"};


//for (int i = 0; i < arrayString.Length; i++)
//{
//    Console.WriteLine(arrayString[i]);
//}


//// Array update in between index

//arrayInt[1] = 200;

////

//// Print array with for loop...

//for (int i = 0; i < arrayInt.Length; i++)
//{
//    Console.WriteLine(arrayInt[i]); //
//}


//For LOOP 


// Question 1" print first 10 natural numbers..  1, 2, 3, 4, 

using ITExpertsEraSeptemberBatch;
using System.Globalization;
using System.Runtime;
/// ya to odd number ya 100 se bada ho.. print karna he number otherwise nai karna
/// 
//for (int i = 1; i <= 10; i++ )
//{
//    Console.WriteLine( i );
//}

// Q2: Print even number till 20;

//for (int i = 3; i <=30; i = i+3 )
//{
//    Console.WriteLine(i);
//}

//for (int i = 10; i > 0; i--)
//{
//    Console.WriteLine(i);
//}

// continue.... 

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5 || i == 6)
//    {
//        continue; // dont execute any line after that and move to the next loop.
//    }

//    Console.WriteLine(i);
//}


// break;


//for (int i = 0; i < 10; i++) // one loop cycle = 1 iteration
//{

//    if (i == 5 )
//    {
//        break; // break will break the loop and no other condition will execute.
//    }

//    Console.WriteLine(i);
//}


///////////////////////////////  Try loop with multiple variables. //////////////////////////////////////
///


//for (int i = 1, j = 1, k =1, l=1; i < 10 && j < 10 && k <10 && k < 10;  i++, j++, k++, l++ )
//{
//    Console.WriteLine(i + j + k + l);
//}


//Console.WriteLine("Please enter your first number");
//int i = Convert.ToInt32( Console.ReadLine());
//Console.WriteLine("Please enter your second number");
//bool j = Convert.ToBoolean(Console.ReadLine());

//int[] arrayInt = new int[] { 3, 6, 9 };

//int[] resultInt = new int[3];

//for (int i = 0; i < arrayInt.Length; i++)
//{
//    resultInt[i] = arrayInt[i] * arrayInt[i] * arrayInt[i];
//}

//for (int i = 0;i < resultInt.Length; i++)
//{
//    Console.WriteLine(resultInt[i]);
//}
//int result = i + j;

//Console.WriteLine("test");


// 1 - 1-10 number -> loop, variable to save that sum

//int result = 0;


//// syntax
//for (int i = 1; i <= 10; i++)
//{
//    result = result + i; // 1, 3, 6, 
//}

//Console.WriteLine(result);

// Nested for loop... 


//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Outer loop value of i " + i);

//    for (int j = 0; j <5; j++)
//    {
//        Console.WriteLine("Value of i " + i + "value of j " + j);
//    }
//}

// Interview question | Create diamond pattern, star patter using for loop.. 

string[] testArray = new string[] { "abc", "xyz", "test" };


//for (int i = 0;i < testArray.Length;i++)
//{
//    Console.WriteLine(testArray[i]);
//}

// for each loop.. 

//foreach (string value in testArray)
//{
//    Console.WriteLine(value);
//}

// while loop syntax

//int i = 1;

//while(i <=10)
//{
//    Console.WriteLine(i);
//    i++;
//}

// do while loop..  syntax
//int j = 1;
//do
//{
//    Console.WriteLine(j);
//    j++;
//}
//while (j <= 10);

//Console.WriteLine("test");


//////////////////////////////////////////////// 4 october 2023//////////////////////
///

// Syntax of object creation

//Car objCar = new Car();

//objCar.Name = "i20";
//objCar.Brand = "Hyundai";
//objCar.Color = "Red";
//objCar.NoofSeats = 4;

//// Print all the properties

//Console.WriteLine("Name of the Car is " + objCar.Name);
//Console.WriteLine("Brand of the Car is " + objCar.Brand);
//Console.WriteLine("Color of the Car is " + objCar.Color);
//Console.WriteLine("No of Seats of the Car is " + objCar.NoofSeats);

//objCar.Accelerator(10);

//objCar.Brake(5);

//objCar.Clutch(10);

//Console.WriteLine("==============================================================================================");

//Car objCar2 = new Car();
//objCar2.Name = "Verna";
//objCar2.Brand = "Hyundai";
//objCar2.Color = "BLack";
//objCar2.NoofSeats = 4;

//// Print all the properties

//Console.WriteLine("Name of the Car is " + objCar2.Name);
//Console.WriteLine("Brand of the Car is " + objCar2.Brand);
//Console.WriteLine("Color of the Car is " + objCar2.Color);
//Console.WriteLine("No of Seats of the Car is " + objCar2.NoofSeats);

//objCar2.Accelerator(20);

//objCar2.Brake(1);

//objCar2.Clutch(1000);


////////////////////////////////////////////////////////// 05 October 2023 /////////////////////////////////////////

MathsOperation objMO = new MathsOperation();

//objMO.TestMethod();
//objMO.Sum(20, 30);
//int result = objMO.Subtract(200, 30);

//Console.WriteLine("Subtraction of two numbers is " + result);

//int[] array1 = new int[] {1,2,3,4,5};

//int arrayResult = objMO.SumOfArray(array1);

//Console.WriteLine("The sum of array is " +  arrayResult);

//int[] resultArray = objMO.Sonu(10, 20, 30);

//foreach (int i in resultArray)
//{
//    Console.WriteLine(i);
//}

////////////////////////////////////////// 12th October 2023 ///////////////////////////////
///


//PolymorphismExample objPE = new PolymorphismExample();

//objPE.a = 120;
//PolymorphismExample.b = 100;
//objPE.Sum();
//objPE.Sum(20, 30);
//objPE.Sum(50, "Test", 100);

//PolymorphismExample  objPE2 = new PolymorphismExample();

//Console.WriteLine(objPE2.a);

//objPE2 = objPE;

//objPE = null;

//Console.WriteLine(objPE2.a); // 120 , Ab : 120, Sh : 0, Vaibhav : 0
//Console.WriteLine(objPE.a); // 120 , Ab : 120, Sh : 0, Vaibhav : 0


/////////////////////////////////////////////////// 18th October 2023 ////////////////////////////////



//ConstructorExample.var_static_int = 2000;
//ConstructorExample.var_static_int = 3000;


//ConstructorExample objCE = new ConstructorExample();

//Console.WriteLine(objCE.var_int);
//Console.WriteLine(objCE.var_string);



//ConstructorExample objCE2 = new ConstructorExample(100, "TEst");


//Console.WriteLine(objCE2.var_int);
//Console.WriteLine(objCE2.var_string);


//ConstructorExample objCE3 = new ConstructorExample(objCE2);




//Console.WriteLine(objCE3.var_int);
//Console.WriteLine(objCE3.var_string);


////////////////////////// 24 october 2023 ///////////////////

//Parent objParent = new Parent();

//objParent.ParentMethod();

//Child objChild = new Child();

//objChild.ChildMethod();

//objChild.ParentMethod();

//GrandChild objGrandChild = new GrandChild();

//objGrandChild.GrandChildMethod();
//objGrandChild.ChildMethod();
//objGrandChild.ParentMethod();


//Child2 objChild2 = new Child2();
//objChild2.ParentMethod();
//objChild2.Child2Method();

//B objB = new B();


/////////////////////////////////////////////////////// 26th October 2023 //////////////////////////////////////


//A1 objA1 = new A1();

//objA1.TestMethod();

//B1 objB1 = new B1();

//objB1.TestMethod();
//objB1.TestMethod2();


//A1 objA2 = new B1();

//objA2.TestMethod2();
//objA2.TestMethod();



/////////////////////////////////// 31 October 2023 /////////////////////////////

//AccessModifierExample objAME = new AccessModifierExample();

//objAME.pubicVariable = 1;

//objAME.internalVariable = 2;
//objAME.protectedinternal = 100;

///////////////////////////////////////////////// 02 Nov 2023/////////////////////

//TestClass objTest = new TestClass();

//objTest.Add(20, 40);

//objTest.ParentTestMethod();


//IMaths objMaths = new TestClass();

//objMaths.TestMethod();
//objMaths.Add(20,30);
//objMaths.IMathTestMethod();

//ITEstInterface objTest2 = new TestClass
//

//Child20 obj20 = new Child20();

//obj20.TestMethod();
//obj20.TestMethod2();

CollectionsExample objCol = new CollectionsExample();

//objCol.ArrayListOperation();
//objCol.HashTableOperation();

//////////////////////////////////////////// 25th Nov 2023 //////////////////////////////
///

//GenericCollectionExample objGen = new GenericCollectionExample();

//objGen.ListOperation();


//////////////////////////////////////////////////// 29th September 2023 ////////////////////////////////

ExceptionHandlingExample objExcep = new ExceptionHandlingExample();


objExcep.TestMethod(200);



Console.ReadLine(); // to read from the screen. 

