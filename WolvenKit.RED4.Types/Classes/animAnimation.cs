using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimation : ISerializable
	{
		private redTagList _tags;
		private CName _name;
		private CFloat _duration;
		private CEnum<animAnimationType> _animationType;
		private CHandle<animIAnimationBuffer> _animBuffer;
		private animAdditionalTransformContainer _additionalTransforms;
		private animAdditionalFloatTrackContainer _additionalTracks;
		private CHandle<animIMotionExtraction> _motionExtraction;
		private CBool _frameClamping;
		private CInt8 _frameClampingStartFrame;
		private CInt8 _frameClampingEndFrame;

		[Ordinal(0)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("animationType")] 
		public CEnum<animAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(4)] 
		[RED("animBuffer")] 
		public CHandle<animIAnimationBuffer> AnimBuffer
		{
			get => GetProperty(ref _animBuffer);
			set => SetProperty(ref _animBuffer, value);
		}

		[Ordinal(5)] 
		[RED("additionalTransforms")] 
		public animAdditionalTransformContainer AdditionalTransforms
		{
			get => GetProperty(ref _additionalTransforms);
			set => SetProperty(ref _additionalTransforms, value);
		}

		[Ordinal(6)] 
		[RED("additionalTracks")] 
		public animAdditionalFloatTrackContainer AdditionalTracks
		{
			get => GetProperty(ref _additionalTracks);
			set => SetProperty(ref _additionalTracks, value);
		}

		[Ordinal(7)] 
		[RED("motionExtraction")] 
		public CHandle<animIMotionExtraction> MotionExtraction
		{
			get => GetProperty(ref _motionExtraction);
			set => SetProperty(ref _motionExtraction, value);
		}

		[Ordinal(8)] 
		[RED("frameClamping")] 
		public CBool FrameClamping
		{
			get => GetProperty(ref _frameClamping);
			set => SetProperty(ref _frameClamping, value);
		}

		[Ordinal(9)] 
		[RED("frameClampingStartFrame")] 
		public CInt8 FrameClampingStartFrame
		{
			get => GetProperty(ref _frameClampingStartFrame);
			set => SetProperty(ref _frameClampingStartFrame, value);
		}

		[Ordinal(10)] 
		[RED("frameClampingEndFrame")] 
		public CInt8 FrameClampingEndFrame
		{
			get => GetProperty(ref _frameClampingEndFrame);
			set => SetProperty(ref _frameClampingEndFrame, value);
		}

		public animAnimation()
		{
			_frameClampingStartFrame = -1;
			_frameClampingEndFrame = -1;
		}
	}
}
