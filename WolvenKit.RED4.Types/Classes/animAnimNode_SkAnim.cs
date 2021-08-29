using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkAnim : animAnimNode_Base
	{
		private CName _animation;
		private CBool _applyMotion;
		private CBool _isLooped;
		private CBool _resume;
		private CBool _collectEvents;
		private CBool _fireAnimLoopEvent;
		private CName _animLoopEventName;
		private CFloat _clipFront;
		private CFloat _clipEnd;
		private CName _clipFrontByEvent;
		private CName _clipEndByEvent;
		private CName _pushDataByTag;
		private CName _popDataByTag;
		private CName _pushSafeCutTag;
		private CBool _convertToAdditive;
		private CHandle<animIMotionTableProvider> _motionProvider;
		private CBool _applyInertializationOnAnimSetSwap;

		[Ordinal(11)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(12)] 
		[RED("applyMotion")] 
		public CBool ApplyMotion
		{
			get => GetProperty(ref _applyMotion);
			set => SetProperty(ref _applyMotion, value);
		}

		[Ordinal(13)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(14)] 
		[RED("resume")] 
		public CBool Resume
		{
			get => GetProperty(ref _resume);
			set => SetProperty(ref _resume, value);
		}

		[Ordinal(15)] 
		[RED("collectEvents")] 
		public CBool CollectEvents
		{
			get => GetProperty(ref _collectEvents);
			set => SetProperty(ref _collectEvents, value);
		}

		[Ordinal(16)] 
		[RED("fireAnimLoopEvent")] 
		public CBool FireAnimLoopEvent
		{
			get => GetProperty(ref _fireAnimLoopEvent);
			set => SetProperty(ref _fireAnimLoopEvent, value);
		}

		[Ordinal(17)] 
		[RED("animLoopEventName")] 
		public CName AnimLoopEventName
		{
			get => GetProperty(ref _animLoopEventName);
			set => SetProperty(ref _animLoopEventName, value);
		}

		[Ordinal(18)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get => GetProperty(ref _clipFront);
			set => SetProperty(ref _clipFront, value);
		}

		[Ordinal(19)] 
		[RED("clipEnd")] 
		public CFloat ClipEnd
		{
			get => GetProperty(ref _clipEnd);
			set => SetProperty(ref _clipEnd, value);
		}

		[Ordinal(20)] 
		[RED("clipFrontByEvent")] 
		public CName ClipFrontByEvent
		{
			get => GetProperty(ref _clipFrontByEvent);
			set => SetProperty(ref _clipFrontByEvent, value);
		}

		[Ordinal(21)] 
		[RED("clipEndByEvent")] 
		public CName ClipEndByEvent
		{
			get => GetProperty(ref _clipEndByEvent);
			set => SetProperty(ref _clipEndByEvent, value);
		}

		[Ordinal(22)] 
		[RED("pushDataByTag")] 
		public CName PushDataByTag
		{
			get => GetProperty(ref _pushDataByTag);
			set => SetProperty(ref _pushDataByTag, value);
		}

		[Ordinal(23)] 
		[RED("popDataByTag")] 
		public CName PopDataByTag
		{
			get => GetProperty(ref _popDataByTag);
			set => SetProperty(ref _popDataByTag, value);
		}

		[Ordinal(24)] 
		[RED("pushSafeCutTag")] 
		public CName PushSafeCutTag
		{
			get => GetProperty(ref _pushSafeCutTag);
			set => SetProperty(ref _pushSafeCutTag, value);
		}

		[Ordinal(25)] 
		[RED("convertToAdditive")] 
		public CBool ConvertToAdditive
		{
			get => GetProperty(ref _convertToAdditive);
			set => SetProperty(ref _convertToAdditive, value);
		}

		[Ordinal(26)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get => GetProperty(ref _motionProvider);
			set => SetProperty(ref _motionProvider, value);
		}

		[Ordinal(27)] 
		[RED("applyInertializationOnAnimSetSwap")] 
		public CBool ApplyInertializationOnAnimSetSwap
		{
			get => GetProperty(ref _applyInertializationOnAnimSetSwap);
			set => SetProperty(ref _applyInertializationOnAnimSetSwap, value);
		}
	}
}
