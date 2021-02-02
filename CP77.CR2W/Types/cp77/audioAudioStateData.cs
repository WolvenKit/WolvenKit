using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioStateData : CVariable
	{
		[Ordinal(0)]  [RED("stateName")] public CName StateName { get; set; }
		[Ordinal(1)]  [RED("enterEvent")] public CName EnterEvent { get; set; }
		[Ordinal(2)]  [RED("exitEvent")] public CName ExitEvent { get; set; }
		[Ordinal(3)]  [RED("exitTransitions")] public CArray<audioAudioStateTransitionData> ExitTransitions { get; set; }
		[Ordinal(4)]  [RED("mixingActions")] public CArray<audioMixingActionData> MixingActions { get; set; }
		[Ordinal(5)]  [RED("interruptionSources")] public CArray<CName> InterruptionSources { get; set; }
		[Ordinal(6)]  [RED("writeVariableActions")] public CArray<audioAudioSceneVariableWriteActionData> WriteVariableActions { get; set; }

		public audioAudioStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
