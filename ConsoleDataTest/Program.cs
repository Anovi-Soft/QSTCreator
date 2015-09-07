using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataQuest;

namespace ConsoleDataTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var a = new BitArray(int.MaxValue);
        }

        void TestQuestDump()
        {
            new Quest
            {
                Name = "TestQuest",
                Flags = new List<string>{  "TestFlag"  },
                Locations =
                    new List<ILocation>
                    {
                         new Location {FoundFlags = new HashSet<int> {0}, Name = "Test"}
                    }
            }.Dump("tmp.dat");
        }

        void TestQuestLoad()
        {
            var a = Quest.Load("tmp.dat");
        }
    }
}
