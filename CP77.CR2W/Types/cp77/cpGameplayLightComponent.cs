using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpGameplayLightComponent : entLightComponent
	{
		[Ordinal(54)] [RED("reactToTime")] public CBool ReactToTime { get; set; }
		[Ordinal(55)] [RED("begin")] public GameTime Begin { get; set; }
		[Ordinal(56)] [RED("end")] public GameTime End { get; set; }
		[Ordinal(57)] [RED("probability")] public CFloat Probability { get; set; }
		[Ordinal(58)] [RED("delayRange")] public GameTime DelayRange { get; set; }

		public cpGameplayLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
