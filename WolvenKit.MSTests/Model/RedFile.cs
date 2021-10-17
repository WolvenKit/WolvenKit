using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WolvenKit.MSTests.Model
{
    public class RedFile
    {
        [Key]
        public ulong RedFileId { get; set; }

        public string Name { get; set; }

        public string Archive { get; set; }

        public virtual ulong[] Uses { get; set; }

        public virtual ulong[] UsedBy { get; set; }
    }
}
