using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DistantIrradianceeSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("blendDistance")] public curveData<CFloat> BlendDistance { get; set; }
		[Ordinal(1)]  [RED("distantHeightRange")] public curveData<Vector3> DistantHeightRange { get; set; }
		[Ordinal(2)]  [RED("distantLights")] public curveData<CFloat> DistantLights { get; set; }
		[Ordinal(3)]  [RED("distantLightsRange")] public curveData<Vector2> DistantLightsRange { get; set; }
		[Ordinal(4)]  [RED("distantRange")] public curveData<Vector2> DistantRange { get; set; }

		public DistantIrradianceeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
