//TASK 1 ---------------------------------------------------------------
//1 ilə 25 arasında kök altısı olan ədədləri tapın.


//for (int i = 1; i <= 25; i++)
//{
//    double kok = Math.Sqrt(i);
//    if(kok % 1 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//TASK 2 ---------------------------------------------------------------
//Arraydaki yalnız tək ədədlərin cəmini çap edən alqoritm qurun.


//int[] numbers = { 1, 54, 87, 65, 34, 21, 3, 43, 38, 19, 49, 46, 4, 87};
//int sum = 0;
//for(int i = 0; i <= numbers.Length-1; i++)
//{
//    if (numbers[i] % 2 !=0)  
//    {
//        sum += numbers[i];
//    }
//}
//Console.WriteLine(sum);


//TASK 3
//Verilmiş massivin tək indeksində duran elementlərin cəmini tapan alqoritm yazın. Nəticəni konsola çıxarın.


//int[] TakeIndex = { 1, 46 , 4 , 5 , 58, 4, 49, 8, 30, 2, 7, 54, 311, 9 };
//int sum = 0;
//for(int i = 0; i<= TakeIndex.Length; i++)
//{
//    if(i % 2 != 0)
//    {
//        sum += TakeIndex[i];
//    }
//}
//Console.WriteLine(sum);


//TASK 4
//Verilmiş sozun polindrom olub olmadigini göstərən alqoritm yazın


//Console.WriteLine("Please enter a word : ");
//string word = Console.ReadLine();
//word = word.ToLower();
//bool checkPalindrome = true;
//for (int i = 0; i < word.Length / 2; i++)
//{
//    if (word[i] != word[word.Length - 1 - i])
//    {
//        checkPalindrome = false;
//        break;
//    }
//}
//if (checkPalindrome)
//{
//    Console.WriteLine("The word has been entered (" + word + ") is palindrome");
//}
//else
//{
//    Console.WriteLine("The word has been entered (" + word + ") isn't palindrome");
//}