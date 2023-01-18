using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navLocomotionPathSegmentInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<navLocomotionPathSegmentTypes> Type
		{
			get => GetPropertyValue<CEnum<navLocomotionPathSegmentTypes>>();
			set => SetPropertyValue<CEnum<navLocomotionPathSegmentTypes>>(value);
		}

		[Ordinal(1)] 
		[RED("segmentEnd")] 
		public navSerializableSplineProgression SegmentEnd
		{
			get => GetPropertyValue<navSerializableSplineProgression>();
			set => SetPropertyValue<navSerializableSplineProgression>(value);
		}

		[Ordinal(2)] 
		[RED("offMeshLink")] 
		public CUInt64 OffMeshLink
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public navLocomotionPathSegmentInfo()
		{
			SegmentEnd = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
