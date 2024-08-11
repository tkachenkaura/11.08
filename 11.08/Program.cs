namespace _11._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", Enumerable.Range(10, 41)));
            Console.WriteLine(string.Join(",", Enumerable.Range(10, 41).Where(x => x % 3 == 0)));
            Console.WriteLine(string.Join(",", Enumerable.Repeat("Linq", 10)));
            Console.WriteLine(string.Join(",", "aaa;abb;ccc;dap".Split(';').Where(word => word.Contains('a'))));
            Console.WriteLine(string.Join(",", "aaa;abb;ccc;dap".Split(';').Where(word => word.Contains('a')).Select(word => word.Count(c => c == 'a'))));
            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Any(word => word == "abb"));
            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').OrderByDescending(word => word.Length).First());
            Console.WriteLine("aaa;xabbx;abb;ccc;dap".Split(';').Average(word => word.Length));
            Console.WriteLine(new string("aaa;xabbx;abb;ccc;dap;zh".Split(';').OrderBy(word => word.Length).First().Reverse().ToArray()));
            Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').FirstOrDefault(word => word.StartsWith("aa")).Skip(2).All(c => c == 'b'));
            Console.WriteLine("baaa;aabb;aaa;xabbx;abb;ccc;dap;zh".Split(';').Where(word => word.EndsWith("bb")).Skip(2).LastOrDefault());


        }
    }
}