//Eve Bibas 322276619 Dina Pinchuck337593958
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] reservations = new bool[12, 31]; 
            for (int i = 0; i < 12; i++)//to make all the dates false
                for (int j = 0; j < 31; j++)
                    reservations[i, j] = false; 
            bool flag = false;
            int startDate = 0, length = 0, startMonth = 0,helpJ=0,helpI=0,counter=0,helper=0,helpMonth=0,helpDate=0 ;
            Console.WriteLine("Enter your choice: 0 to add a dates, 1 to print the taken date, 2 for stats, and 3 to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 0://reserves dates
                        Console.WriteLine("enter the day of the month your stay will start");
                        startDate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the month your stay will take place in");
                        startMonth = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter how long your stay will be");
                        length = Convert.ToInt32(Console.ReadLine());
                        if (startDate > 30 || startMonth > 11 || startDate < 0 || startMonth < 0)
                        {
                            Console.WriteLine("the date is not valid");
                            break;
                        }
                        helpDate = startDate;
                        helpMonth = startMonth;
                        helper = 0;
                        if (startDate < 30 && reservations[startMonth, ++helpDate] == true)//checks if the day after requested date is taken
                        {
                            Console.WriteLine("sorry,those dates are taken");
                            break;
                        }
                        else
                        
                            if (startDate == 30 && reservations[++helpMonth, 0] == true) // if he choose the last day of the month and the next day is not available 
                            {
                                Console.WriteLine("sorry,those dates are taken");
                                break;
                            }

                        else
                            flag = true;
                        helpDate = startDate;
                        helpMonth = startMonth;
                     
                        if (flag == true) // the days are available
                        {


                            for (int i = startMonth; i < 12; i++)//switches the dates to true
                                for (int j = 0; j < 31; j++)
                                {
                                    if ((j>=startDate && startDate < 31)||(helper>0 && helper<=length))
                                    {
                                        if (helper < length)
                                        {
                                            reservations[i, j] = true;
                                            helper++;
                                        }
                                    }
                                 
                                    if (startDate == 30)
                                         j = 0;
                                    if (helper == length)
                                        break;
                                }
                            
                        }
                
                        break;
                    case 1://prints the taken dates

                        for (int i = 0; i < 12; i++)
                            for (int j = 0; j < 31; j++)
                            {
                                helpI = i;
                                helpJ = j;
                                if ( j != 0 && reservations[i, j] == true && reservations[i, --helpJ] == false)//prints the first date in the block if taken dates

                                {
                                    Console.Write(i + "/" + j + "  ");
                                    

                                }
                                helpJ = j;
                                if (i!=0 &&  j == 0 && reservations[i, j] == true && reservations[--helpI, 30] == false)//prints the first date in the block if taken dates if j=0

                                {
                                    Console.Write(i + "/" + j + "  ");
                                    

                                }
                                if (i==0 && j==0 && reservations[i,j]==true)//if january first is reserved there is no previous date to check
                                 {
                                    Console.Write(i + "/" + j + "  ");

                                }

                                helpI = i;
                                //printing the final date in the block of dates
                                if (reservations[i, j] == true && j != 30 && reservations[i, ++helpJ] == false)
                                {
                                    Console.WriteLine(i + "/" + j + "  ");
                                    
                                }
                                else
                                
                                    if (reservations[i, j] == true && j == 30 && reservations[++helpI, 0] == false)
                                {
                                    Console.WriteLine(i + "/" + j + "  ");
                                    helpI = i;
                                }
                                else 
                                    if (reservations[i, j] == true && reservations[i, helpJ] == false)
                                        Console.WriteLine(i + "/" + j + "  ");
                                

                            }

                        break;


                    case 2: //stats
                        for (int i = 0; i < 12; i++)
                        {
                            for (int j = 0; j < 31; j++)
                            {
                                if (reservations[i, j] == true)
                                    counter++;

                            }
                        }
                        Console.WriteLine(counter + "   days of the year taken");
                        Console.WriteLine((counter / 3.75) + "  percent of year taken");
                        break;

                    case 3://exit
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
                Console.WriteLine("Enter your choice: 0 to add a date, 1 to print the taken dates, 2 for stats, and 3 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice != 3);
            Console.ReadKey();
        }
    }
}
/*Enter your choice: 0 to add a dates, 1 to print the taken date, 2 for stats, and 3 to exit
0
enter the day of the month your stay will start
28
enter the month your stay will take place in
5
enter how long your stay will be
4
Enter your choice: 0 to add a date, 1 to print the taken dates, 2 for stats, and 3 to exit
1
5/28  6/0
Enter your choice: 0 to add a date, 1 to print the taken dates, 2 for stats, and 3 to exit
0
enter the day of the month your stay will start
4
enter the month your stay will take place in
3
enter how long your stay will be
12
Enter your choice: 0 to add a date, 1 to print the taken dates, 2 for stats, and 3 to exit
1
3/4  3/15
5/28  6/0
Enter your choice: 0 to add a date, 1 to print the taken dates, 2 for stats, and 3 to exit
2
16   days of the year taken
4.26666666666667  percent of year taken
Enter your choice: 0 to add a date, 1 to print the taken dates, 2 for stats, and 3 to exit
3

*/
