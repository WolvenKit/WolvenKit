using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BloomAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("luminanceThresholdMin")] public CFloat LuminanceThresholdMin { get; set; }
		[Ordinal(1)]  [RED("luminanceThresholdMax")] public CFloat LuminanceThresholdMax { get; set; }
		[Ordinal(2)]  [RED("sceneColorScale")] public CFloat SceneColorScale { get; set; }
		[Ordinal(3)]  [RED("bloomColorScale")] public CFloat BloomColorScale { get; set; }
		[Ordinal(4)]  [RED("numDownsamplePasses")] public CUInt8 NumDownsamplePasses { get; set; }
		[Ordinal(5)]  [RED("shaftsAreaSettings")] public ShaftsAreaSettings ShaftsAreaSettings { get; set; }

		public BloomAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
