using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendAdditive : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("biasValue")] 
		public CFloat BiasValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("scaleValue")] 
		public CFloat ScaleValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("additiveType")] 
		public CEnum<animEAnimGraphAdditiveType> AdditiveType
		{
			get => GetPropertyValue<CEnum<animEAnimGraphAdditiveType>>();
			set => SetPropertyValue<CEnum<animEAnimGraphAdditiveType>>(value);
		}

		[Ordinal(14)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("blendTracks")] 
		public CEnum<animEBlendTracksMode> BlendTracks
		{
			get => GetPropertyValue<CEnum<animEBlendTracksMode>>();
			set => SetPropertyValue<CEnum<animEBlendTracksMode>>(value);
		}

		[Ordinal(16)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetPropertyValue<CHandle<animISyncMethod>>();
			set => SetPropertyValue<CHandle<animISyncMethod>>(value);
		}

		[Ordinal(17)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(18)] 
		[RED("addedInputNode")] 
		public animPoseLink AddedInputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(19)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(20)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get => GetPropertyValue<CHandle<animIAnimNode_PostProcess>>();
			set => SetPropertyValue<CHandle<animIAnimNode_PostProcess>>(value);
		}

		[Ordinal(21)] 
		[RED("weightPreviousFrameFloatTrack")] 
		public animNamedTrackIndex WeightPreviousFrameFloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(22)] 
		[RED("weightPreviousFrameFloatTrackDefaultValue")] 
		public CFloat WeightPreviousFrameFloatTrackDefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("maskName")] 
		public CName MaskName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_BlendAdditive()
		{
			Id = 4294967295;
			ScaleValue = 1.000000F;
			BlendTracks = Enums.animEBlendTracksMode.AGBT_Add;
			InputNode = new();
			AddedInputNode = new();
			WeightNode = new();
			WeightPreviousFrameFloatTrack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
