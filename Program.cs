using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ulesanne2.Group;

namespace Ulesanne2
{
    public class Program
    {
        public static void Main()
        {
            {
                Group group = new Group(3);
                Console.WriteLine(AddMemberAndColor(group, "John"));  // True
                Console.WriteLine(AddMemberAndColor(group, "John"));  // False
                Console.WriteLine(AddMemberAndColor(group, "Mary"));  // True
                Console.WriteLine(AddMemberAndColor(group, "Jane"));  // True
                Console.WriteLine(AddMemberAndColor(group, "Joseph"));  // False
                Console.WriteLine(string.Join(", ", group.Members));  // John, Mary, Jane
                Console.WriteLine(group.GetMembersCount());  // 3

                Group bookClub = new Group(4);
                Console.WriteLine(AddMemberAndColor(bookClub, "Albert"));   // True
                Console.WriteLine(AddMemberAndColor(bookClub, "Samantha"));  // True
                Console.WriteLine(AddMemberAndColor(bookClub, "Robert"));   // True
                Console.WriteLine(AddMemberAndColor(bookClub, "Roberta"));  // True
                Console.WriteLine(string.Join(", ", bookClub.Members));  // Albert, Samantha, Robert, Roberta

                Console.WriteLine(AddMemberAndColor(bookClub, "Albert"));  // True
                Console.WriteLine(AddMemberAndColor(bookClub, "John"));  // False
            }
        }

        private static string AddMemberAndColor(Group group, string member)
        {
            if (group.AddMember(member))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "True";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "False";
            }
        }
    }
}