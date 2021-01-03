using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BloomAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("bloomColorScale")] public CFloat BloomColorScale { get; set; }
		[Ordinal(1)]  [RED("luminanceThresholdMax")] public CFloat LuminanceThresholdMax { get; set; }
		[Ordinal(2)]  [RED("luminanceThresholdMin")] public CFloat LuminanceThresholdMin { get; set; }
		[Ordinal(3)]  [RED("numDownsamplePasses")] public CUInt8 NumDownsamplePasses { get; set; }
		[Ordinal(4)]  [RED("sceneColorScale")] public CFloat SceneColorScale { get; set; }
		[Ordinal(5)]  [RED("shaftsAreaSettings")] public ShaftsAreaSettings ShaftsAreaSettings { get; set; }

		public BloomAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
