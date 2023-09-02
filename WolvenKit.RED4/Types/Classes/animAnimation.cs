using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimation : ISerializable
	{
		[Ordinal(0)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("animationType")] 
		public CEnum<animAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<animAnimationType>>();
			set => SetPropertyValue<CEnum<animAnimationType>>(value);
		}

		[Ordinal(4)] 
		[RED("animBuffer")] 
		public CHandle<animIAnimationBuffer> AnimBuffer
		{
			get => GetPropertyValue<CHandle<animIAnimationBuffer>>();
			set => SetPropertyValue<CHandle<animIAnimationBuffer>>(value);
		}

		[Ordinal(5)] 
		[RED("additionalTransforms")] 
		public animAdditionalTransformContainer AdditionalTransforms
		{
			get => GetPropertyValue<animAdditionalTransformContainer>();
			set => SetPropertyValue<animAdditionalTransformContainer>(value);
		}

		[Ordinal(6)] 
		[RED("additionalTracks")] 
		public animAdditionalFloatTrackContainer AdditionalTracks
		{
			get => GetPropertyValue<animAdditionalFloatTrackContainer>();
			set => SetPropertyValue<animAdditionalFloatTrackContainer>(value);
		}

		[Ordinal(7)] 
		[RED("motionExtraction")] 
		public CHandle<animIMotionExtraction> MotionExtraction
		{
			get => GetPropertyValue<CHandle<animIMotionExtraction>>();
			set => SetPropertyValue<CHandle<animIMotionExtraction>>(value);
		}

		[Ordinal(8)] 
		[RED("frameClamping")] 
		public CBool FrameClamping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("frameClampingStartFrame")] 
		public CInt8 FrameClampingStartFrame
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(10)] 
		[RED("frameClampingEndFrame")] 
		public CInt8 FrameClampingEndFrame
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		public animAnimation()
		{
			Tags = new redTagList { Tags = new() };
			AdditionalTransforms = new animAdditionalTransformContainer { Entries = new() };
			AdditionalTracks = new animAdditionalFloatTrackContainer { Entries = new(), OverwriteExistingValues = true };
			FrameClampingStartFrame = -1;
			FrameClampingEndFrame = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
