using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_DB
{
    public static class CheckInputData
    {
        private static void OutputErrorCountColumns(string nameFile)
        {
            Console.WriteLine($"Ошибка количества столбцов в файле {nameFile}.");
            Environment.Exit(0);
        }
        public static void InputErrorRightCountColumns(string[] date, int count, string nameFile)
        {
            if (date.Length != count)
                OutputErrorCountColumns(nameFile);
        }
        private static void OutputErrorType(string nameError)
        {
            Console.WriteLine($"Ошибка типа данных в столбце {nameError}.");
            Environment.Exit(0);
        }
        private static void InputErrorInt(string num, string nameColumn)
        {
            if (!int.TryParse(num, out int number))
                OutputErrorType(nameColumn);
        }
        private static void InputErrorDateTime(string num, string nameColumn)
        {
            if (!DateTime.TryParse(num, out DateTime dateTime))
                OutputErrorType(nameColumn);
        }
        public static void InputErrorProperties(string[] line, PatternObjectDB patternObjectDB)
        {
            int i = 0;
            foreach(PatternPropertyDB prop in patternObjectDB.Properties.Values)
            {
                switch (prop.Type)
                {
                    case PatternPropertyDB.PropertyType.Int:
                        InputErrorInt(line[i], prop.Name);
                        break;
                    case PatternPropertyDB.PropertyType.DataTime:
                        InputErrorDateTime(line[i], prop.Name);
                        break;
                }
                i++;
            }
        }
    }
}
