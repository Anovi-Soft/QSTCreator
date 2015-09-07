using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataQuest
{
    /// <summary>
    /// Contain numbers of selected flags and last user`s choise
    /// </summary>
    [Serializable]
    public class GameFlags
    {
        public static Dictionary<string, int> NumbersFlags = new Dictionary<string, int>();
        public int DialogChoice { get; set; }
        public HashSet<int> Flags = new HashSet<int>();

        /// <summary>
        /// Are this object implement to other?
        /// Checking flags and last user`s choise
        /// </summary>
        /// <param name="other">Checked GameFlags</param>
        /// <returns>True if this implement to other</returns>
        public bool ImplementTo(GameFlags other)
        {
            return DialogChoice == other.DialogChoice && Flags.All(a => other.Flags.Contains(a));
        }
        

    }
}
