using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalTree : ISerializable
	{
		[Ordinal(0)] 
		[RED("rootEntries")] 
		public CArray<CHandle<gameJournalRootFolderEntry>> RootEntries
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalRootFolderEntry>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalRootFolderEntry>>>(value);
		}

		public gameJournalTree()
		{
			RootEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
