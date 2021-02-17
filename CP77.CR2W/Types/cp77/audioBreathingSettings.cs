using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioBreathingSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("exhaustionRtpc")] public CName ExhaustionRtpc { get; set; }
		[Ordinal(2)] [RED("idleFadeOutRtpc")] public CName IdleFadeOutRtpc { get; set; }
		[Ordinal(3)] [RED("initialState")] public CName InitialState { get; set; }

		public audioBreathingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
