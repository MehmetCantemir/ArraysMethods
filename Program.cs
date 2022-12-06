namespace Arrays_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("******** Sırasız Dizi *************");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******** Sıralı Dizi *************");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Clear

            Console.WriteLine("******** Array Clear *************");
            //sayıdizisi elemanlarıını kullanarak 2.indexten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            //Reverse
            Console.WriteLine("******** Array Reverse *************");
            Array.Reverse(sayiDizisi);
            //sayıdızısi elemanlarını tersten yazdırır.
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //IndexOf

            Array.IndexOf(sayiDizisi,23);

            //Resize
            Console.WriteLine("******** Array Resize *************");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }



        }
    }
}