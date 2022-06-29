// ******* UNCOMMENT THE BELOW TO SEE THE DO WHILE LOOP WITH HELLO WORLD REPEATING! ******

//string userinput;
//bool repeatLoop = true;

//do
//{
//    Console.WriteLine("Hello World!");
//    Console.Write("Do you want to continue? (yes/no)");

//    userinput = Console.ReadLine().ToLower();

//    if (userinput != "y" && userinput != "yes")
//    {
//        repeatLoop = false;
//        Console.WriteLine("Thanks for playing!");
//        break;
//    }
//}

//while (repeatLoop == true);

/// -------------------------------------------------------------------------------------------------------------------------------------------------------------------





// ******* UNCOMMENT THE BELOW TO SEE THE FOR LOOP WITH THE OUTPUT OF NUMBERS FROM NUMBER WE CHOSE TO 0! *******

//Console.WriteLine("Please enter a number!:");

//int userInput = int.Parse(Console.ReadLine());

//for (int i = userInput; i >= 0; i--)
//{
//    Console.Write(i);
//}

//for (int i = userInput; i <= 0; i++)
//{
//    Console.Write(i);
//}





/// ******* DESCRIPTION BELOW OF THE DO WHILE LOOP ABOVE! *******
//Description
//Prompt the user for a number. Use a for loop to output all the numbers from that number to 0. After that loop finishes, use another loop to output all the numbers from 0 to that number.

//Example
//>>Enter a number: << 5
//>> 5 4 3 2 1 0
// >> 0 1 2 3 4 5
//Would you like to continue (y/n)? << y
//>> Enter a number: << 12
// >> 12 11 10 9 8 7 6 5 4 3 2 1 0
//  >> 0 1 2 3 4 5 6 7 8 9 10 11 12
//Would you like to continue (y/n)? << n
//>> Goodbye!

/// -------------------------------------------------------------------------------------------------------------------------------------------------------------------


// ******* UNCOMMENT THE BELOW TO SEE THE KEYPAD ENTRY! *******


//bool isLocked = true;

//while (isLocked == true)
//{
//    Console.WriteLine("Hello! To gain access please enter the numerical password:");
//    int userInput = int.Parse(Console.ReadLine());
//    if (userInput == 13579)
//    {
//        Console.WriteLine("Welcome we are glad you made it in!");
//        break;
//    }

//    else 
//    {
//        Console.WriteLine("Please enter the correct password! Numerical values only!");
//    }
//}



/// -------------------------------------------------------------------------------------------------------------------------------------------------------------------

// ******* UNCOMMENT THE BELOW TO SEE THE KEYPAD ENTRY WITH LIMITED TRIES! *******

//Description
//Continue the previous exercise, but now add a limited number of tries, say 5. After 5 unsuccessful attempts, the loop ends, but instead of printing a welcome message, it prints a message warning that there were too many incorrect attempts. (But if the user entered the correct number, it will still print the welcome message as before.)

//bool isLocked = true;
//int attempt = 0;


//while (isLocked == true && attempt <=5 )
//{
//    Console.WriteLine("Hello! To gain access please enter the numerical password:");
//    int userInput = int.Parse(Console.ReadLine());
//    if (userInput == 13579)
//    {
//        Console.WriteLine("Welcome we are glad you made it in!");
//        break;
//    }

//    else
//    {
//        int attempt = attempt++;
//        Console.WriteLine("Please enter the correct password! Numerical values only!");
//    }
//}

/// -------------------------------------------------------------------------------------------------------------------------------------------------------------------


// ******* UNCOMMENT THE BELOW TO SEE THE NEW CONSOLE PROJECT ONE! *******
//Description
//Start a new console project, and repeat the same exercise as the previous, except this time implement it with a do while loop.

/// -------------------------------------------------------------------------------------------------------------------------------------------------------------------


// ******* UNCOMMENT THE BELOW TO SEE THE OPTIONAL STRETCH! *******
//Optional Stretch
//Move the last while loop or the do-while loop into its own function. The function should return a true if access is granted, or a false if the user didn’t enter the correct code within 5 tries.
