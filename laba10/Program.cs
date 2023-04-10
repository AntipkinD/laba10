using System;
using System.Collections.Generic;
using System.IO;
internal class Program
{

    private static void Main(string[] args)
    {
        StreamReader a = new StreamReader("D:/VSWorks/laba10/wanimals.txt");
        int n = 0;
        List<WaterAnimals> oceanarray = new List<WaterAnimals>();
        while (!a.EndOfStream)
        {
            string[] read = a.ReadLine().Replace(", ", ",").Split(',');
            if (read[0] == "А" || read[0] == "а")
                oceanarray.Add(new BullShark(read[1], int.Parse(read[2])));
            if (read[0] == "Д" || read[0] == "д")
                oceanarray.Add(new CommersonDolphin(read[1], int.Parse(read[2])));
            //Console.WriteLine(oceanarray[oceanarray.Count - 1]);
            n++;
        }
        a.Close();
        try
        {
            oceanarray[2].Kormlenie();
            if (oceanarray[2].Sytost == true)
            {
                for (int i = 0; i < n; i++)
                    if (oceanarray[i].Sytost != true || oceanarray[2].Sytost == true) throw new OguzkiException("Щас папочка всех накормит!");
            }
        } 
        catch(OguzkiException ogr)
        {
            Console.WriteLine(ogr.Message);
        }
        finally
        {
            for (int i = 0; i < n; i++)
            {
                oceanarray[i].Kormlenie();
                Console.WriteLine(oceanarray[i].AllInfo());
            }
        }
        
    }
}