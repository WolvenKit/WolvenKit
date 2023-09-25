using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("animIntroProxy")] 
		public CHandle<inkanimProxy> AnimIntroProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(2)] 
		[RED("animIntroOptions")] 
		public inkanimPlaybackOptions AnimIntroOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("animBlink")] 
		public CHandle<inkanimDefinition> AnimBlink
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(5)] 
		[RED("animBlinkProxy")] 
		public CHandle<inkanimProxy> AnimBlinkProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("animBlinkOptions")] 
		public inkanimPlaybackOptions AnimBlinkOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(7)] 
		[RED("animBlinkLoops", 3)] 
		public CArrayFixedSize<CUInt32> AnimBlinkLoops
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt32>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt32>>(value);
		}

		[Ordinal(8)] 
		[RED("animBlinkLastStage")] 
		public CInt32 AnimBlinkLastStage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("blinkAnimLoopType")] 
		public CEnum<inkanimLoopType> BlinkAnimLoopType
		{
			get => GetPropertyValue<CEnum<inkanimLoopType>>();
			set => SetPropertyValue<CEnum<inkanimLoopType>>(value);
		}

		[Ordinal(10)] 
		[RED("blinkDuration")] 
		public CFloat BlinkDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("bountyBadgeWidget")] 
		public inkWidgetReference BountyBadgeWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("blinkSpeed1")] 
		public CFloat BlinkSpeed1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("blinkSpeed2")] 
		public CFloat BlinkSpeed2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("blinkSpeed3")] 
		public CFloat BlinkSpeed3
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("blinkAnimInterpolationMode")] 
		public CEnum<inkanimInterpolationMode> BlinkAnimInterpolationMode
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationMode>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationMode>>(value);
		}

		[Ordinal(16)] 
		[RED("blinkAnimInterpolationType")] 
		public CEnum<inkanimInterpolationType> BlinkAnimInterpolationType
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationType>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationType>>(value);
		}

		[Ordinal(17)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("iconBg")] 
		public inkImageWidgetReference IconBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("ncpdIconName")] 
		public CName NcpdIconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("ncpdIconBgName")] 
		public CName NcpdIconBgName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("dogtownIconName")] 
		public CName DogtownIconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("dogtownIconBgName")] 
		public CName DogtownIconBgName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public StarController()
		{
			AnimIntroOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };
			AnimBlinkOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };
			AnimBlinkLoops = new(3);
			BlinkAnimLoopType = Enums.inkanimLoopType.Cycle;
			BlinkDuration = 1.000000F;
			BountyBadgeWidget = new inkWidgetReference();
			BlinkSpeed1 = 1.000000F;
			BlinkSpeed2 = 2.000000F;
			BlinkSpeed3 = 3.000000F;
			Icon = new inkImageWidgetReference();
			IconBg = new inkImageWidgetReference();
			NcpdIconName = "star_active";
			NcpdIconBgName = "star_shadow";
			DogtownIconName = "kutrz_active";
			DogtownIconBgName = "kutrz_shadow";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
