using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimationControllerReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("animWrapperVarsState")] public entReplicatedAnimWrapperVars AnimWrapperVarsState { get; set; }
		[Ordinal(1)]  [RED("lookAtReqs_m_replicatedVersionId")] public CUInt32 LookAtReqs_m_replicatedVersionId { get; set; }
		[Ordinal(2)]  [RED("animFeaturesState")] public entReplicatedAnimFeaturesState AnimFeaturesState { get; set; }
		[Ordinal(3)]  [RED("inputSettersState")] public entReplicatedInputSetters InputSettersState { get; set; }

		public entAnimationControllerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
