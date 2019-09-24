using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;


namespace File_Reader
{
    class Files
    {
            public Boolean doesFileExist(string path)
            {
                    try
                    {
                        if (File.Exists(path))
                             { return true; }
                        else { throw new FileNotFoundException(); }
                       

            }
            catch (FileNotFoundException ex)
                    {
                    Console.WriteLine(ex.Message);
                    return false; 
                    }
                    
                }
            }
        }
    

