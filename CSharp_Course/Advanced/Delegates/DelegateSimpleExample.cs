using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Advanced.Delegates
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    public class DelegateSimpleExample
    {
        public static void Manager_WorkPerformed(int workHours, WorkType wType)
        {
            Console.WriteLine("Work performed by Event Handler");
            Console.WriteLine($"Work hours: {workHours}, Work type: {wType}");
        }
    }
    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }

    /*
    public class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(DelegateSimpleExample.Manager_WorkPerformed);
            del1(10, WorkType.Golf);
            Console.ReadKey();
        }
    }
    */
}
