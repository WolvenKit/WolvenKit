using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackdoorDataStreamController : BackdoorInkGameController
	{
		[Ordinal(28)] 
		[RED("idleGroup")] 
		public inkWidgetReference IdleGroup_384
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("idleVPanelC1")] 
		public inkWidgetReference IdleVPanelC1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("idleVPanelC2")] 
		public inkWidgetReference IdleVPanelC2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("idleVPanelC3")] 
		public inkWidgetReference IdleVPanelC3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("idleVPanelC4")] 
		public inkWidgetReference IdleVPanelC4
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("hackedGroup")] 
		public inkWidgetReference HackedGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("idleCanvas1")] 
		public inkWidgetReference IdleCanvas1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("idleCanvas2")] 
		public inkWidgetReference IdleCanvas2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("idleCanvas3")] 
		public inkWidgetReference IdleCanvas3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("idleCanvas4")] 
		public inkWidgetReference IdleCanvas4
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("canvasC1")] 
		public inkWidgetReference CanvasC1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("canvasC2")] 
		public inkWidgetReference CanvasC2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("canvasC3")] 
		public inkWidgetReference CanvasC3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("canvasC4")] 
		public inkWidgetReference CanvasC4
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public BackdoorDataStreamController()
		{
			IdleGroup_384 = new();
			IdleVPanelC1 = new();
			IdleVPanelC2 = new();
			IdleVPanelC3 = new();
			IdleVPanelC4 = new();
			HackedGroup = new();
			IdleCanvas1 = new();
			IdleCanvas2 = new();
			IdleCanvas3 = new();
			IdleCanvas4 = new();
			CanvasC1 = new();
			CanvasC2 = new();
			CanvasC3 = new();
			CanvasC4 = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
