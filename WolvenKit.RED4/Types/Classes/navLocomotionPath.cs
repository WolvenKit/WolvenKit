using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navLocomotionPath : ISerializable
	{
		[Ordinal(0)] 
		[RED("splineNodeRef")] 
		public NodeRef SplineNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("segments")] 
		public CArray<navLocomotionPathSegmentInfo> Segments
		{
			get => GetPropertyValue<CArray<navLocomotionPathSegmentInfo>>();
			set => SetPropertyValue<CArray<navLocomotionPathSegmentInfo>>(value);
		}

		[Ordinal(2)] 
		[RED("backwardSegments")] 
		public CArray<navLocomotionPathSegmentInfo> BackwardSegments
		{
			get => GetPropertyValue<CArray<navLocomotionPathSegmentInfo>>();
			set => SetPropertyValue<CArray<navLocomotionPathSegmentInfo>>(value);
		}

		[Ordinal(3)] 
		[RED("points")] 
		public CArray<navLocomotionPathPointInfo> Points
		{
			get => GetPropertyValue<CArray<navLocomotionPathPointInfo>>();
			set => SetPropertyValue<CArray<navLocomotionPathPointInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("userData")] 
		public CArray<navLocomotionPathPointUserDataEntry> UserData
		{
			get => GetPropertyValue<CArray<navLocomotionPathPointUserDataEntry>>();
			set => SetPropertyValue<CArray<navLocomotionPathPointUserDataEntry>>(value);
		}

		public navLocomotionPath()
		{
			Segments = new();
			BackwardSegments = new();
			Points = new();
			UserData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
