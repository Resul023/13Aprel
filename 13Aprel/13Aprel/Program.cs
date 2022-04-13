using System;
using ClassLibrary;
namespace _13Aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting1 = new Meeting();
            meeting1.Name = "Met1";
            meeting1.FromDate = new DateTime(2020, 03, 01);
            meeting1.ToDate = new DateTime(2020, 03, 02);

            Meeting meeting2 = new Meeting();
            meeting2.Name = "Met2";
            meeting2.FromDate = new DateTime(2020, 03, 03);
            meeting2.ToDate = new DateTime(2020, 03, 04);

            Meeting meeting3 = new Meeting();
            meeting3.Name = "Met3";
            meeting3.FromDate = new DateTime(2020, 03, 05);
            meeting3.ToDate = new DateTime(2020, 03, 06);

            MeetingSchedule newSchedule = new MeetingSchedule();
            newSchedule.Mettings.Add(meeting1);
            newSchedule.Mettings.Add(meeting2);
            newSchedule.Mettings.Add(meeting3);
            DateTime dateFrom = new DateTime(2020, 03, 03);
            DateTime dateTo = new DateTime(2020, 03, 08);

            newSchedule.SetMeeting("Met4", dateFrom, dateTo);
            foreach (var item in newSchedule.Mettings)
            {
                Console.WriteLine(item);
            }

            /*DateTime check = new DateTime(2020, 03, 04);
            Console.WriteLine(newSchedule.FindMeetingsCount(check));*/

            /*Console.WriteLine(newSchedule.IsExistsMeetingByName("Met"));*/

            /* foreach (var item in newSchedule.GetExistsMeetingByName("Met1"))
             {
                 Console.WriteLine(item);
             }*/

        }
    }
}
