using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCurvePathAnimControllerPreset : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("leftAnimationName")] public CName LeftAnimationName { get; set; }
		[Ordinal(2)] [RED("forwardAnimationName")] public CName ForwardAnimationName { get; set; }
		[Ordinal(3)] [RED("rightAnimationName")] public CName RightAnimationName { get; set; }

		public animCurvePathAnimControllerPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
