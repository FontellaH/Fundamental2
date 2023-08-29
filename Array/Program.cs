// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Complete the Three Basic Arrays section.

int[] numArray = new int[10];  //Create an integer array with the values 0 through 9 inside.
for (int i = 0; i < numArray.Length; i++)
{
    numArray[i] = i;
}

string[] nameArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };  //Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".

bool[] boolArray = new bool[10];  //Create a boolean array of length 10.
bool currentValue = true;
for (int i = 0; i < boolArray.Length; i++)  //Then fill it with alternating true/false values, starting with true.
{
    boolArray[i] = currentValue;
    currentValue = !currentValue;  // This flips the value from true to false or vice versa
}

//----------------------------------------------------------------------------------------------------------------------------

// //Complete the List of Flavors section.

// List<string> iceCreamFlavors = new List<string>(); // created a icecream list and added 5 differnt flavors
// iceCreamFlavors.Add("Chocolate");
// iceCreamFlavors.Add("Vanilla");
// iceCreamFlavors.Add("Strawberry");
// iceCreamFlavors.Add("Mint");
// iceCreamFlavors.Add("Coffee");

// Console.WriteLine($"Number of flavors: {iceCreamFlavors.Count}");  //.Count gives the number of elements in the list
// Console.WriteLine($"Third flavor: {iceCreamFlavors[2]}");  // Looking for the 3rd flavor in the iceCream

// iceCreamFlavors.RemoveAt(2);  //removes the 3rd flavor by using removeAt from the list

// Console.WriteLine($"Number of flavors when removed: {iceCreamFlavors.Count}");  // recounting the # of flavors left in the list


//------------------------------------------------------------------------------------------------------------------------------

//Complete the User Dictionary section.


        // Names of people and ice cream flavors
        string[] namesArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };  //lists names of people and flavors of ice cream using arrays and a list
        List<string> iceCreamFlavors = new List<string>
        {
            "Chocolate", "Vanilla", "Strawberry", "Mint", "Cookie Dough"
        };

        // Dictionary to store user choice
        Dictionary<string, string> userChoice= new Dictionary<string, string>();  //sets up a "dictionary" to keep track of what flavors each person likes
        Random rand = new Random(); // Helps in choosing random things

        
        foreach (string name in namesArray) // Assigning random flavors to each user
        {
            int randomIndex = rand.Next(iceCreamFlavors.Count);
            string randomFlavor = iceCreamFlavors[randomIndex];
            userChoice[name] = randomFlavor;
        }

        // Printing user choice
        Console.WriteLine("User Choice:");  // Printing user choice
        foreach (KeyValuePair<string, string> kvp in userChoice)
        {
            Console.WriteLine($"{kvp.Key} likes {kvp.Value} ice cream"); //prints out everyone's name and their preferred ice cream flavor
        }


