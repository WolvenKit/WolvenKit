using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRootHudSaveData : ISerializable
	{
		[Ordinal(0)] 
		[RED("entriesVisibility")] 
		public CArray<questHUDEntryVisibilityData> EntriesVisibility
		{
			get => GetPropertyValue<CArray<questHUDEntryVisibilityData>>();
			set => SetPropertyValue<CArray<questHUDEntryVisibilityData>>(value);
		}

		public gameuiRootHudSaveData()
		{
			EntriesVisibility = new();
		}
	}
}
