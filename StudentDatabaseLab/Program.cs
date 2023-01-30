int StringLength;
bool IsValidNum;
bool IsValidDetail;
string UserNumberInput;
string UserDetailInput;
int num;
string StudentNameReturn;
string StudentDetailReturn;
bool IsHometown = false;
bool IsFavFood = false;
bool Exit;
string GoAgainInput;

string[] Names = new string[5];
Names[1] = "Billy";
Names[2] = "Grace";
Names[3] = "Selena";
Names[4] = "Patti";

for ( StringLength = 0; StringLength < Names.Length; StringLength++)
{
}


string[] HomeTown = new string[StringLength];
HomeTown[1] = "Detroit, MI";
HomeTown[2] = "Nashville, TN";
HomeTown[3] = "New York, NY";
HomeTown[4] = "Phoenix, AZ";

string[] FavoriteFood = new string[StringLength];
FavoriteFood[1] = "Detroit Style Pizza";
FavoriteFood[2] = "Nashville Hot Chicken";
FavoriteFood[3] = "Hot Dogs";
FavoriteFood[4] = "Chili";



do
{



    do
    {


        Console.WriteLine("Please pick a student number to learn more about them? Enter a number between 1-4");
        UserNumberInput = (Console.ReadLine());
        IsValidNum = int.TryParse(UserNumberInput, out num);
        if (IsValidNum is not true)

        {
            Console.WriteLine("Sorry, That is not a valid number.");

        }
        else if ((num < 1 || num > 4))
        {
            IsValidNum = false;
            Console.WriteLine("Sorry, That is not a valid number.");
        }
        else IsValidNum = true;


    } while (IsValidNum == false);

    StudentNameReturn = Names[num];
    Console.WriteLine(StudentNameReturn);



    do
    {


        Console.WriteLine("Current student is: " + StudentNameReturn + " What would you like to know? Enter hometown or favorite food: ");
        UserDetailInput = (Console.ReadLine());
        String LowerUserDetailInput = UserDetailInput.ToLower();

        if (LowerUserDetailInput is "hometown" || LowerUserDetailInput is "home" || LowerUserDetailInput is "town")

        {
            IsValidDetail = true;
            IsHometown = true;


        }

        else if (LowerUserDetailInput is "favorite food" || LowerUserDetailInput is "food")
        {

            IsFavFood = true;
            IsValidDetail = true;
        }

        else
        {
            Console.WriteLine("Sorry, That is not a valid option.");
            IsValidDetail = false;
        }

    } while (IsValidDetail == false);



    if (IsHometown is true)
    {
        StudentDetailReturn = HomeTown[num];
        Console.WriteLine(StudentNameReturn + " is from " + StudentDetailReturn);
    }
    else if (IsFavFood is true)
    {
        StudentDetailReturn = FavoriteFood[num];
        Console.WriteLine(StudentNameReturn + "'s favorite food is " + StudentDetailReturn);
    }


    Console.WriteLine("Would you like to learn about another student? (y/n)");
    GoAgainInput = (Console.ReadLine());

    if (GoAgainInput is "y" || GoAgainInput is "Y" || GoAgainInput is "Yes" || GoAgainInput is "yes")
    {
        Exit = false;
    }
    else
        Exit = true;

} while (Exit == false);

Console.WriteLine("Goodbye! ");