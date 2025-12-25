using Project.V11.Lib; 

namespace Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidCalculateStatistics()
        {
            double[] salaries = { 10000, 20000, 30000 };

            var result = ds.CalculateStatistics(salaries);

            Assert.AreEqual(3, result.Count);          
            Assert.AreEqual(20000, result.Average);    
            Assert.AreEqual(10000, result.Min);        
            Assert.AreEqual(30000, result.Max);        
        }

        [TestMethod]
        public void ValidLoadData()
        {
            string path = @"test_load.csv";
            string content = "Col1;Col2;Col3\nVal1;Val2;Val3";
            File.WriteAllText(path, content);

            try
            {
                string[,] res = ds.LoadData(path);

                Assert.AreEqual(2, res.GetLength(0)); 
                Assert.AreEqual(3, res.GetLength(1));

                Assert.AreEqual("Col1", res[0, 0]);  
                Assert.AreEqual("Val3", res[1, 2]);
            }
            finally
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }

        [TestMethod]
        public void ValidSaveData()
        {
            string path = @"test_save.csv";
            string[,] data = new string[2, 2]
            {
                { "Header1", "Header2" },
                { "Data1", "Data2" }
            };

            try
            {
                ds.SaveData(path, data);

                Assert.IsTrue(File.Exists(path));

                string fileContent = File.ReadAllText(path);

                Assert.IsTrue(fileContent.Contains("Header1;Header2"));
                Assert.IsTrue(fileContent.Contains("Data1;Data2"));
            }
            finally
            {
                if (File.Exists(path)) File.Delete(path);
            }
        }
    }
}