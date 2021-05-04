using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class gameJournalCodexDescription : gameJournalCodexDescription_
    {
        private CBool _activatedAtStart;

        [Ordinal(999)]
        [RED("activatedAtStart")]
        public CBool ActivatedAtStart
        {
            get => GetProperty(ref _activatedAtStart);
            set => SetProperty(ref _activatedAtStart, value);
        }

        public gameJournalCodexDescription(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
