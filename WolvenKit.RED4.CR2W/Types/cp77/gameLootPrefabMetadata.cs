using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootPrefabMetadata : worldPrefabMetadata
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

		public gameLootPrefabMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
