using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Panel
{
    class Notepad
    {
        private string Text { get; set; }
        public void Write()
        {
            Console.WriteLine("\nOPENING THE NOTEPAD APP...\n");
            Console.WriteLine("Enter the text you want to save:\n");
            string path = @"C:\Users\IT\Desktop\newText.txt";
            Text = Console.ReadLine();
            File.WriteAllText(path, Text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYour file has been saved to the desktop.");
            Console.ResetColor();
        }
    }
}
