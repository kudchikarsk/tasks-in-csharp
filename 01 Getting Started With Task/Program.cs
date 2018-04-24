using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Getting_Started_With_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //create task object and pass anonymous method 
            //to task constructor parameter as work to do 
            //within the task
            Task t = new Task(() =>
              {
                  for (int i = 0; i < 10; i++)
                  {
                      //print current thread id of task t
                      Console.WriteLine("Task For Loop Current Thread Id " + Thread.CurrentThread.ManagedThreadId);
                  }
              });

            //start task t execution
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                //print current thread id of main thread
                Console.WriteLine("Main For Loop Current Thread Id " + Thread.CurrentThread.ManagedThreadId);
            }

            //wait for task t to complete its execution
            t.Wait();

            Console.WriteLine("Press enter terminate the process!");
            Console.ReadLine();
        }
    }
}
