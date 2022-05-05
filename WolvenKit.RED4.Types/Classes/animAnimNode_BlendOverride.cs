using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendOverride : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
		[RED("overrideInputNode")] 
		public animPoseLink OverrideInputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(13)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(14)] 
		[RED("bones")] 
		public CArray<animOverrideBlendBoneInfo> Bones
		{
			get => GetPropertyValue<CArray<animOverrideBlendBoneInfo>>();
			set => SetPropertyValue<CArray<animOverrideBlendBoneInfo>>(value);
		}

		[Ordinal(15)] 
		[RED("blendAllTracks")] 
		public CBool BlendAllTracks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("blendTrackMode")] 
		public CEnum<animEBlendTracksMode> BlendTrackMode
		{
			get => GetPropertyValue<CEnum<animEBlendTracksMode>>();
			set => SetPropertyValue<CEnum<animEBlendTracksMode>>(value);
		}

		[Ordinal(17)] 
		[RED("tracks")] 
		public CArray<animOverrideBlendTrackInfo> Tracks
		{
			get => GetPropertyValue<CArray<animOverrideBlendTrackInfo>>();
			set => SetPropertyValue<CArray<animOverrideBlendTrackInfo>>(value);
		}

		[Ordinal(18)] 
		[RED("getDeltaMotionFromOverride")] 
		public CBool GetDeltaMotionFromOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetPropertyValue<CHandle<animISyncMethod>>();
			set => SetPropertyValue<CHandle<animISyncMethod>>(value);
		}

		[Ordinal(21)] 
		[RED("blendMethod")] 
		public CHandle<animIPoseBlendMethod> BlendMethod
		{
			get => GetPropertyValue<CHandle<animIPoseBlendMethod>>();
			set => SetPropertyValue<CHandle<animIPoseBlendMethod>>(value);
		}

		[Ordinal(22)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get => GetPropertyValue<CHandle<animIAnimNode_PostProcess>>();
			set => SetPropertyValue<CHandle<animIAnimNode_PostProcess>>(value);
		}

		public animAnimNode_BlendOverride()
		{
			Id = 4294967295;
			InputNode = new();
			OverrideInputNode = new();
			WeightNode = new();
			Bones = new();
			BlendAllTracks = true;
			BlendTrackMode = Enums.animEBlendTracksMode.AGBT_Interpolate;
			Tracks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
