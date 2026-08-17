
// Declare two integer variables
int x = 10;
int y = 20;

/*
   Calculate the sum of x and y
   and print the result to the console.
*/
int sum = x + y;

Console.WriteLine(sum);
//What is the shortcut to comment and uncomment a selected block of code in Visual Studio?

//Comment: Ctrl + K, ثم Ctrl + C
//Uncomment: Ctrl + K, ثم Ctrl +U

//Problem 2: Identify and fix the errors
//Question: Identify and fix the errors in this code snippet:

int x = "10";
console.WriteLine(x + y);


/*
يوجد أكثر من خطأ في الكود:

1-x متغير من نوع int، لذلك لا يمكن وضع "10" بين علامات التنصيص. الصحيح هو 10.
2-console يجب أن تكون Console لأن C# حساسة لحالة الأحرف.
المتغير3- y غير مُعرّف، لذلك يجب تعريفه قبل استخدامه.
*//*
int x = 10;
int y = 20;

Console.WriteLine(x + y);
*/
//A runtime error occurs while the program is running and can cause the program to stop or throw an exception.

//Example:

int x = 10;
int y = 0;


Console.WriteLine(x / y);

/*
Declare variables using proper naming conventions to store:

Your full name.
Your age.
Your monthly salary.
Whether you are a student. 

 */
string fullName = "Mohamed Fouad";
int age = 19;
double monthlySalary = 5000.0;
bool isStudent = true;

//Why is it important to follow naming conventions such as PascalCase in C#?

//Naming conventions make the code easier to read,
//understand, and maintain. They also make it easier for developers to identify different types of classes, methods, and variables.

//Write a program to demonstrate that changing the value of a reference type affects all references pointing to that object.

class Person
{
  public string Name;
}

Person person1 = new Person();
  person1.Name = "Mohamed";

  Person person2 = person1;

  person2.Name = "Ahmed";

  Console.WriteLine(person1.Name);
  Console.WriteLine(person2.Name);
//Explain the difference between value types and reference types in terms of memory allocation.

//Value Types store their actual value directly. Examples include int, double, bool, and struct.

//Reference Types store a reference to an object in memory. Examples include class, string, and arrays.

//Value Type:
//variable → actual value

//Reference Type:
//variable → reference → object


/*
 Create a program that calculates the following using variables x = 15 and y = 4:
o Sum
o Difference
o Product
o Division result
o Remainder 
 */
int h= 15;
int c = 4;

int Sum = h + c;
int Difference = h - c;
int Product = h * c;
int Division = h / c    ;
int Remainder = h % c;

Console.WriteLine($"Sum: {Sum}");
Console.WriteLine($"Difference: {Difference}");
Console.WriteLine($"Product: {Product}");
Console.WriteLine($"Division: {Division}");
Console.WriteLine($"Remainder: {Remainder }");

//What will be the output of the following code? Explain why:

int a = 2, b = 7;

Console.WriteLine(a % b);

/*
لرمز % اسمه Remainder Operator، يعني بيجيب باقي القسمة.

مثلاً:

15 ÷ 4

الـ 4 تدخل في 15 عدد 3 مرات:

4 × 3 = 12

واللي يتبقى:

15 - 12 = 3

إذن:

15 % 4 = 3
*/


//Write a program that checks if a given number is both:

//Greater than 10.
//Even.

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number > 10 && number % 2 == 0)
{
  Console.WriteLine("The number is greater than 10 and even.");
}
else
{
  Console.WriteLine("The condition is not satisfied.");
}
//Write a program that checks if a given number is both:

//Greater than 10.
//Even.
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number > 10 && number % 2 == 0)
{
  Console.WriteLine("The number is greater than 10 and even.");
}
else
{
  Console.WriteLine("The condition is not satisfied.");
}

//How does the && (logical AND) operator differ from the & (bitwise AND) operator?

/*
 The && operator is a logical AND operator used with Boolean conditions. It returns true only when both conditions are true, and it uses short-circuit evaluation.

The & operator is a bitwise AND operator used to perform an AND operation on the individual bits of integer values. It can also be used with Boolean operands, but unlike &&, it does not short-circuit.



 */

bool a = true;
bool b = false;

Console.WriteLine(a && b);


//Implement a program that takes a double input from the user and casts it to an int. Use both implicit and explicit casting, then print the results.

Console.Write("Enter a double number: ");
double number = double.Parse(Console.ReadLine());

// Implicit casting
double implicitResult = 10;

// Explicit casting
int explicitResult = (int)number;

Console.WriteLine($"Implicit casting result: {implicitResult}");
Console.WriteLine($"Explicit casting result: {explicitResult}");

//Why is explicit casting required when converting a double to an int?


//Explicit casting is required because converting a double to an int may cause data loss. The decimal part cannot be stored in an int, so C# requires the programmer to explicitly confirm that this conversion is intended.


//Write a program that:
/*
Prompts the user for their age as a string.
Converts the string to an integer using Parse.
Checks if the age is valid, e.g.greater than 0.
*/



Console.Write("Enter your age: ");
string ageInput = Console.ReadLine();

int age = int.Parse(ageInput);

if (age > 0)
{
  Console.WriteLine("Valid age.");
}
else
{
  Console.WriteLine("Invalid age.");
}

//What exception might occur if the input is invalid and how can you handle it?
//If the user enters a value that cannot be converted to an integer, int.Parse() throws a FormatException.
try
{
  Console.Write("Enter your age: ");
  string ageInput = Console.ReadLine();

  int age = int.Parse(ageInput);

  if (age > 0)
  {
    Console.WriteLine("Valid age.");
  }
  else
  {
    Console.WriteLine("Invalid age.");
  }
}
catch (FormatException)
{
  Console.WriteLine("Please enter a valid number.");
}




//Question:

//Write a program that demonstrates the difference between prefix and postfix increment operators using a variable x.
int x = 5;

int prefix = ++x;

Console.WriteLine($"Prefix result: {prefix}");
Console.WriteLine($"x after prefix: {x}");

x = 5;

int postfix = x++;

Console.WriteLine($"Postfix result: {postfix}");
Console.WriteLine($"x after postfix: {x}");


//Given the code below, what is the value of x after execution? Explain why.
int x = 5;
int y = ++x + x++;


/*قيمة x في النهاية هي:

7

والـ y قيمته:

12
الشرح:

نبدأ:

x = 5

أول جزء:

++x

Prefix → يزود x الأول:

x = 6

وبالتالي القيمة المستخدمة هي 6.

بعدها:

x++

Postfix → يستخدم القيمة الحالية أولًا:

القيمة المستخدمة = 6

ثم يزود x:

x = 7

إذن:

y = 6 + 6
y = 12


x = 7
 */




Console.ReadLine();
