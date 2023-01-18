using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDProgressBarController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("percent")] 
		public inkTextWidgetReference Percent
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("completed")] 
		public inkTextWidgetReference Completed
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("failed")] 
		public inkTextWidgetReference Failed
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("progressBarBB")] 
		public CWeakHandle<gameIBlackboard> ProgressBarBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(16)] 
		[RED("progressBarDef")] 
		public CHandle<UI_HUDProgressBarDef> ProgressBarDef
		{
			get => GetPropertyValue<CHandle<UI_HUDProgressBarDef>>();
			set => SetPropertyValue<CHandle<UI_HUDProgressBarDef>>(value);
		}

		[Ordinal(17)] 
		[RED("activeBBID")] 
		public CHandle<redCallbackObject> ActiveBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("headerBBID")] 
		public CHandle<redCallbackObject> HeaderBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("progressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("OutroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("LoopAnimation")] 
		public CHandle<inkanimProxy> LoopAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("IntroAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("IntroWasPlayed")] 
		public CBool IntroWasPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("valueSaved")] 
		public CFloat ValueSaved
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public HUDProgressBarController()
		{
			Bar = new();
			Header = new();
			Percent = new();
			Completed = new();
			Failed = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
