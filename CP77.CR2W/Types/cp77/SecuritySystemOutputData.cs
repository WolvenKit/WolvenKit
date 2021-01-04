using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemOutputData : CVariable
	{
		[Ordinal(0)]  [RED("breachOrigin")] public CEnum<EBreachOrigin> BreachOrigin { get; set; }
		[Ordinal(1)]  [RED("delayDuration")] public CFloat DelayDuration { get; set; }
		[Ordinal(2)]  [RED("link")] public DeviceLink Link { get; set; }

		public SecuritySystemOutputData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
