using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimGraph : CResource
	{
		[Ordinal(0)]  [RED("additionalAnimDatabases")] public CArray<animAnimDatabaseCollectionEntry> AdditionalAnimDatabases { get; set; }
		[Ordinal(1)]  [RED("animFeatures")] public CArray<animAnimFeatureEntry> AnimFeatures { get; set; }
		[Ordinal(2)]  [RED("hackAlwaysSample")] public CBool HackAlwaysSample { get; set; }
		[Ordinal(3)]  [RED("hasMixerSlot")] public CBool HasMixerSlot { get; set; }
		[Ordinal(4)]  [RED("isPaused")] public CBool IsPaused { get; set; }
		[Ordinal(5)]  [RED("nodesToInit")] public CArray<CHandle<animAnimNode_Base>> NodesToInit { get; set; }
		[Ordinal(6)]  [RED("oneFrameToggle")] public CBool OneFrameToggle { get; set; }
		[Ordinal(7)]  [RED("rootNode")] public CHandle<animAnimNode_Root> RootNode { get; set; }
		[Ordinal(8)]  [RED("staticCommandsRig")] public rRef<animRig> StaticCommandsRig { get; set; }
		[Ordinal(9)]  [RED("timeDeltaMultiplier")] public CFloat TimeDeltaMultiplier { get; set; }
		[Ordinal(10)]  [RED("useAnimCommands")] public CBool UseAnimCommands { get; set; }
		[Ordinal(11)]  [RED("useAnimCommandsForCrowd")] public CBool UseAnimCommandsForCrowd { get; set; }
		[Ordinal(12)]  [RED("useAnimStaticCommands")] public CBool UseAnimStaticCommands { get; set; }
		[Ordinal(13)]  [RED("useLunaticMode")] public CBool UseLunaticMode { get; set; }
		[Ordinal(14)]  [RED("variables")] public CHandle<animAnimVariableContainer> Variables { get; set; }

		[Ordinal(999)]  [RED("jsonFilesDirectory")] public CString jsonFilesDirectory { get; set; }

		public animAnimGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
