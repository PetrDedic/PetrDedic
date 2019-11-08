using System;
using DisplayHelper;

namespace Grading
{
 
    class Program
    {
        static void Main(string[] args)
        {
            


            Display displayGrading = new Display(20, 5, 5, 5);
            displayGrading.AddItem(new Item("-- Vysvědčení --", ""));
            displayGrading.AddItem(new Item("", ""));
            Display displayInput = new Display(20, 5, 5, 5);
            displayInput.AddItem(new Item("---- zadávání předmětu ----", ""));
            displayInput.AddItem(new Item("Předmět", ""));
            Display displayInput2 = new Display(20, 5, 5, 5);
            displayInput2.AddItem(new Item("---- zadávání známky ----", ""));
            displayInput2.AddItem(new Item("Známka", ""));
            Display displayConfirm = new Display(20, 5, 5, 5);
            displayConfirm.AddItem(new Item("Chceš vložit dalšího? [A]", ""));




            Grade[] grades = new Grade[9];
            grades[0] = new Grade() { Subject = "MAT", Score = 1 };
            grades[1] = new Grade() { Subject = "CJL", Score = 4 };
            grades[2] = new Grade() { Subject = "PRG", Score = 1 };
            grades[3] = new Grade() { Subject = "MAT", Score = 2 };
            grades[4] = new Grade() { Subject = "CJL", Score = 5 };
            grades[5] = new Grade() { Subject = "CJL", Score = 3 };
            grades[6] = new Grade() { Subject = "PRG", Score = 1 };
            grades[7] = new Grade() { Subject = "MAT", Score = 2 };
            grades[8] = new Grade() { Subject = "MAT", Score = 2 };

            ConsoleKeyInfo result;
            do
            {
                int grade;
                string temp;
                displayInput.Repaint();
                temp = Console.ReadLine();
                displayInput2.Repaint();
                int.TryParse(Console.ReadLine(), out grade);
                if (temp.Length == 3 && grade < 6 && grade > 0) table.AddGrade(new Grade() { Score = grade, Subject = temp });

                displayConfirm.Repaint();
                result = Console.ReadKey();
                Console.Clear();

            } while (result.Key == ConsoleKey.A || result.Key == ConsoleKey.Enter);

            foreach (var grade in grades)
            {
                GradeAvg ga = table.AddGrade(grade);
            }

            foreach (var item in table.GetAllGrades())
            {
                displayGrading.AddItem(new Item(item.Subject, item.GetAverage()));
            }

            Console.Clear();
            displayGrading.Repaint();


            Console.ReadKey();
        }
    }
}
