using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Exercize
{
    class Module6Files
    {
        // source: sample date taken from module 6 of 20483B
        // author: steven martinez
        // published on 7 November 2019
        //
        // student: Steven Martinez
        // synopsis: read and write to files

        // where is the file stored?
        
        // string fileLocation = "E:\\Program Files\\Repos\\CSharp-Exercize\\C-Sharp-Exercize\\Media\\InterviewQuestions.txt";

        //read all data from file into one string

        public void FileReading(string path)
        {
            //put contents of file into 1 string. 
            string FileContents = File.ReadAllText(path);
            Console.WriteLine(FileContents);

            /* first 10 lines of output for this method are: 
            What are your greatest strengths?

            What are your greatest weaknesses?

            Tell me about yourself.

            How do you handle stress and pressure?

            Describe a difficult work situation or project and how you overcame it.

            */
        }

        public void FileLineRead(string path)
        {
            // each line of the file is written to another index of a string array

            string[] fileContents = File.ReadAllLines(path);

            // print lines 10 - 14 of the array created from ReadAllLines
            for (int i = 10; i < 15; i++)
            {
                Console.WriteLine(fileContents[i]);
            }

            /* Output (the blank lines are in the text file).
                What motivates you?

                Are you overqualified for this job?

                Why are you leaving or why have you left your job?
             */
        }

        public void FileWriteAllText(string path, string words)
        {
            //writes a new file with "words"
            File.WriteAllText(path, words);
            Console.WriteLine("new file complete"); //just to let me know the operation is complete
            Console.WriteLine();
            // output is a new file at the location indicated by the file path.

        }

        public void FileAppendText(string path, string wordsToAppend)
        {
            File.AppendAllText(path, wordsToAppend);
            Console.WriteLine("file append complete");
            Console.WriteLine();
            //output is the next line in the file that is already created.
        }

        
        /* NEED HELP WITH THIS METHOD....
        // this method has hard coding in it that I would not normally use except here to illustrate the 
        // point of taking data from one file and putting it into another. 
        public void FileWriteLines(string path1, string path2)
        {
            // writes lines 15-24 into the file we've been manipulating
            string[] fileContents = File.ReadAllLines(path1);

            for (int i = 15; i < 25; i++)
            {
                File.AppendAllLines(path2, fileContents[i]);
            }

            //output is lines 15-24 written to the second file.
        }
        */


    }
}
