using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProgressionNotification : GenericNotificationController
	{
		[Ordinal(16)] 
		[RED("progression_data")] 
		public CHandle<gameuiProgressionViewData> Progression_data
		{
			get => GetPropertyValue<CHandle<gameuiProgressionViewData>>();
			set => SetPropertyValue<CHandle<gameuiProgressionViewData>>(value);
		}

		[Ordinal(17)] 
		[RED("expBar")] 
		public inkWidgetReference ExpBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("expText")] 
		public inkTextWidgetReference ExpText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("barFG")] 
		public inkWidgetReference BarFG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("barBG")] 
		public inkWidgetReference BarBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("currentLevel")] 
		public inkTextWidgetReference CurrentLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("nextLevel")] 
		public inkTextWidgetReference NextLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("expBarWidthSize")] 
		public CFloat ExpBarWidthSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("expBarHeightSize")] 
		public CFloat ExpBarHeightSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(27)] 
		[RED("barAnimationProxy")] 
		public CHandle<inkanimProxy> BarAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public ProgressionNotification()
		{
			ExpBar = new inkWidgetReference();
			ExpText = new inkTextWidgetReference();
			BarFG = new inkWidgetReference();
			BarBG = new inkWidgetReference();
			Root = new inkWidgetReference();
			CurrentLevel = new inkTextWidgetReference();
			NextLevel = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
