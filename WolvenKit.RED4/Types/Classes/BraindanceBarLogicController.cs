using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BraindanceBarLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get => GetPropertyValue<CEnum<gameuiEBraindanceLayer>>();
			set => SetPropertyValue<CEnum<gameuiEBraindanceLayer>>(value);
		}

		[Ordinal(2)] 
		[RED("isInLayer")] 
		public CBool IsInLayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("timelineActiveAnimationName")] 
		public CName TimelineActiveAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("timelineDisabledAnimationName")] 
		public CName TimelineDisabledAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("timelineActiveAnimation")] 
		public CHandle<inkanimProxy> TimelineActiveAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("timelineDisabledAnimation")] 
		public CHandle<inkanimProxy> TimelineDisabledAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public BraindanceBarLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
