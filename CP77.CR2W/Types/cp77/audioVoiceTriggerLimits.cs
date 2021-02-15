using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerLimits : CVariable
	{
		[Ordinal(0)] [RED("probability")] public CFloat Probability { get; set; }
		[Ordinal(1)] [RED("singleNpcMinRepeatTime")] public CFloat SingleNpcMinRepeatTime { get; set; }
		[Ordinal(2)] [RED("allNpcsMinRepeatTime")] public CFloat AllNpcsMinRepeatTime { get; set; }
		[Ordinal(3)] [RED("allNpcsSharingVoicesetMinRepeatTime")] public CFloat AllNpcsSharingVoicesetMinRepeatTime { get; set; }
		[Ordinal(4)] [RED("combatVolume")] public CFloat CombatVolume { get; set; }

		public audioVoiceTriggerLimits(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
