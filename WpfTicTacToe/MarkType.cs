using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTicTacToe
{
    public enum MarkType
    {
        /// <summary>
        /// Th cell hasn't be clicked yet
        /// </summary>
        Free,
        /// <summary>
        /// The cell is o
        /// </summary>
        Nought,
        /// <summary>
        /// The cell is x
        /// </summary>
        Cross
    }
}
