using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeIKData : animAnimFeature
	{
		[Ordinal(0)]  [RED("isValid")] public CBool IsValid { get; set; }
		[Ordinal(1)]  [RED("headPosition")] public Vector4 HeadPosition { get; set; }
		[Ordinal(2)]  [RED("chestPosition")] public Vector4 ChestPosition { get; set; }
		[Ordinal(3)]  [RED("ikOffset")] public Vector4 IkOffset { get; set; }

		public animAnimFeature_MeleeIKData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
