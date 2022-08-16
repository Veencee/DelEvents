namespace DelegateTask
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Write out the delegate for this expression
            // var likelyUsername = t.FirstName + "." + t.LastName;
            //var dUserCount = repoUser.WhereOne(x => x.UserName == likelyUsername);

            //Two.use a delegate to create a callback for a long running task
            Completed.clockCycles(ShowCompletedCycle);

        }
        public static void ShowCompletedCycle(int elapsedCycle)
        {
            Console.WriteLine($"{elapsedCycle} cycles elapsed");
        }
    }
}