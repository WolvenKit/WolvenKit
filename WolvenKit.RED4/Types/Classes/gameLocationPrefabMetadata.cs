using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLocationPrefabMetadata : worldPrefabMetadata
	{
		[Ordinal(0)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("ignoreParentPrefabs")] 
		public CBool IgnoreParentPrefabs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameLocationPrefabMetadata()
		{
			Tags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
