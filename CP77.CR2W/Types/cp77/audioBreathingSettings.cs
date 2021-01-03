using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioBreathingSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("exhaustionRtpc")] public CName ExhaustionRtpc { get; set; }
		[Ordinal(1)]  [RED("idleFadeOutRtpc")] public CName IdleFadeOutRtpc { get; set; }
		[Ordinal(2)]  [RED("initialState")] public CName InitialState { get; set; }

		public audioBreathingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
