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

        public double GetAverageSalary(string[,] data)
        {
            double sum = 0;
            int count = 0;

            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (double.TryParse(data[i, 6], out double salary))
                {
                    sum += salary;
                    count++;
                }
            }
            return count > 0 ? Math.Round(sum / count, 2) : 0;
        }
    }
}
