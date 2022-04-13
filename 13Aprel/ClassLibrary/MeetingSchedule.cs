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
            
            if (From<To)
            {
                if (Mettings.FindAll(x=> (x.FromDate < From && x.ToDate < To && x.ToDate < From) || (x.FromDate > From && x.ToDate > To && x.FromDate > To)).Count == Mettings.Count) 
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
