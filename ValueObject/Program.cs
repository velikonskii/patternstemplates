
using static System.Console;

class Vb {         
    static void Main(string[] args)
    {
        using var ctSource = new CancellationTokenSource();
        
        var token = ctSource.Token;

        // var i = 0;
        // token.Register(() =>
        // {
        //     i = 100;
        //     WriteLine("operation interrupted");
        // });

        var task = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                WriteLine($"Calculating square of {i} is {i*i}");
                Thread.Sleep(1000);
            }
        },token);
        
        Thread.Sleep(3000);
        ctSource.Cancel();
        try
        {
            task.Wait(token);
        } catch (OperationCanceledException e)
        {
            WriteLine("Операция прервана");
        } catch (AggregateException ae)
        {
            foreach (Exception e in ae.InnerExceptions)
            {
                if (e is TaskCanceledException)
                    WriteLine("Операция прервана");
                else
                    WriteLine(e.Message);
            }
        }

        Thread.Sleep(3000);
        WriteLine($"task status: {task.Status}");
    }
}



