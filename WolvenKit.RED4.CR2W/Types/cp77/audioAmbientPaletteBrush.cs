using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientPaletteBrush : CVariable
	{
		[Ordinal(0)] [RED("distributionBucketSize")] public CFloat DistributionBucketSize { get; set; }
		[Ordinal(1)] [RED("virtualHearingRadius")] public CFloat VirtualHearingRadius { get; set; }
		[Ordinal(2)] [RED("hearingDistanceCooldown")] public CFloat HearingDistanceCooldown { get; set; }
		[Ordinal(3)] [RED("eventsPool")] public CArray<CName> EventsPool { get; set; }
		[Ordinal(4)] [RED("radioStationMetadata")] public CName RadioStationMetadata { get; set; }

		public audioAmbientPaletteBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
