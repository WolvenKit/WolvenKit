using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CameraTagLimitData : IScriptable
	{
		[Ordinal(0)] [RED("add")] public CBool Add { get; set; }
		[Ordinal(1)] [RED("object")] public wCHandle<SurveillanceCamera> Object { get; set; }

		public CameraTagLimitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
