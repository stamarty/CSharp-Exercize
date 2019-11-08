using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Exercize
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = "E:\\Program Files\\Repos\\CSharp-Exercize\\C-Sharp-Exercize\\Media\\InterviewQuestions.txt";
            string fileLocation2 = "E:\\Program Files\\Repos\\CSharp-Exercize\\C-Sharp-Exercize\\Media\\SecondFile.txt";

            Module6Files file = new Module6Files();

            

            file.FileLineRead(fileLocation);

            file.FileWriteAllText(fileLocation2, "Here are some words to write! \n");
            file.FileAppendText(fileLocation2, "this should be a second line in the SecondFile.txt \n");

            FileInfo settings = new FileInfo(fileLocation);
            long length = settings.Length;
            Console.WriteLine(length);

        }
    }
}
