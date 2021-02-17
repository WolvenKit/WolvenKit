using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterCube : CMaterialParameter
	{
		[Ordinal(2)] [RED("texture")] public rRef<ITexture> Texture { get; set; }

		public CMaterialParameterCube(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
