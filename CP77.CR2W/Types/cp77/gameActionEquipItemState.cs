using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameActionEquipItemState : gameActionReplicatedState
	{
		[Ordinal(0)]  [RED("animFeatureNameLeft")] public CName AnimFeatureNameLeft { get; set; }
		[Ordinal(1)]  [RED("animFeatureNameRight")] public CName AnimFeatureNameRight { get; set; }
		[Ordinal(2)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)]  [RED("itemId")] public gameItemID ItemId { get; set; }
		[Ordinal(4)]  [RED("slotId")] public TweakDBID SlotId { get; set; }
		[Ordinal(5)]  [RED("spawnDelay")] public CFloat SpawnDelay { get; set; }

		public gameActionEquipItemState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
