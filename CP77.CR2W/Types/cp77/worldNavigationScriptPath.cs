using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptPath : IScriptable
	{
		[Ordinal(0)] [RED("path")] public CArray<Vector4> Path { get; set; }

		public worldNavigationScriptPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
