using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRootFolderEntry : gameJournalFolderEntry
	{
		private raRef<gameJournalDescriptorResource> _descriptor;

		[Ordinal(2)] 
		[RED("descriptor")] 
		public raRef<gameJournalDescriptorResource> Descriptor
		{
			get => GetProperty(ref _descriptor);
			set => SetProperty(ref _descriptor, value);
		}

		public gameJournalRootFolderEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
