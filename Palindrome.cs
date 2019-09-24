using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a word");
    string word = Console.ReadLine();
   if (Palindrome.CheckWord(word)) {
      Console.WriteLine("YES"); 
   } else {
      Console.WriteLine("NO");  
   }

  }
}

class Palindrome
{
    public static bool CheckWord(string word){
        char[] chars = word.ToCharArray();
        Array.Reverse(chars);
        string reverseWord = new string(chars);
        if(word == reverseWord){
            return true;
        } else {
            return false;
        }
    }
}