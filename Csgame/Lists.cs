using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FIX LIST IF POSSIBLE OR FIND A WAY TO MAKE THIS WORK


namespace CsGame
{
    internal class Lists
    {
        public List<string> inventory = new List<string>();

        public List<string> endings = new List<string>();
        public List<string> itemspyra();
        itemspyra.Add("Hay");
        itemspyra.Add("Iron bar");
        itemspyra.Add("Brozne bar");
        itemspyra.Add("Bricks");
        Random randNum = new Random();
        int aRandomPos = randNum.Next(itemspyra.Count);
        string itemspyramid = itemspyra[aRandomPos];
        return itemspyra;

        List<string> firstNames = new List<string>();
        firstNames.Add("Rocks");
        firstNames.Add("Rope");
        firstNames.Add("Small chunks of wood");
        firstNames.Add("Glass");
        firstNames.Add("Cloth");
        Random randNum2 = new Random();
        int aRandomPos2 = randNum.Next(firstNames.Count);
        string Desert = firstNames[aRandomPos];

        List<string> firstNames2 = new List<string>();
        firstNames2.Add("ENERGYSWORD");
        firstNames2.Add("HL");
        firstNames2.Add("FSBERSERK");
        firstNames2.Add("ZENITH");
        firstNames2.Add("BLOODMOON");
        firstNames2.Add("PLEB");
        firstNames2.Add("TENSAZANGETSU");
        firstNames2.Add("kamonevim");
        Random randNum3 = new Random();
        int aRandomPos3 = randNum3.Next(firstNames2.Count);
        string codes = firstNames2[aRandomPos];

        List<string> firstNames3 = new List<string>();
        firstNames3.Add("Snake");
        firstNames3.Add("Scorpion");
        Random randNum4 = new Random();
        int aRandomPos4 = randNum4.Next(firstNames3.Count);
        string desertene = firstNames3[aRandomPos4];
    }
}







//////Program.cs

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;

////namespace ListExample
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            List<ListSample> itemlist = new List<ListSample>();   //creating a list
////            ListData objlist = new ListData();
////            objlist.addlist(itemlist);
////            Console.ReadLine();
////        }
////    }
////}

////First you create a list in the main function. ListData is the class name in which we are using this list.

////itemlist is the name of list created.  ListSample is another class where we are getting data.

////ListSample.cs

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;

////namespace ListExample
////{
////    public class ListSample
////    {

////        public string name { get; set; }
////        public int age { get; set; }

////    }
////}

////ListData.cs

////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;

////namespace ListExample
////{
////    public class ListData
////    {
////        public void addlist(List<ListSample> listitem)    //function named adlist used to add data into list
////        {
////            ListSample obj = new ListSample();    //creating object
////            obj.name = “appu”;         //adding data to object
////            obj.age = 25;
////            listitem.Add(obj);          //adding data to list

////            foreach (var item in listitem)         //display list items
////            {
////                Console.WriteLine(item.name);
////                Console.WriteLine(item.age);
////            }
////        }
////    }
////}
////int idx = authors.IndexOf("Naveen Sharma");
////if (idx > 0)
////    Console.WriteLine($"Item index in List is: {idx}");
////else
////    Console.WriteLine("Item not found");
///
// Program: Copy items from one list to another list
//Console.WriteLine("Import one list to another!");

//// Create List1
//List<string> listOne = new();
//listOne.Add("One");
//listOne.Add("Two");
//listOne.Add("Three");
//listOne.Add("Four");
//listOne.Add("Five");

//// Create List2
//List<string> listTwo = new();
//listTwo.Add("A");
//listTwo.Add("B");
//listTwo.Add("C");

//// Add List2 to List1
//listOne.AddRange(listTwo);

//// Display
//foreach (string item in listOne)
//    Console.WriteLine(item);

//Console.ReadKey();