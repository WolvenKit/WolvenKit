using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityArea : ISerializable
	{
		private CArray<communityCommunityEntrySpotsData> _entriesData;

		[Ordinal(0)] 
		[RED("entriesData")] 
		public CArray<communityCommunityEntrySpotsData> EntriesData
		{
			get => GetProperty(ref _entriesData);
			set => SetProperty(ref _entriesData, value);
		}
	}
}
