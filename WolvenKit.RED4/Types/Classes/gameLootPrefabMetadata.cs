using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLootPrefabMetadata : worldPrefabMetadata
	{
		[Ordinal(0)] 
		[RED("lootTableTDBIDs")] 
		public CArray<TweakDBID> LootTableTDBIDs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(1)] 
		[RED("ignoreParentPrefabs")] 
		public CBool IgnoreParentPrefabs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameLootPrefabMetadata()
		{
			LootTableTDBIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
