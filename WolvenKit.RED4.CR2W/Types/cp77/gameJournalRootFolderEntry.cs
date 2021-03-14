using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRootFolderEntry : gameJournalFolderEntry
	{
		[Ordinal(2)] [RED("descriptor")] public raRef<gameJournalDescriptorResource> Descriptor { get; set; }

		public gameJournalRootFolderEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
