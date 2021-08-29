using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalTree : ISerializable
	{
		private CArray<CHandle<gameJournalRootFolderEntry>> _rootEntries;

		[Ordinal(0)] 
		[RED("rootEntries")] 
		public CArray<CHandle<gameJournalRootFolderEntry>> RootEntries
		{
			get => GetProperty(ref _rootEntries);
			set => SetProperty(ref _rootEntries, value);
		}
	}
}
