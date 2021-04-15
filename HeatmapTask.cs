using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var heatMap = new double[30, 12];
            var temp = heatMap.GetLength(0);

            foreach (var currentName in names)
            {
                if (currentName.BirthDate.Day != 1)
                {
                    heatMap[currentName.BirthDate.Day - 2, currentName.BirthDate.Month - 1] += 1;
                }
            } 
            
           
            var horizontal = new string[30];
            for (int i = 0; i < horizontal.Length; i++)
            {
                horizontal[i] = (2 + i).ToString();
            }
            var vertical = new string[12];
            for (int i = 0; i < vertical.Length; i++)
            {
                vertical[i] = (1+i).ToString();
            }
   
            return new HeatmapData("Интенсивность по месяцам",heatMap,horizontal,vertical);



                /*"Пример карты интенсивностей",
                new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 4 }, { 4, 4, 4 } }, 
                new[] { "a", "b", "c", "d" }, 
                new[] { "X", "Y", "Z" });*/
        }
    }
}