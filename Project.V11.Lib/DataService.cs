using System.Text;

namespace Project.V11.Lib
{
    public class DataService
    {
        public string[,] LoadData(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            string[,] array = new string[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] columns = lines[i].Split(';');
                for (int j = 0; j < colCount; j++)
                {
                    array[i, j] = columns[j].Trim();
                }
            }
            return array;
        }

        public void SaveData(string path, string[,] data)
        {
            StringBuilder strBuilder = new StringBuilder();

            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < cols; j++)
                {
                    str += data[i, j] + ";";
                }

                str = str.TrimEnd(';');
                strBuilder.AppendLine(str);
            }

            File.WriteAllText(path, strBuilder.ToString(), Encoding.UTF8);
        }

        public (int Count, double Average, double Min, double Max) CalculateStatistics(double[] salaries)
        {
            if (salaries == null || salaries.Length == 0)
            {
                return (0, 0, 0, 0);
            }

            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            int count = salaries.Length;

            for (int i = 0; i < count; i++)
            {
                double salary = salaries[i];
                sum += salary;
                if (salary > max) max = salary;
                if (salary < min) min = salary;
            }

            double average = Math.Round(sum / count, 2);

            return (count, average, min, max);
        }
    }
}
