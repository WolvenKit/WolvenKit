using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElevatorArrowsLogicController : DeviceInkLogicControllerBase
	{
		[Ordinal(5)] 
		[RED("arrow1Widget")] 
		public inkWidgetReference Arrow1Widget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("arrow2Widget")] 
		public inkWidgetReference Arrow2Widget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("arrow3Widget")] 
		public inkWidgetReference Arrow3Widget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("animFade1")] 
		public CHandle<inkanimDefinition> AnimFade1
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(9)] 
		[RED("animFade2")] 
		public CHandle<inkanimDefinition> AnimFade2
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(10)] 
		[RED("animFade3")] 
		public CHandle<inkanimDefinition> AnimFade3
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(11)] 
		[RED("animSlow1")] 
		public CHandle<inkanimDefinition> AnimSlow1
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(12)] 
		[RED("animSlow2")] 
		public CHandle<inkanimDefinition> AnimSlow2
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(13)] 
		[RED("animOptions1")] 
		public inkanimPlaybackOptions AnimOptions1
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(14)] 
		[RED("animOptions2")] 
		public inkanimPlaybackOptions AnimOptions2
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(15)] 
		[RED("animOptions3")] 
		public inkanimPlaybackOptions AnimOptions3
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		public ElevatorArrowsLogicController()
		{
			Arrow1Widget = new inkWidgetReference();
			Arrow2Widget = new inkWidgetReference();
			Arrow3Widget = new inkWidgetReference();
			AnimOptions1 = new inkanimPlaybackOptions();
			AnimOptions2 = new inkanimPlaybackOptions();
			AnimOptions3 = new inkanimPlaybackOptions();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
