using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WolvenKit.Interaction
{
    public static class Interactions
    {
        public static readonly Interaction<string, bool> Confirm = new();
        public static readonly Interaction<IEnumerable<string>, bool> ConfirmMultiple = new();


        public static readonly Interaction<string, string> Rename = new();

    }
}
