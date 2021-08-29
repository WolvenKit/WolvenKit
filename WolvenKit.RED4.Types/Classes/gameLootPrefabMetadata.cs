using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootPrefabMetadata : worldPrefabMetadata
	{
		private CArray<TweakDBID> _lootTableTDBIDs;
		private CBool _ignoreParentPrefabs;
		private TweakDBID _contentAssignment;

		[Ordinal(0)] 
		[RED("lootTableTDBIDs")] 
		public CArray<TweakDBID> LootTableTDBIDs
		{
			get => GetProperty(ref _lootTableTDBIDs);
			set => SetProperty(ref _lootTableTDBIDs, value);
		}

		[Ordinal(1)] 
		[RED("ignoreParentPrefabs")] 
		public CBool IgnoreParentPrefabs
		{
			get => GetProperty(ref _ignoreParentPrefabs);
			set => SetProperty(ref _ignoreParentPrefabs, value);
		}

		[Ordinal(2)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get => GetProperty(ref _contentAssignment);
			set => SetProperty(ref _contentAssignment, value);
		}
	}
}
