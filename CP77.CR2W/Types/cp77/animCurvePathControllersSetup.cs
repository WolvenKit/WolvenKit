using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animCurvePathControllersSetup : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("startControllerName")] public CName StartControllerName { get; set; }
		[Ordinal(2)] [RED("mainControllerName")] public CName MainControllerName { get; set; }
		[Ordinal(3)] [RED("stopControllerName")] public CName StopControllerName { get; set; }

		public animCurvePathControllersSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
