using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entStaticOrientationProvider : entIOrientationProvider
	{
		[Ordinal(0)]  [RED("staticOrientation")] public Quaternion StaticOrientation { get; set; }

		public entStaticOrientationProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
