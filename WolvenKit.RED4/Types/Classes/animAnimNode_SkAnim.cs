using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkAnim : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("applyMotion")] 
		public CBool ApplyMotion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("resume")] 
		public CBool Resume
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("collectEvents")] 
		public CBool CollectEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("fireAnimLoopEvent")] 
		public CBool FireAnimLoopEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("animLoopEventName")] 
		public CName AnimLoopEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("clipEnd")] 
		public CFloat ClipEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("clipFrontByEvent")] 
		public CName ClipFrontByEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("clipEndByEvent")] 
		public CName ClipEndByEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("pushDataByTag")] 
		public CName PushDataByTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("popDataByTag")] 
		public CName PopDataByTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("pushSafeCutTag")] 
		public CName PushSafeCutTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("convertToAdditive")] 
		public CBool ConvertToAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get => GetPropertyValue<CHandle<animIMotionTableProvider>>();
			set => SetPropertyValue<CHandle<animIMotionTableProvider>>(value);
		}

		[Ordinal(17)] 
		[RED("applyInertializationOnAnimSetSwap")] 
		public CBool ApplyInertializationOnAnimSetSwap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_SkAnim()
		{
			Id = uint.MaxValue;
			ApplyMotion = true;
			IsLooped = true;
			CollectEvents = true;
			ApplyInertializationOnAnimSetSwap = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
