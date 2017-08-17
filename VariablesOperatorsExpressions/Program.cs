using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {



            //problem #1
            int diners = 4;
            int dinersShare = 13;
            Console.WriteLine("The bill is " + diners * dinersShare);

            //problem #2
            int recipeCups = 7;
            int cupsAdded = 2;
            Console.WriteLine(recipeCups - cupsAdded);


            //problem #3
            int diaperCost = 8;
            int cashOnhand = 40;
            Console.WriteLine(cashOnhand / diaperCost);
            
              
            //problem #4
            int trevonFriMoney = 29;
            int trevonTuesMoney = 41;
            Console.WriteLine(trevonTuesMoney - trevonFriMoney);
            

            //problem #5
            int juliaMiles = 47;
            Console.WriteLine(juliaMiles - 30);
            
           
            //problem #6
            //int box = 3;
            //int cash = 12;
            //int purchase = cash / box;
            //Console.WriteLine(purchase);

            //problem #7
            float saladCost = 5.12f;
            float remainingCash = 27.10f;
            float originalCash = remainingCash + saladCost;
            Console.WriteLine(originalCash);


            //Slide#11
            //problem #1
            int students = 331;
            int studentsInCars = 7;
            int busses = 6;
            int studentsPerBus = (students - studentsInCars) / busses;
            Console.WriteLine(studentsPerBus);

            //



            //problem #3
            //int num = 72;
            //int average = num / 3;
            //int smallestNum = --average;
            //Console.WriteLine(smallestNum);
            
            //problem #4
            int num = 48;
            int average = num / 3;
            int smallestNumber = average - 2;
            Console.WriteLine(smallestNumber);
            
            //problem #5
            int boxesPurchased = 7;
            int remainingBoxes = 22;
            int boxesBeforeFire = remainingBoxes * 2;
            int originalBoxes = boxesBeforeFire - boxesPurchased;
            Console.WriteLine(originalBoxes);



            




             










        }
    }
}
