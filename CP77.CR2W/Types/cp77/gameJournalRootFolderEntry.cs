using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalRootFolderEntry : gameJournalFolderEntry
	{
		[Ordinal(0)]  [RED("descriptor")] public raRef<gameJournalDescriptorResource> Descriptor { get; set; }

		public gameJournalRootFolderEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
