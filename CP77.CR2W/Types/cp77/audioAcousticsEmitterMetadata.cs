using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAcousticsEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(0)]  [RED("obstuctionEnabled")] public CBool ObstuctionEnabled { get; set; }
		[Ordinal(1)]  [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(2)]  [RED("repositioningEnabled")] public CBool RepositioningEnabled { get; set; }
		[Ordinal(3)]  [RED("obstructionFadeTime")] public CFloat ObstructionFadeTime { get; set; }
		[Ordinal(4)]  [RED("enableOutdoorness")] public CBool EnableOutdoorness { get; set; }
		[Ordinal(5)]  [RED("postDopplerFactor")] public CBool PostDopplerFactor { get; set; }
		[Ordinal(6)]  [RED("dopplerParameter")] public CName DopplerParameter { get; set; }
		[Ordinal(7)]  [RED("ignoreOcclusionRadius")] public CFloat IgnoreOcclusionRadius { get; set; }
		[Ordinal(8)]  [RED("elevateSource")] public CBool ElevateSource { get; set; }

		public audioAcousticsEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
