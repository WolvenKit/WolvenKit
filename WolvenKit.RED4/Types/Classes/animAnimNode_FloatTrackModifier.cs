using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatTrackModifier : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CEnum<animFloatTrackOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<animFloatTrackOperationType>>();
			set => SetPropertyValue<CEnum<animFloatTrackOperationType>>(value);
		}

		[Ordinal(3)] 
		[RED("inputFloatTrack")] 
		public animNamedTrackIndex InputFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(4)] 
		[RED("poseInputNode")] 
		public animPoseLink PoseInputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(5)] 
		[RED("floatInputNode")] 
		public animFloatLink FloatInputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatTrackModifier()
		{
			Id = uint.MaxValue;
			FloatTrack = new animNamedTrackIndex();
			InputFloatTrack = new animNamedTrackIndex();
			PoseInputNode = new animPoseLink();
			FloatInputNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
