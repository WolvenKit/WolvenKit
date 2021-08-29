using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCommunitySpawnSetNameToID : RedBaseClass
	{
		private CArray<gameCommunitySpawnSetNameToIDEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<gameCommunitySpawnSetNameToIDEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
