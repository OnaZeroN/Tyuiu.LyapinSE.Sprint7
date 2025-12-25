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
    }
}
