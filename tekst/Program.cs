
string text = "Боги, боги мои! Как грустна вечерняя земля!   "
            + "Как таинственны туманы над болотами."
            + "Кто блуждал в этих туманах, кто много страдал передсмертью, "
            + "кто летел над этой землей, неся на себе непосильный груз, тот это знает."
            + "Это знает уставший.";

string Replace(string text, char oldValue, char newValue)
{

 string result = string.Empty;

 int lenght = text.Length;

 for(int i = 0; i < lenght; i++)
 {
  if(text[i] == oldValue) result = result + $"{newValue}";
  else result = result + $"{text [i]}";

 }

 return result;

}

string newText = Replace(text, ' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText  = Replace(text, 'к','К');
Console.WriteLine(newText);