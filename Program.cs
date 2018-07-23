using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Build_Flag();
            Build_Header_DarkBlue("\t\t     Welcome To 'Not A Chance' Inc.\t\t\t\n\t\t        - Lottery Simulations -    \t\t\t\n\t\t        To Proceed, Press 'Enter'\t\t\t");
            Console.ReadLine();
            UserMenu();
        }
        static void Build_Automatic(int[,] AutomaticArr)
        {
            Random arrRandom = new Random();

            Console.WriteLine();
            for (int arrRows = 0; arrRows < AutomaticArr.GetLength(0); arrRows++)
            {
                for (int arrColumns = 0; arrColumns < AutomaticArr.GetLength(1); arrColumns++)
                {
                    int iVal = arrRandom.Next(1, 46);
                    for (int arrCheck = 0; arrCheck < AutomaticArr.GetLength(1); arrCheck++)
                    {
                        if (iVal != AutomaticArr[arrRows, arrColumns])
                        {
                            continue;
                        }
                        else
                        {
                            arrColumns--;
                            break;
                        }
                    }
                    AutomaticArr[arrRows, arrColumns] = iVal;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Display_Matrix(AutomaticArr);
                Console.ResetColor();
            }
        }
        static string Build_Error(int iError)
        {
            string sError = String.Empty;

            switch (iError)
            {
                case 1:
                    sError = "Invalid Input! Value Must Be A Number";
                    break;
                case 2:
                    sError = "Invalid Input! Your Value Is Out Of Range";
                    break;
                case 3:
                    sError = "Invalid Input! Value Is Indistinct";
                    break;
                default:
                    throw new Exception();
            }

            return sError;
        }
        static void Build_Flag()
        {
            string sStars = " * * * * * * * * * * ";

            Console.Write("\n========================================================================\n");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sStars);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sStars);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sStars);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sStars);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sStars);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sStars);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sStars);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t");
            Console.ResetColor();
            Console.Write("========================================================================\n");

        }
        static void Build_Header_DarkBlue(string sHeader)
        {
            Console.Write("========================================================================\n");
            TextStyle_DarkBlue(sHeader);
            Console.Write("\n========================================================================\n");
        }
        static void Build_Header_White(string sHeader)
        {
            Console.Write("\n========================================================================\n");
            TextStyle_White(sHeader);
            Console.Write("\n========================================================================\n");
        }
        static void Build_Manual(int[,] ManualArr)
        {
            int iError = 0;
            int iInput = 0;
            string sError = String.Empty;
            string sInput = String.Empty;

            for (int arrRows = 0; arrRows < ManualArr.GetLength(0); arrRows++)
            {
                Console.WriteLine();
                for (int arrColumns = 0; arrColumns < ManualArr.GetLength(1); arrColumns++)
                {
                    Console.Write("\tEnter Value #{0} For Row #{1}: ", arrColumns + 1, arrRows + 1);
                    sInput = Console.ReadLine();
                    iError = Check_Value(ManualArr, sInput, arrRows);
                    if (iError == 0)
                    {
                        iInput = int.Parse(sInput);
                        ManualArr[arrRows, arrColumns] = iInput;
                    }
                    else
                    {
                        sError = Build_Error(iError);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\tError #00{0}!", iError);
                        Console.ResetColor();
                        Console.Write(" {0}, Try Again!\n", sError);
                        arrColumns--;
                        continue;
                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Display_Matrix(ManualArr);
                Console.ResetColor();
            }
        }
        static int Build_Rows()
        {
            TextStyle_White("\tEnter Your Desired Number Of Rows: (1 ~ 6): ");
            int iRows = int.Parse(Console.ReadLine());
            while (iRows > 6)
            {
                TextStyle_DarkRed("Invalid Input, Try Again!\n");
                Console.Write("Enter Your Desired Number Of Rows: (1 ~ 6): ");
                iRows = int.Parse(Console.ReadLine());
            }
            return iRows;
        }
        static void Build_Summary(int[,] Matrix)
        {
            Console.Write("\n\tTo Proceed & Display Your Ticket Summary, Please Press Enter: ");
            Console.ReadLine();
            Console.WriteLine();

            int[] LuckyArr = new int[Matrix.GetLength(1)];
            Build_LuckyArr(LuckyArr);
            int[] CheckArr = new int[Matrix.GetLength(1)];
            Check_Lottery(Matrix, LuckyArr, CheckArr);
            int[] arrSum = new int[Matrix.GetLength(1)];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t   Your Lucky Numbers:\n\t\t   ");
            Display_Array(LuckyArr);
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("\t\t\t   Your Ticket Summary:");
            for (int rows = 0; rows < Matrix.GetLength(0); rows++)
            {
                string sTmp = String.Empty;
                if (rows < 10)
                {
                    sTmp = "0";
                }
                else
                {
                    sTmp = String.Empty;
                }
                Console.Write("Row #{0}:    ", sTmp + (rows + 1));
                for (int columns = 0; columns < Matrix.GetLength(1); columns++)
                {
                    if (Matrix[rows, columns] < 10)
                    {
                        sTmp = "0";
                    }
                    else
                    {
                        sTmp = String.Empty;
                    }
                    Console.Write(" | {0,2} | ", sTmp + Matrix[rows, columns]);
                }
                Console.Write("\t{0} Hit(s) Total!", CheckArr[rows]);
                Console.WriteLine();
            }

                #region Row Hit Count

            foreach (var item in CheckArr)
            {
                if (item == 1)
                {
                    arrSum[0]++;
                }
                else if (item == 2)
                {
                    arrSum[1]++;
                }
                else if (item == 3)
                {
                    arrSum[2]++;
                }
                else if (item == 4)
                {
                    arrSum[3]++;
                }
                else if (item == 5)
                {
                    arrSum[4]++;
                }
                else if (item == 6)
                {
                    arrSum[5]++;
                }
            }

                #endregion

            Console.WriteLine();
            for (int i = 0; i < arrSum.Length; i++)
            {
                Console.WriteLine("{0} Hits: {1} Rows Total!", i + 1, arrSum[i]);
            }
            Console.WriteLine("\nPress Enter To Continue: ");
            Console.ReadLine();
            Main();
        }
        static void Build_LuckyArr(int[] LuckyRow)
        {
            Random rRandom = new Random();

            for (int column = 0; column < LuckyRow.Length; column++)
            {
                int iRandom = rRandom.Next(1, 46);
                if (!LuckyRow.Contains(iRandom))
                {
                    LuckyRow[column] = iRandom;
                }
                else
                {
                    column--;
                }
            }
        }
        static void Check_Lottery(int[,] LotteryMatrix, int[] LuckyArr, int[] ArrayCheck)
        {
            for (int row = 0; row < LotteryMatrix.GetLength(0); row++)
            {
                for (int column = 0; column < LotteryMatrix.GetLength(1); column++)
                {
                    foreach (var item in LuckyArr)
                    {
                        if (LotteryMatrix[row, column] == item)
                        {
                            ArrayCheck[row]++;
                        }
                    }
                }
            }
        }
        static int Check_Value(int[,] CheckArr, string sInput, int arrRows)
        {
            int iError = 0;
            int iInput = 0;
            bool bCheck = int.TryParse(sInput, out iInput);

            if (bCheck) //Integer Check
            {
                if (iInput > 0 && iInput < 46) //Range Check
                {
                    for (int i = arrRows; i <= arrRows; i++) //Distinct Check
                    {
                        for (int j = 0; j < CheckArr.GetLength(1); j++)
                        {
                            if (iInput != CheckArr[i, j])
                            {
                                continue;
                            }
                            else
                            {
                                iError = 3;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    iError = 2;
                }
            }
            else
            {
                iError = 1;
            }

            return iError;
        }
        static void Display_Array(int[] array)
        {
            string sTmp = String.Empty;
            for (int column = 0; column < array.Length; column++)
            {
                if (array[column] < 10)
                {
                    sTmp = "0";
                }
                else
                {
                    sTmp = String.Empty;
                }
                Console.Write("{0,5}",sTmp + array[column]);
            }
            Console.WriteLine();
        }
        static void Display_Matrix(int[,] Matrix)
        {
            string sTmp = String.Empty;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] < 10)
                    {
                        sTmp = "0";
                    }
                    else
                    {
                        sTmp = String.Empty;
                    }
                    Console.Write("{0}", "| " + sTmp + Matrix[i, j] + " | ");
                }
                Console.WriteLine();
            } Console.WriteLine();
        }
        static void TextStyle_White(string sText)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(sText);
            Console.ResetColor();
        }
        static void TextStyle_DarkRed(string sText)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sText);
            Console.ResetColor();
        }
        static void TextStyle_DarkBlue(string sText)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sText);
            Console.ResetColor();
        }
        static void UserMenu()
        {
            Console.WriteLine("\t1. To Manually Fill In Your Own Ticket, Enter: 1\n\t2. To Automatically Generate a Random Ticket, Enter: 2\n\t3. To Exit, Enter: 3\n");
            TextStyle_White("\tYour Input: ");
            string sOption = Console.ReadLine();

            while (sOption != "1" && sOption != "2" && sOption != "3")
            {
                TextStyle_DarkRed("\tInvalid Input, Try Again!\n");
                Console.Write("\tYour Input: ");
                sOption = Console.ReadLine();
            }

            string sManual_Instructions = "\n 1. You May Enter Only Numbers Between #01 ~ #45.\n 2. Each Ticket Will Contain 6 Columns.\n 3. The Number Of Rows In Each Ticket Is Up To You (Between 1 ~ 6).\n 4. Finally, A Winning Row Will Be Generated And Compared To Your Ticket.\n 5. Each Winning Ticket Grants It's Participant A U.S. Green Card!\n\n\tYou Will Now Continue To Manually Fill In Your Ticket\n\tGood Luck!\n";
            string sAutomatic_Instructions = "\n 1. The System Will Randomly Generate Numbers Between #01 ~ #45.\n 2. Each Ticket Will Contain 6 Columns.\n 3. The Number Of Rows In Each Ticket Is Up To You (Between 1 ~ 6).\n 4. Finally, A Winning Row Will Be Generated And Compared To Your Ticket.\n 5. Each Winning Ticket Grants It's Participant A U.S. Green Card!\n\n\tYou Will Now Continue Automatically Generate You Ticket\n\tGood Luck!\n";

            int iRows = 0;
            int iColumns = 6;

            switch (sOption)
            {
                case "1":
                    Build_Header_DarkBlue("\t\tYou Have Chosen The Manual Lottery Method!!\t\t");
                    TextStyle_DarkRed("\n\tInstructions:\n");
                    Console.WriteLine(sManual_Instructions);

                    iRows = Build_Rows();
                    int[,] ManualArr = new int[iRows, iColumns];
                    Build_Manual(ManualArr);

                    Build_Header_DarkBlue("\t  You Have Successfully Completed Your Lottery Ticket!! \t");
                    Build_Summary(ManualArr);
                    break;
                case "2":
                    Build_Header_DarkBlue("\t\tYou Have Chosen The Automatic Lottery Method!\t\t");
                    TextStyle_DarkRed("\n\tInstructions:\n");
                    Console.WriteLine(sAutomatic_Instructions);

                    iRows = Build_Rows();
                    int[,] AutomaticArr = new int[iRows, iColumns];
                    Build_Automatic(AutomaticArr);

                    Build_Header_DarkBlue("\t  You Have Successfully Completed Your Lottery Ticket!! \t");
                    Build_Summary(AutomaticArr);
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tExiting... Goodbye\n");
                    Console.ResetColor();
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}