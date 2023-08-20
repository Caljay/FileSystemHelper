using System;
using System.IO;

class Program
{
   
    static void FileNameRemoverAndCopier()
    {
        /* 
         
        First need to collect some information on:
        where the files are
        where to copy the files after words removed
        what characters or words should be removed
    
         */

        Console.WriteLine("Enter your intial File Path");
        string filePath = Console.ReadLine();

        Console.WriteLine("Where should the completed files go?");
        string CompleteFiles = Console.ReadLine();

        Console.WriteLine("What characters or words would you like to remove?");
        string keywordForDeletion = Console.ReadLine(); ;



        string[] allFiles = Directory.GetFiles(filePath);
        List<string> renamedFiles = new List<string>();

        foreach (var item in allFiles)
        {
            Console.WriteLine(item + "\n");

            var newitem = item.Replace(keywordForDeletion, string.Empty);
            var finalItem = newitem.Replace(filePath, string.Empty);
            renamedFiles.Add(finalItem);
            Console.WriteLine(newitem + "\n");

        }
        for (int i = 0; i < renamedFiles.Count; i++)
        {
            File.Copy(allFiles[i], CompleteFiles + "\\" + renamedFiles[i]);
        }


        Console.ReadKey();
    }
    static void Main()
    {
      //starts the FileNameRemover
        FileNameRemoverAndCopier();  
    }

   
}