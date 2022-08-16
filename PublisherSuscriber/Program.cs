namespace OnlineStoreEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GGGGG STORE!");
            Admin admin = new Admin();
            admin.ActionTaken();
            admin.WarrantedPenalty();
        }
    }
}