using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldgeometryHandIKDescriptionResult : CVariable
	{
		[Ordinal(0)]  [RED("grabPointEnd")] public Vector4 GrabPointEnd { get; set; }
		[Ordinal(1)]  [RED("grabPointStart")] public Vector4 GrabPointStart { get; set; }

		public worldgeometryHandIKDescriptionResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
