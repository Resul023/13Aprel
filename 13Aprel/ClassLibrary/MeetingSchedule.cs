using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MeetingSchedule
    {
        public List<Meeting> Mettings = new List<Meeting>();
        public void SetMeeting(string FullName, DateTime From, DateTime To)
        {
            int count = 0;
            if (From<To)
            {
                foreach (var item in Mettings)
                {
                    if ((item.FromDate < From && item.ToDate < To && item.ToDate < From) || (item.FromDate > From && item.ToDate > To && item.ToDate > From) && From < To)
                    {
                        count++;

                    }

                }
                if (count == Mettings.Count)
                {

                    Meeting newMetting = new Meeting();
                    newMetting.Name = FullName;
                    newMetting.FromDate = From;
                    newMetting.ToDate = To;
                    Mettings.Add(newMetting);
                }
                else
                {
                    throw new Exception("This schedule is Full");
                }
            }
            else
            {
                Console.WriteLine("This type of schedule is not exist");
            }
  
        }
        public int FindMeetingsCount(DateTime Time) 
        {
            return Mettings.FindAll(x => x.FromDate > Time).Count;
            
        }
        public bool IsExistsMeetingByName(string Name) 
        {
            return Mettings.Exists(x => x.Name == Name);
        }
        public List<Meeting> GetExistsMeetingByName(string Name) 
        {
            List<Meeting> NewList = new List<Meeting>();
            foreach (var item in Mettings.FindAll(x => x.Name == Name))
            {
                NewList.Add(item);
            }
            return NewList;

        }
    }
}
