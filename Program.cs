//***Main

System.Console.WriteLine("Welcome to Gavin's README markdown generator\n\nPress any key to get started");
Console.ReadKey();

StreamWriter outfile = new StreamWriter("markdown.txt");

Title(outfile);
Description(outfile);
KeyFeatures(outfile);

System.Console.WriteLine("Done!");
outfile.Close();


//END MAIN***

static void Title(StreamWriter outfile){
    System.Console.WriteLine("Enter the title for your project");
    string userTitle = Console.ReadLine();

    outfile.WriteLine($"# {userTitle}");
}

static void Description(StreamWriter outfile){
    System.Console.WriteLine("Enter a description for your project");
    string userDescription = Console.ReadLine();

    outfile.WriteLine("## Description");
    outfile.WriteLine(userDescription);
}

static void KeyFeatures(StreamWriter outfile){
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