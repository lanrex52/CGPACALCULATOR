using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace CGPACALCULATOR
{
    class CgpaCalc
    {
       
        char grade;
        public void calculateGPA()
        {

            WriteLine(".................... Calculating your Grade Point Average......................");
            WriteLine("How Many Courses Did you Take This Semester");

            int courses = Convert.ToInt32(ReadLine());
            int[] cour = new int[courses];
            double[] point = new double[courses];
            string[] coursecode = new string[courses];
            string[] coursename = new string[courses];
            int[] testcore = new int[courses];
            int[] examscore = new int[courses];
            
            double[] gradepoint = new double[courses];

           


            for (int i = 0; i < cour.Length; i++)
            {
                WriteLine($"Enter The Name for Course {i + 1}");
                coursename[i] = ReadLine();

                WriteLine($"Enter The Code for Course {i + 1}");
                coursecode[i] = ReadLine();

                WriteLine($"Enter The CA Score for Course {i + 1}");
                testcore[i] = int.Parse(ReadLine());
                WriteLine($"Enter The Exam Score for Course {i + 1}");
               examscore[i] = int.Parse(ReadLine());
               int totalscore = examscore[i] + testcore[i];
                if (totalscore >= 70 || totalscore == 100)
                {
                    grade = 'A';
                    gradepoint[i] = 5.0;

                }
                else if (totalscore >= 60 || totalscore == 69)
                {
                    grade = 'B';
                    gradepoint[i] = 4.0;

                }
                else if (totalscore >= 50 || totalscore == 59)
                {

                    grade = 'C';
                    gradepoint[i] = 3.0;
                }
                else if (totalscore >= 45 || totalscore == 49)
                {

                    grade = 'D';
                    gradepoint[i] = 2.0;
                }
                else if (totalscore >= 40 || totalscore == 44)
                {

                    grade = 'E';
                    gradepoint[i] = 1.0;
                }
                else if (totalscore <= 39 || totalscore == 0)
                {

                    grade = 'F';
                    gradepoint[i] = 0.0;
                }

                WriteLine($" Enter The unit for Course {i + 1} :");

                point[i] = double.Parse(ReadLine());

              
                WriteLine($"\n\n\n The ToTal Score is: {totalscore} and The Grade is {grade}");

                WriteLine("..........................................................................................\n\n");

            }

            double sum = 0;
            double tot;



            for (int j = 0; j < courses; j++)
            {
               
            
                tot = point[j] * gradepoint[j];
                sum = sum + tot;
            
            }


            double totcr = 0;

            for (int k = 0;
                k < courses;
                k++)

            {
                totcr = totcr + gradepoint[k];

            }
           

            WriteLine($" \n\n\nTotal Points: { sum} Total Credits { totcr}  Total GPA: { sum / totcr} ...........................................................................................\n\n" );

            menu:
            int inmenu;
            WriteLine( " \n\n\n1. Calculate Again " );
            WriteLine( " 2. Go Back To The Main Menu " );
            WriteLine( " 3. Exit" );
            WriteLine( " Enter your Input " );
            inmenu = int.Parse(ReadLine());
            switch (inmenu)
            {
                case 1: calculateGPA();
                    break;
                case 2: Main();
                    break;
                case 3: Environment.Exit(inmenu);
                    break;
                default: WriteLine("\n\nYou Have Entered The Wrong Input. Try again!\n");
                    goto menu;
            }



        }
        public void CalculateCgpa()
        {
            WriteLine(".................... Calculating your Cummulative Grade Point Average......................");
            WriteLine("How Many Semester Result Are You Calculating? :");

            int semesters = Convert.ToInt32(ReadLine());
            int[] semes = new int[semesters];
            double[] TotalcreditPoint = new double[semesters];
            double[] TotalCreditUnit = new double[semesters];
            for (int i = 0; i < semes.Length; i++)
            {

                WriteLine($" Enter The Total Credit Point for Semester {i + 1} :");
                
                TotalcreditPoint[i] = double.Parse(ReadLine());

                WriteLine($" Enter The Total Credit unit for Semester {i + 1} :");

                TotalCreditUnit[i] = double.Parse(ReadLine());



                WriteLine("..........................................................................................\n\n");

            }



            double Tcp = 0;
            double SemesterTCP;
            for (int j = 0;
                j < semesters;
                j++)
            {
                SemesterTCP = TotalcreditPoint[j] + TotalcreditPoint[j];
                Tcp += SemesterTCP;
            }
            double TCU = 0;
            double semesterTCU;

            for (int k = 0;
                k < semesters;
                k++)

            {
                semesterTCU = TotalCreditUnit[k] + TotalCreditUnit[k];
                TCU += semesterTCU;

            }
            WriteLine($" ~~~~~~~~~~~~~~~~~~~~~~~~~~~~Your CGPA is  { Tcp / TCU } ~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");

            menu:
            int inmenu;
            WriteLine(" \n\n\n1. Calculate Again ");
            WriteLine(" 2. Go Back To The Main Menu ");
            WriteLine(" 3. Exit");
            WriteLine(" Enter your Input ");
            inmenu = int.Parse(ReadLine());
            switch (inmenu)
            {
                case 1:
                    CalculateCgpa();
                    break;
                case 2:
                    Main();
                    break;
                case 3:
                    Environment.Exit(inmenu);
                    break;
                default:
                    WriteLine("\n\nYou Have Entered The Wrong Input. Try again!\n");
                    goto menu;
            }

        }
       public  void Formulae()
        {
           
            WriteLine(  " ......................... Formular used To Calculating GPA & CGPA .................................\n\n");
          WriteLine( " GPA = Sum of (credit * point) / Credit Unit \n" );
          WriteLine( " CGPA = Total Credit Point (TCP) / Total Credit Unit (TCU) " );
            WriteLine( "....................................................\n\n" );
            menu: int inmenu;
            WriteLine( " 1. Go Back To The Main Menu " );
          WriteLine( " 2. Exit" );
           WriteLine( " Enter your Input " );
            inmenu = int.Parse(ReadLine());
            switch (inmenu)
            {
                case 1:
                    Main();
                    break;
                case 2:
                    Environment.Exit(inmenu);
                    break;
                default:
                    WriteLine("\n\nYou Have Entered The Wrong Input. Try again!\n");
                    goto menu;
            }
        }
        
        static void Main()
        {
            CgpaCalc gpa = new CgpaCalc();
            
            menu:
            int inmenu;
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine(" \n\n\n1. Calculate GPA ");
            WriteLine(" 2. Calculate CGPA ");
            WriteLine(" 3. Formula Used To Calculate CGPA and CGPA ");

            WriteLine(" 4. Exit");
            WriteLine(" Enter your Input ");
            inmenu = int.Parse(ReadLine());
            switch (inmenu)
            {
                case 1:
                    gpa.calculateGPA();
                    break;
                case 2:
                    gpa.CalculateCgpa();

                    break;
                case 3:
                    gpa.Formulae();
                    break;
                case 4:
                    Environment.Exit(inmenu);
                    break;
                default:
                    WriteLine("\n\nYou Have Entered The Wrong Input. Try again!\n");
                    goto menu;
                   
            }

           
        }
    }

}
