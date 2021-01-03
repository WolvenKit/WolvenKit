using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkPointCloudEffect : inkIEffect
	{
		[Ordinal(0)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("depthToBrightness")] public CFloat DepthToBrightness { get; set; }
		[Ordinal(2)]  [RED("depthToOpacity")] public CFloat DepthToOpacity { get; set; }
		[Ordinal(3)]  [RED("fovScale")] public CFloat FovScale { get; set; }
		[Ordinal(4)]  [RED("offsetX")] public CFloat OffsetX { get; set; }
		[Ordinal(5)]  [RED("offsetY")] public CFloat OffsetY { get; set; }
		[Ordinal(6)]  [RED("parallaxDepth")] public CFloat ParallaxDepth { get; set; }
		[Ordinal(7)]  [RED("repeat")] public CFloat Repeat { get; set; }

		public inkPointCloudEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
