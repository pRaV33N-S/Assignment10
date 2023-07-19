using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        public static void createFile()
        {
            Console.WriteLine("Enter the Path for the new file");
            string fpath = Console.ReadLine();
            Console.WriteLine("Enter the New File's name");
            string name = Console.ReadLine();
            string thePath = fpath + name;
            if (File.Exists(thePath))
            {
                Console.WriteLine("The File Already Exists");
            }
            else
            {
                StreamWriter sw = File.AppendText(thePath);
                sw.WriteLine("This is Assignment No : 10");
                sw.WriteLine("Topic : File Handling");
                sw.Dispose();
                sw.Close();
                Console.WriteLine("Now the File is Created in the Directory");
            }
        }
        public static void readFiles()
        {
            Console.WriteLine("Enter the File name and its Path to read");
            string readFile = Console.ReadLine();
            StreamReader sr = new StreamReader(readFile);
            string text = "";
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            sr.Close();
        }
        public static void appendFiles()
        {
            Console.WriteLine("Enter the Path for the file to Open");
            string openFile = Console.ReadLine();
            Console.WriteLine("Enter the Content to Append");
            string appendFile = Console.ReadLine();
            File.AppendAllText(openFile, appendFile);
        }
        public static void deleteFiles()
        {
            Console.WriteLine("Enter the Path for the file to Delete");
            string deleteFile = Console.ReadLine();
            File.Delete(deleteFile);
            Console.WriteLine("The File is Deleted from the Directory");
        }
        static void Main(string[] args)
        {
            again:
            try
            {
                Console.WriteLine("Choose the File Operation to Perform");
                Console.WriteLine("1. File Creation \n2. File Reading \n3. File Appending \n4. File Deletion");
                Console.WriteLine("Enter the operation number");
                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        {
                            createFile();
                            break;
                        }
                    case 2:
                        {
                            readFiles();
                            break;
                        }
                    case 3:
                        {
                            appendFiles();
                            break;
                        }
                    case 4:
                        {
                            deleteFiles();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong Choice");
                            break;
                        }
                        
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("Do you want to Continue?\n1.Yes\t2.No");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    goto again;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the Program");
            }
                
        }
    }
}
