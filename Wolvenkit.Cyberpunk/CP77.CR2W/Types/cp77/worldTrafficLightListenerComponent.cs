using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLightListenerComponent : entIComponent
	{
		[Ordinal(0)]  [RED("groupIdx")] public CUInt32 GroupIdx { get; set; }
		[Ordinal(1)]  [RED("intersectionRef")] public NodeRef IntersectionRef { get; set; }

		public worldTrafficLightListenerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
