using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web;
using System.Collections.Generic;

namespace File_Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            String file;
            Boolean exists;
            Console.WriteLine("Enter File Path:");
            file = Console.ReadLine();

            Files filepath = new Files();
            exists = filepath.doesFileExist(file);

            if (exists == true)
            {
                using (StreamReader r = new StreamReader(file))
                {

                    string json = r.ReadToEnd();

                    dynamic results = JsonConvert.DeserializeObject<dynamic>(json);
                    Console.WriteLine(results.Word);

                    System.Threading.Thread.Sleep(30000);

                }


            }

        }
    }
}

            


