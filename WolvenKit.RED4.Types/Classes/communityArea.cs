using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityArea : ISerializable
	{
		[Ordinal(0)] 
		[RED("entriesData")] 
		public CArray<communityCommunityEntrySpotsData> EntriesData
		{
			get => GetPropertyValue<CArray<communityCommunityEntrySpotsData>>();
			set => SetPropertyValue<CArray<communityCommunityEntrySpotsData>>(value);
		}

		public communityArea()
		{
			EntriesData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
