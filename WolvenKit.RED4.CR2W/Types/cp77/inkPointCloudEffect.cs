using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPointCloudEffect : inkIEffect
	{
		[Ordinal(2)] [RED("repeat")] public CFloat Repeat { get; set; }
		[Ordinal(3)] [RED("offsetX")] public CFloat OffsetX { get; set; }
		[Ordinal(4)] [RED("offsetY")] public CFloat OffsetY { get; set; }
		[Ordinal(5)] [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(6)] [RED("fovScale")] public CFloat FovScale { get; set; }
		[Ordinal(7)] [RED("parallaxDepth")] public CFloat ParallaxDepth { get; set; }
		[Ordinal(8)] [RED("depthToOpacity")] public CFloat DepthToOpacity { get; set; }
		[Ordinal(9)] [RED("depthToBrightness")] public CFloat DepthToBrightness { get; set; }

		public inkPointCloudEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
