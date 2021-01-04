using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterVector : CMaterialParameter
	{
		[Ordinal(0)]  [RED("vector")] public Vector4 Vector { get; set; }

		public CMaterialParameterVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
