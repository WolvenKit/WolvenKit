using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Rotation_LocalRotation : gameTransformAnimation_Rotation
	{
		[Ordinal(0)] [RED("rotation")] public Quaternion Rotation { get; set; }

		public gameTransformAnimation_Rotation_LocalRotation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
