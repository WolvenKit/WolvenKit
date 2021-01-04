using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Rotation_CurrentRotation : gameTransformAnimation_Rotation
	{
		[Ordinal(0)]  [RED("offset")] public Quaternion Offset { get; set; }

		public gameTransformAnimation_Rotation_CurrentRotation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
