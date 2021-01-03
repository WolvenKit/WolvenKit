using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeIKData : animAnimFeature
	{
		[Ordinal(0)]  [RED("chestPosition")] public Vector4 ChestPosition { get; set; }
		[Ordinal(1)]  [RED("headPosition")] public Vector4 HeadPosition { get; set; }
		[Ordinal(2)]  [RED("ikOffset")] public Vector4 IkOffset { get; set; }
		[Ordinal(3)]  [RED("isValid")] public CBool IsValid { get; set; }

		public animAnimFeature_MeleeIKData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
