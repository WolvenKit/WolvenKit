using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entFogVolumeComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("densityFalloff")] public CFloat DensityFalloff { get; set; }
		[Ordinal(9)] [RED("blendFalloff")] public CFloat BlendFalloff { get; set; }
		[Ordinal(10)] [RED("densityFactor")] public CFloat DensityFactor { get; set; }
		[Ordinal(11)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(12)] [RED("absorption")] public CFloat Absorption { get; set; }
		[Ordinal(13)] [RED("size")] public Vector3 Size { get; set; }
		[Ordinal(14)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public entFogVolumeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
