// See https://aka.ms/new-console-template for more information


 
string[] Items = new string[] { "Wasserflasche", "Kaugummi", "Nudeln", "Kartoffeln" };

string[] Items2 = new string[4];

Items2[0] = "Wasserflasche";
Items2[1] = "Kaugummi";
Items2[2] = "Nudeln";
Items2[3] = "Kartoffeln";

Console.WriteLine(Items[1]);
Console.WriteLine(Items2[3]);  


string[,] names = new string[4, 2];

names[0, 0] = "Dennis";
names[0, 1] = "Gillich";

names[1, 0] = "Sven";
names[1, 1] = "Luft";

names[2, 0] = "Radek";
names[2, 1] = "Sikora";

Console.WriteLine(names[0, 0] + " " + names[2, 1]);


string[,] names2 = new string[,]
{
    {
        "Dennis",
        "Sven",
        "Marie",
        "Lucas"
    },
    {
        "Gillich",
        "Luft",
        "Fuhrmann",
        "Heinz"
    }
};

Console.WriteLine(names2[0, 0] + " " + names2[1 ,0]);
Console.ReadKey();