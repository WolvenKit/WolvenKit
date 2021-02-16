using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_WeaponUser : animAnimFeature
	{
		[Ordinal(0)] [RED("ikLeftHandLocalPosition")] public Vector4 IkLeftHandLocalPosition { get; set; }
		[Ordinal(1)] [RED("ikRightHandLocalPosition")] public Vector4 IkRightHandLocalPosition { get; set; }

		public animAnimFeature_WeaponUser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
