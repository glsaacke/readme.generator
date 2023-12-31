//***Main

System.Console.WriteLine("Welcome to Gavin's README markdown generator\n\nPress any key to get started");
Console.ReadKey();

StreamWriter outfile = new StreamWriter("markdown.txt");

Title(outfile);
Description(outfile);
RunInstructions(outfile);
KeyFeatures(outfile);

Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Done!");
Console.ResetColor();

outfile.Close();


//END MAIN***

static void Title(StreamWriter outfile){
    Console.Clear();
    System.Console.WriteLine("Enter the title for your project");
    string userTitle = Console.ReadLine();

    outfile.WriteLine($"# {userTitle}");
}

static void Description(StreamWriter outfile){
    Console.Clear();
    System.Console.WriteLine("Enter a description for your project");
    string userDescription = Console.ReadLine();

    outfile.WriteLine("## Description");
    outfile.WriteLine(userDescription);
}

static void RunInstructions(StreamWriter outfile){
    Console.Clear();
    System.Console.WriteLine("Enter run instructions for your project");
    string userInstructions = Console.ReadLine();

    outfile.WriteLine("## Run Instructions");
    outfile.WriteLine(userInstructions);
}

static void KeyFeatures(StreamWriter outfile){
    Console.Clear();
    outfile.WriteLine("## Key Features");

    System.Console.WriteLine("Enter a key feature, or 1 to stop");
    string userInput = Console.ReadLine();
    string keyDescription = "";

    while(userInput != "1"){
        System.Console.WriteLine("Enter points for [" + userInput + "], separated by a '#'");
        keyDescription = Console.ReadLine();
        string[] temp = keyDescription.Split('#');

        outfile.WriteLine($"### {userInput}");

        for(int i = 0; i < temp.Length; i++){
            outfile.WriteLine($"• {temp[i]}");
        }

        System.Console.WriteLine("Enter a key feature, or 1 to stop");
        userInput = Console.ReadLine();
    }
}