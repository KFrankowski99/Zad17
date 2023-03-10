using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 1; i <= 1000; i++)
        {
            sum += NumberInWordsLength(i);
        }
        Console.WriteLine(sum);

    }

    private static int NumberInWordsLength(int num)
    {
        if (num == 1000)
        {
            return "onethousand".Length;
        }
        string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string words = "";
        if (num >= 100)
        {
            words += ones[num / 100] + "hundred";        
            num %= 100;
            if (num > 0)
            {
                words += "and";
               
            }
        }
        if (num >= 20)
        {
            words += tens[num / 10];
            num %= 10;
           
        }
        if (num > 0)
        {
            words += ones[num];
           
        }
        Console.WriteLine(words);
        return words.Length;
    }
}