using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Phonr_book
{
    internal class Program
    {
        class Phone
        {
            string Name;
            long Number;
            public void input()
            {
                Console.WriteLine("Имя ");
                Name = Console.ReadLine();
                Console.WriteLine("Номер");
                Number = Convert.ToInt64(Console.ReadLine());   
            }
            public void Write()
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path = path + @"\Phone.txt";
                var a = new StreamWriter(path,true);
                a.Write(Name + " ");
                a.Write(Number + "\n");
                a.Close();
            }
        }
       
        static void Main(string[] args)
        {
           Phone phone = new Phone();
            do
            {
                phone.input();
                phone.Write();
            } while (true);
            
         }
    }
}
