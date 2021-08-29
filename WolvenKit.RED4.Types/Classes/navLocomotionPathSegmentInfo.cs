using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class navLocomotionPathSegmentInfo : RedBaseClass
	{
		private CEnum<navLocomotionPathSegmentTypes> _type;
		private navSerializableSplineProgression _segmentEnd;
		private CUInt64 _offMeshLink;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<navLocomotionPathSegmentTypes> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("segmentEnd")] 
		public navSerializableSplineProgression SegmentEnd
		{
			get => GetProperty(ref _segmentEnd);
			set => SetProperty(ref _segmentEnd, value);
		}

		[Ordinal(2)] 
		[RED("offMeshLink")] 
		public CUInt64 OffMeshLink
		{
			get => GetProperty(ref _offMeshLink);
			set => SetProperty(ref _offMeshLink, value);
		}
	}
}
