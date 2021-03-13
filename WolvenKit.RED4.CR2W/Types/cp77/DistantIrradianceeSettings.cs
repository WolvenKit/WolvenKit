using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantIrradianceeSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("distantRange")] public curveData<Vector2> DistantRange { get; set; }
		[Ordinal(3)] [RED("distantHeightRange")] public curveData<Vector3> DistantHeightRange { get; set; }
		[Ordinal(4)] [RED("distantLights")] public curveData<CFloat> DistantLights { get; set; }
		[Ordinal(5)] [RED("distantLightsRange")] public curveData<Vector2> DistantLightsRange { get; set; }
		[Ordinal(6)] [RED("blendDistance")] public curveData<CFloat> BlendDistance { get; set; }

		public DistantIrradianceeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
