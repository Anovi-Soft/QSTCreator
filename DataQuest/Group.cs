using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataQuest
{
    /// <summary>
    /// Integreation <see cref="Grouping"/> elements in <see cref="Group"/>.
    /// It`s can be <see cref="Grouping"/>
    /// </summary>
    [Serializable]
    public class Group : Grouping
    {
        /// <summary>
        /// Group elements
        /// </summary>
        private HashSet<Grouping> _elements = new HashSet<Grouping>();
        public HashSet<Grouping> Elements {
            get { return _elements; }
            set
            {
                foreach (var grouping in _elements)
                    grouping.RemoveFromGroup();
                _elements = value;
                foreach(var grouping in _elements)
                    grouping.ToGroup(this);
            }
        } 

        public string Name { get; set; }

        public override string ToString() => Name;
        
    }
    
   
}
