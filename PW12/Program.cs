//namespace PR12_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int[] Numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
//            int[] Numbers1 = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };
//            int[] Numbers2 = { 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 26, 27, 28, 30, 32, 33, 34, 35, 36, 38, 39, 40, 42, 44, 45, 46, 48, 49, 50};
//            Console.WriteLine("Натуральные числа в каждом множестве");
//            Print_mnozh(Numbers.Intersect(Numbers1).Intersect(Numbers2));
//            Console.WriteLine("Нет ни в одном множестве");
//            Print_mnozh(Numbers.Except(Numbers1).Except(Numbers2));
//            Console.WriteLine("Есть хотя бы в одном");
//            Print_mnozh(Numbers.Union(Numbers1).Union(Numbers2).
//                Except(Numbers.Intersect(Numbers1).Intersect(Numbers2)));
//            Console.ReadKey();
//        }
//        private static void Print_mnozh(IEnumerable<int> res)
//        {
//            //throw new NotImplementedException();
//            foreach (int i in res)
//                Console.WriteLine(i);
//        }
//    }
//}


string line = Console.ReadLine();
char[] chars = line.ToCharArray();
char[] glasletter = { 'а', 'и', 'о', 'у', 'ы', 'э', 'ё', 'ю', 'я' };
Console.WriteLine(chars.Intersect(glasletter).Count());
Console.ReadKey();