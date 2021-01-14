using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpGameplayLightComponent : entLightComponent
	{
		[Ordinal(0)]  [RED("begin")] public GameTime Begin { get; set; }
		[Ordinal(1)]  [RED("delayRange")] public GameTime DelayRange { get; set; }
		[Ordinal(2)]  [RED("end")] public GameTime End { get; set; }
		[Ordinal(3)]  [RED("probability")] public CFloat Probability { get; set; }
		[Ordinal(4)]  [RED("reactToTime")] public CBool ReactToTime { get; set; }

		public cpGameplayLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
