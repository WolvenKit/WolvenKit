using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalTree : ISerializable
	{
		private CArray<CHandle<gameJournalRootFolderEntry>> _rootEntries;

		[Ordinal(0)] 
		[RED("rootEntries")] 
		public CArray<CHandle<gameJournalRootFolderEntry>> RootEntries
		{
			get => GetProperty(ref _rootEntries);
			set => SetProperty(ref _rootEntries, value);
		}

		public gameJournalTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
