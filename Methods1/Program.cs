void ShowText()
{
    Console.WriteLine("Welcome");
}
//ShowText();

void Sum()
{
    int a = 5;
    int b = 10;
    int sum = a + b;
    Console.WriteLine(sum);
}
//Sum()

string SumOfNumber()
{
    int a = 5;
    int b = 10;
    int sum = a + b;
    string res = $"Summary of numbers is - {sum}";
    return res;
}

//var result = SumOfNumber();
//Console.WriteLine(result);

void SumOfEvenNumbers()
{
    int[] arr = { 1, 2, 3, 4, 5 };
    int sum = 0;

    foreach (var item in arr)
    {
        if (item % 2 == 0)
        {
            sum += item;
        }
    }
    Console.WriteLine(sum);
}

//SumOfEvenNumbers();

void ShowTxt(string text)
{
    Console.WriteLine(text);
}

//ShowTxt("Azerbaycan");

//bool isMarried = true;
//if (isMarried)
//{
//    string txt = "Married";
//    ShowTxt(txt);
//}
//else
//{
//    ShowTxt("Not Married");
//}

void SumOfNumbers(int num1,int num2)
{
    int sum = num1 + num2;
    Console.WriteLine(sum);
}

//SumOfNumbers(1, 2);

void SumOfOddNumbers(int[] arr,int num2)
{
    int sum = 0;
    foreach (var item in arr)
    {
        if (item % 2 != 0)
        {
            sum += item;
        }
    }
    int result = sum + num2;
    Console.WriteLine(result);
}

//int[] nums = { 1, 2, 3, 4, 5 };
//SumOfOddNumbers(nums, 5);


//Console.WriteLine("Enter you name");
//string name = Console.ReadLine();


//Console.WriteLine("Enter your surname");
//string surname = Console.ReadLine();

//Console.WriteLine(name+ " " +surname);

/////////////////////////////////////////


//Console.WriteLine("Enter first number");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter second number");
//int num2 = int.Parse(Console.ReadLine());

//int result = num1 + num2;
//Console.WriteLine("Result:");
//Console.WriteLine(result);

//////////////////////////////////////

int[] GetDatas(int num, params int[] nums)
{
    return nums;
}

//var result = GetDatas(1, 2, 3, 4, 5, 6);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

///////////////////////////////////////

int GetDatas2(int num1, int num2, params int[] nums)
{
    int SumOfNums = num1 + num2;
    int SumOfArr = 0;
    foreach (var item in nums)
    {
        SumOfArr += item;
    }
    int result = SumOfNums + SumOfArr;
    return result;
}

//var result = GetDatas2(1, 2, 3, 4, 5);

//Console.WriteLine(result);

///////////////////////////////////////

string GetName(string name = "XXX")
{
    return name;
}

//Name: string name = Console.ReadLine();
//if (name == "")
//{
//    Console.WriteLine(GetName());
//    goto Name;
//}
//else
//{
//    Console.WriteLine(GetName(name));
//}

/////////////////////////////

string Login(string username, string password)
{
    if (username == "Cavid123" && password == "cavid123_")
    {
        return "Login Succes";
    }
    else
    {
        return "Email or password wrong";
    }
}

//Username: Console.WriteLine("Enter username");
//string username = Console.ReadLine();


//Console.WriteLine("Enter password");
//string password = Console.ReadLine();

//if (IsValid(username, password))
//{
//    Console.WriteLine("Input cannot be empty");
//    goto Username;
//}

//string result = Login(username, password);

//Console.WriteLine(result);




bool IsValid(string username, string password)
{
    if (username == "" || password == "")
    {
        return false;
    }
    return true;

}