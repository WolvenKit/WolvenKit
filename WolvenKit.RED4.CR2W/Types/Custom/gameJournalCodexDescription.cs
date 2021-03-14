using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class gameJournalCodexDescription : gameJournalCodexDescription_
    {
        [Ordinal(999)] [RED("activatedAtStart")] public CBool ActivatedAtStart { get; set; }

        public gameJournalCodexDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
