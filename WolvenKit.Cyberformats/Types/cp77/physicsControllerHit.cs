using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsControllerHit : CVariable
	{
		[Ordinal(0)] [RED("worldPos")] public Vector4 WorldPos { get; set; }
		[Ordinal(1)] [RED("worldNormal")] public Vector4 WorldNormal { get; set; }

		public physicsControllerHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
