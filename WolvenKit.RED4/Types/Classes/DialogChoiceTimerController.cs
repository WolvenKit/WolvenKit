using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DialogChoiceTimerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("timerValue")] 
		public inkTextWidgetReference TimerValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("progressAnimDef")] 
		public CHandle<inkanimDefinition> ProgressAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("timerAnimDef")] 
		public CHandle<inkanimDefinition> TimerAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(5)] 
		[RED("ProgressAnimInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ProgressAnimInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimScaleInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimScaleInterpolator>>(value);
		}

		[Ordinal(6)] 
		[RED("timerAnimInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> TimerAnimInterpolator
		{
			get => GetPropertyValue<CHandle<inkanimTransparencyInterpolator>>();
			set => SetPropertyValue<CHandle<inkanimTransparencyInterpolator>>(value);
		}

		[Ordinal(7)] 
		[RED("timerAnimProxy")] 
		public CHandle<inkanimProxy> TimerAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(8)] 
		[RED("timerBarAnimProxy")] 
		public CHandle<inkanimProxy> TimerBarAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(9)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(10)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DialogChoiceTimerController()
		{
			Bar = new inkWidgetReference();
			TimerValue = new inkTextWidgetReference();
			AnimOptions = new inkanimPlaybackOptions();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
