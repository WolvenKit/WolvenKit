using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_IndustrialArm : animAnimFeature
	{
		[Ordinal(0)]  [RED("idleAnimNumber")] public CInt32 IdleAnimNumber { get; set; }
		[Ordinal(1)]  [RED("isDistraction")] public CBool IsDistraction { get; set; }
		[Ordinal(2)]  [RED("isPoke")] public CBool IsPoke { get; set; }
		[Ordinal(3)]  [RED("isRotate")] public CBool IsRotate { get; set; }

		public AnimFeature_IndustrialArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
