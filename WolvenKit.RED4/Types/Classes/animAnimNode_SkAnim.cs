using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkAnim : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("applyMotion")] 
		public CBool ApplyMotion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("resume")] 
		public CBool Resume
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("collectEvents")] 
		public CBool CollectEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("fireAnimLoopEvent")] 
		public CBool FireAnimLoopEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("animLoopEventName")] 
		public CName AnimLoopEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("clipEnd")] 
		public CFloat ClipEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("clipFrontByEvent")] 
		public CName ClipFrontByEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("clipEndByEvent")] 
		public CName ClipEndByEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("pushDataByTag")] 
		public CName PushDataByTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("popDataByTag")] 
		public CName PopDataByTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("pushSafeCutTag")] 
		public CName PushSafeCutTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("convertToAdditive")] 
		public CBool ConvertToAdditive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get => GetPropertyValue<CHandle<animIMotionTableProvider>>();
			set => SetPropertyValue<CHandle<animIMotionTableProvider>>(value);
		}

		[Ordinal(27)] 
		[RED("applyInertializationOnAnimSetSwap")] 
		public CBool ApplyInertializationOnAnimSetSwap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_SkAnim()
		{
			Id = 4294967295;
			ApplyMotion = true;
			IsLooped = true;
			CollectEvents = true;
			ApplyInertializationOnAnimSetSwap = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
