using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Reprimand : animAnimFeature
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }
		[Ordinal(1)] [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(2)] [RED("isLocomotion")] public CBool IsLocomotion { get; set; }
		[Ordinal(3)] [RED("weaponType")] public CInt32 WeaponType { get; set; }

		public AnimFeature_Reprimand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
