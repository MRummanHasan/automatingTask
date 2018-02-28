using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nasfia\Desktop\Data.txt";
            try
            {
                /*
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                */

                int counter = 0; 
                string line;
                string[] str = new string[1600];
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    str[counter] = line;
                    counter++;
                }
                file.Close();


                for (int i = 0; i < counter; i++)
                {
                    if (i % 7 == 0)
                    {
                        if (str[i] != null)
                        {
                            try
                            {
                                string[] splitted = str[i].Split('.');
                                splitted[0] = "";
                                str[i] = splitted[0] + splitted[1].Trim();
                                Console.WriteLine(str[i]);
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        Console.WriteLine(str[i]);
                    }
                }

                using (StreamWriter finaloutput = new StreamWriter("FinalOutput.txt"))
                {
                    foreach (var item in str)
                    {
                        finaloutput.WriteLine(item);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
             Console.ReadKey();
        }
    }
}
