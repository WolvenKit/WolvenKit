using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communitySquadInitializer : communitySpawnInitializer
	{
		private CArray<communitySquadInitializerEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<communitySquadInitializerEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
