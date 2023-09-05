using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulesanne2
{

    public class Group
    {
        public List<Member> Members { get; } = new List<Member>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public bool AddMember(string name, int age)
        {
            if (Members.Any(member => member.Name == name)) return false;
            if (Members.Count >= _maxAmount) return false;
            Members.Add(new Member { Name = name, Age = age });
            return true;
        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(string name)
        {
            return Members.Any(member => member.Name == name);
        }

        public int GetOldestMemberAge()
        {
            if (Members.Count == 0) return 0; // Handle case when there are no members.
            return Members.Max(member => member.Age);
        }

        public int GetYoungestMemberAge()
        {
            if (Members.Count == 0) return 0; // Handle case when there are no members.
            return Members.Min(member => member.Age);
        }
    }

    public class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


}
