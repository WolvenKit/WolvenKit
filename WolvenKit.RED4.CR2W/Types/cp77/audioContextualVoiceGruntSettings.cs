using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualVoiceGruntSettings : CVariable
	{
		[Ordinal(0)] [RED("painShort")] public audioContextualVoiceGrunt PainShort { get; set; }
		[Ordinal(1)] [RED("effort")] public audioContextualVoiceGrunt Effort { get; set; }

		public audioContextualVoiceGruntSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
