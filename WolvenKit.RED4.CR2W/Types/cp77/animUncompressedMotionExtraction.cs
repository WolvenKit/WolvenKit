using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animUncompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)] [RED("frames")] public CArray<Vector4> Frames { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }

		public animUncompressedMotionExtraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
