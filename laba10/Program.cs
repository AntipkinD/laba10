using System;
using System.Collections.Generic;
using System.IO;
internal class Program
{

    private static void Main(string[] args)
    {
        StreamReader a;
        a = new StreamReader("D:/VSWorks/laba10/wanimals.txt");
        int n = 0;
        List<WaterAnimals> oceanarray = new List<WaterAnimals>();
        while (!a.EndOfStream)
        {
            string[] read = a.ReadLine().Replace(", ", ",").Split(',');
            if (read[0] == "А" || read[0] == "а")
                oceanarray.Add(new BullShark(read[1], int.Parse(read[2])));
            if (read[0] == "Д" || read[0] == "д")
                oceanarray.Add(new CommersonDolphin(read[1], int.Parse(read[2])));
            n++;
        }
        a.Close();
        try
        {
            a = new StreamReader("D:/VSWorks/laba10/wanimalsss.txt");
            switch (a)
            {
                case (null):
                    throw new Exception("Файл пуст!");
            }
            ProverkaSytosty();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Ошибка! Файл не найден по указанному пути: {ex.Message}");
        }
        catch (OguzkiException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally { VseobsheeKormlenie(); }
        void ProverkaSytosty()
        {
            for (int i = 0; i < n; i++)
                if (oceanarray[i].Sytost != true)
                    throw new OguzkiException("Исключение! Все животные голодны!");
        }
        void VseobsheeKormlenie()
        {
        for (int i = 0; i < n; i++)
        {
            oceanarray[i].Kormlenie();
            Console.WriteLine(oceanarray[i].AllInfo());
        }
        }
    }
}