using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EmitterDurationSettings : CVariable
	{
		[Ordinal(0)]  [RED("emitterDuration")] public CFloat EmitterDuration { get; set; }
		[Ordinal(1)]  [RED("emitterDurationLow")] public CFloat EmitterDurationLow { get; set; }
		[Ordinal(2)]  [RED("useEmitterDurationRange")] public CBool UseEmitterDurationRange { get; set; }

		public EmitterDurationSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
