using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataQuest
{
    /// <summary>
    /// Object that can be grouping
    /// </summary>
    [Serializable]
    public abstract class Grouping
    {
        public Group CurrentGroup { get; set;}

        /// <summary>
        /// Place self to the target group
        /// </summary>
        /// <param name="target">Target group</param>
        public void ToGroup(Group target)
        {
            if (Equals(target))
                throw new InvalidOperationException($"Group {target} can`t move to self");
            CurrentGroup?.Elements.Remove(this);
            CurrentGroup = target;
        }

        /// <summary>
        /// Remove self from current group
        /// </summary>
        public void RemoveFromGroup()
        {
            CurrentGroup?.Elements.Remove(this);
            CurrentGroup = null;
        }

    }
}
