using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldHeatmapSetup : CVariable
	{
		[Ordinal(0)] [RED("volumeBox")] public Box VolumeBox { get; set; }
		[Ordinal(1)] [RED("verticalResolution")] public CUInt32 VerticalResolution { get; set; }
		[Ordinal(2)] [RED("horizontalResolution")] public CUInt32 HorizontalResolution { get; set; }

		public worldHeatmapSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
