using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionEquipItemState : gameActionReplicatedState
	{
		[Ordinal(5)] [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(6)] [RED("itemId")] public gameItemID ItemId { get; set; }
		[Ordinal(7)] [RED("animFeatureNameRight")] public CName AnimFeatureNameRight { get; set; }
		[Ordinal(8)] [RED("animFeatureNameLeft")] public CName AnimFeatureNameLeft { get; set; }
		[Ordinal(9)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(10)] [RED("spawnDelay")] public CFloat SpawnDelay { get; set; }

		public gameActionEquipItemState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
