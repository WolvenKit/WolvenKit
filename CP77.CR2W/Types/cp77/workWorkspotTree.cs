using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workWorkspotTree : ISerializable
	{
		[Ordinal(0)]  [RED("rootEntry")] public CHandle<workIEntry> RootEntry { get; set; }
		[Ordinal(1)]  [RED("idCounter")] public CUInt32 IdCounter { get; set; }
		[Ordinal(2)]  [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(3)]  [RED("customTransitionAnims")] public CArray<workTransitionAnim> CustomTransitionAnims { get; set; }
		[Ordinal(4)]  [RED("workspotRig")] public raRef<animRig> WorkspotRig { get; set; }
		[Ordinal(5)]  [RED("availableRigSlots")] public CArray<CName> AvailableRigSlots { get; set; }
		[Ordinal(6)]  [RED("availablePropIds")] public CArray<CName> AvailablePropIds { get; set; }
		[Ordinal(7)]  [RED("globalProps")] public CArray<workWorkspotGlobalProp> GlobalProps { get; set; }
		[Ordinal(8)]  [RED("initialActions")] public CArray<CHandle<workIWorkspotItemAction>> InitialActions { get; set; }
		[Ordinal(9)]  [RED("dontInjectWorkspotGraph")] public CBool DontInjectWorkspotGraph { get; set; }
		[Ordinal(10)]  [RED("frezeAtTheLastFrame_UseWithCaution")] public CBool FrezeAtTheLastFrame_UseWithCaution { get; set; }
		[Ordinal(11)]  [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
		[Ordinal(12)]  [RED("animGraphSlotName")] public CName AnimGraphSlotName { get; set; }
		[Ordinal(13)]  [RED("inertializationDurationEnter")] public CFloat InertializationDurationEnter { get; set; }
		[Ordinal(14)]  [RED("inertializationDurationExitNatural")] public CFloat InertializationDurationExitNatural { get; set; }
		[Ordinal(15)]  [RED("inertializationDurationExitForced")] public CFloat InertializationDurationExitForced { get; set; }
		[Ordinal(16)]  [RED("finalAnimsets")] public CArray<workWorkspotAnimsetEntry> FinalAnimsets { get; set; }
		[Ordinal(17)]  [RED("autoTransitionBlendTime")] public CFloat AutoTransitionBlendTime { get; set; }
		[Ordinal(18)]  [RED("whitelistVisualTags")] public redTagList WhitelistVisualTags { get; set; }
		[Ordinal(19)]  [RED("blacklistVisualTags")] public redTagList BlacklistVisualTags { get; set; }
		[Ordinal(20)]  [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
		[Ordinal(21)]  [RED("animsets")] public CArray<workWorkspotAnimsetEntry> Animsets { get; set; }
		[Ordinal(22)]  [RED("hasEntityPathsGenerated")] public CBool HasEntityPathsGenerated { get; set; }
		[Ordinal(23)]  [RED("entitiesPaths")] public CArray<CName> EntitiesPaths { get; set; }
		[Ordinal(24)]  [RED("disableAutoAnimsetGeneraion")] public CBool DisableAutoAnimsetGeneraion { get; set; }
		[Ordinal(25)]  [RED("useTimeLimitForSequences")] public CBool UseTimeLimitForSequences { get; set; }
		[Ordinal(26)]  [RED("sequencesTimeLimit")] public CFloat SequencesTimeLimit { get; set; }
		[Ordinal(27)]  [RED("snapToTerrain")] public CBool SnapToTerrain { get; set; }
		[Ordinal(28)]  [RED("unmountBodyCarry")] public CBool UnmountBodyCarry { get; set; }
		[Ordinal(29)]  [RED("censorshipFlags")] public CEnum<CensorshipFlags> CensorshipFlags { get; set; }
		[Ordinal(30)]  [RED("itemsPolicy")] public CEnum<workWorkspotItemPolicy> ItemsPolicy { get; set; }

		public workWorkspotTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
