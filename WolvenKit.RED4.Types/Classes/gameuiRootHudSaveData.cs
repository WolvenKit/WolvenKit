using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRootHudSaveData : ISerializable
	{
		private CArray<questHUDEntryVisibilityData> _entriesVisibility;

		[Ordinal(0)] 
		[RED("entriesVisibility")] 
		public CArray<questHUDEntryVisibilityData> EntriesVisibility
		{
			get => GetProperty(ref _entriesVisibility);
			set => SetProperty(ref _entriesVisibility, value);
		}
	}
}
