using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entLightBlockingComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(9)] [RED("lightBlockerComponentVersion")] public CUInt8 LightBlockerComponentVersion { get; set; }

		public entLightBlockingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
