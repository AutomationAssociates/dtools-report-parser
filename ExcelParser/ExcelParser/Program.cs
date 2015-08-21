using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelParser
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type path of excel file:\n");
            string path = @Console.ReadLine();

            var dataReader = new ExcelDataReader(path);
            var dictionary = dataReader.getDataEntry();
            foreach (KeyValuePair<string, DataEntry> pair in dictionary)
            {
                Console.WriteLine("{0} {1}", pair.Key, pair.Value.Hours + " " + pair.Value.Price);
            }
            Console.ReadLine();
        }

    }
    
} 