//Метод1

//void Method1()
//{
//Console.WriteLine("Автор Евдошенко О.");
//}
//Method1();


//Метод2

//void Method2(string msg)
//{
  //  Console.WriteLine("msg");
//}
//Method2(msg:"Текст сообщения");


//void Method21(string msg, int count)
//{
  //  int i=0;
    //while(i < count)
    //{
      // Console.WriteLine(msg);
        //i++;
    //}
//}
//Method21(msg:"Текст", count: 4);


//Метод 3
//int Method3()
//{
  //  return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);


//Метод4

string Method4(int count, string c)
{
int i = 0;
string result = string.Empty;
while(i < count)
{
    result = result + c;
    i++;
}
return result;
}

string res =  Method4(5, "abc");

Console.WriteLine(res);