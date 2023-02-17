using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_DB
{
    public static class LoadData
    {
        public static ObjectDB[] ReadObjectDB(string nameFile, PatternObjectDB patternObjectDB)
        {
            string[] data = File.ReadAllLines(nameFile);
            ObjectDB[] objectDBs= new ObjectDB[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                string[] line = data[i].Split(';');
                CheckInputData.InputErrorRightCountColumns(line, patternObjectDB.Properties.Count, nameFile);
                CheckInputData.InputErrorProperties(line, patternObjectDB);
                objectDBs[i] = new ObjectDB(patternObjectDB, line);
            }
            return objectDBs;
        }
    }
}
