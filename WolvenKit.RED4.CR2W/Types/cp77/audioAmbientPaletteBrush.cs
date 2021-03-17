using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientPaletteBrush : CVariable
	{
		private CFloat _distributionBucketSize;
		private CFloat _virtualHearingRadius;
		private CFloat _hearingDistanceCooldown;
		private CArray<CName> _eventsPool;
		private CName _radioStationMetadata;

		[Ordinal(0)] 
		[RED("distributionBucketSize")] 
		public CFloat DistributionBucketSize
		{
			get => GetProperty(ref _distributionBucketSize);
			set => SetProperty(ref _distributionBucketSize, value);
		}

		[Ordinal(1)] 
		[RED("virtualHearingRadius")] 
		public CFloat VirtualHearingRadius
		{
			get => GetProperty(ref _virtualHearingRadius);
			set => SetProperty(ref _virtualHearingRadius, value);
		}

		[Ordinal(2)] 
		[RED("hearingDistanceCooldown")] 
		public CFloat HearingDistanceCooldown
		{
			get => GetProperty(ref _hearingDistanceCooldown);
			set => SetProperty(ref _hearingDistanceCooldown, value);
		}

		[Ordinal(3)] 
		[RED("eventsPool")] 
		public CArray<CName> EventsPool
		{
			get => GetProperty(ref _eventsPool);
			set => SetProperty(ref _eventsPool, value);
		}

		[Ordinal(4)] 
		[RED("radioStationMetadata")] 
		public CName RadioStationMetadata
		{
			get => GetProperty(ref _radioStationMetadata);
			set => SetProperty(ref _radioStationMetadata, value);
		}

		public audioAmbientPaletteBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
