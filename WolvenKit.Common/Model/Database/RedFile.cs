using System.Collections.Generic;

namespace WolvenKit.Common.Model.Database
{
    public class RedFile
    {
        public int Id { get; set; }

        public int ArchiveId { get; set; }
        public RedArchive? Archive { get; set; }
        public ulong Hash { get; set; }

        public virtual ICollection<RedFileUse>? Uses { get; set; }
    }
}
