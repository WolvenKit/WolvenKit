using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendAdditive : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("biasValue")] 
		public CFloat BiasValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("scaleValue")] 
		public CFloat ScaleValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("additiveType")] 
		public CEnum<animEAnimGraphAdditiveType> AdditiveType
		{
			get => GetPropertyValue<CEnum<animEAnimGraphAdditiveType>>();
			set => SetPropertyValue<CEnum<animEAnimGraphAdditiveType>>(value);
		}

		[Ordinal(4)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("blendTracks")] 
		public CEnum<animEBlendTracksMode> BlendTracks
		{
			get => GetPropertyValue<CEnum<animEBlendTracksMode>>();
			set => SetPropertyValue<CEnum<animEBlendTracksMode>>(value);
		}

		[Ordinal(6)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetPropertyValue<CHandle<animISyncMethod>>();
			set => SetPropertyValue<CHandle<animISyncMethod>>(value);
		}

		[Ordinal(7)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(8)] 
		[RED("addedInputNode")] 
		public animPoseLink AddedInputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(9)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(10)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get => GetPropertyValue<CHandle<animIAnimNode_PostProcess>>();
			set => SetPropertyValue<CHandle<animIAnimNode_PostProcess>>(value);
		}

		[Ordinal(11)] 
		[RED("weightPreviousFrameFloatTrack")] 
		public animNamedTrackIndex WeightPreviousFrameFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(12)] 
		[RED("weightPreviousFrameFloatTrackDefaultValue")] 
		public CFloat WeightPreviousFrameFloatTrackDefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("maskName")] 
		public CName MaskName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_BlendAdditive()
		{
			Id = uint.MaxValue;
			ScaleValue = 1.000000F;
			BlendTracks = Enums.animEBlendTracksMode.AGBT_Add;
			InputNode = new animPoseLink();
			AddedInputNode = new animPoseLink();
			WeightNode = new animFloatLink();
			WeightPreviousFrameFloatTrack = new animNamedTrackIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
