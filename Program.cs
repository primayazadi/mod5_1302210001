namespace mod_132210001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Penjumlahan<float> penjumlahan = new Penjumlahan<float>();
            penjumlahan.jumlahTigaAngka(13, 02, 21);

            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.addNewData(13);
            data.addNewData(02);
            data.addNewData(21);
            data.addNewData(00);
            data.printAllData();
        }
    }

    class Penjumlahan<T>
    {
        public void jumlahTigaAngka(T a, T b, T c)
        {

            dynamic aa = a;
            dynamic bb = b;
            dynamic cc = c;
            Console.WriteLine(aa + bb + cc);
        }

    }

    class SimpleDataBase<T>
    {
        List<T> storeData { get; set; }
        List<DateTime> inputDates { get; set; }

        public SimpleDataBase()
        {
            storeData = new List<T>();
            inputDates = new List<DateTime>();

        }

        public void addNewData(T data)
        {
            storeData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < storeData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi: " + storeData.ElementAt(i) + " yang disimpan pada waktu " + inputDates.ElementAt(i));
            }
        }

    }
}


