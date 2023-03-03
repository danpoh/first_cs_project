/* A dialogue function */
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();//this is the talking point
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();//this adds another adjective to the pile
string c = " of Doom";//the origin of DOOMMMM
string d = "3000";//to exaggerate 
Console.WriteLine("The " + b + " " + a + c + d + "!");