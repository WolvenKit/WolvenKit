using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackdoorDataStreamController : BackdoorInkGameController
	{
		private inkWidgetReference _idleGroup_280;
		private inkWidgetReference _idleVPanelC1;
		private inkWidgetReference _idleVPanelC2;
		private inkWidgetReference _idleVPanelC3;
		private inkWidgetReference _idleVPanelC4;
		private inkWidgetReference _hackedGroup;
		private inkWidgetReference _idleCanvas1;
		private inkWidgetReference _idleCanvas2;
		private inkWidgetReference _idleCanvas3;
		private inkWidgetReference _idleCanvas4;
		private inkWidgetReference _canvasC1;
		private inkWidgetReference _canvasC2;
		private inkWidgetReference _canvasC3;
		private inkWidgetReference _canvasC4;

		[Ordinal(28)] 
		[RED("idleGroup")] 
		public inkWidgetReference IdleGroup_280
		{
			get => GetProperty(ref _idleGroup_280);
			set => SetProperty(ref _idleGroup_280, value);
		}

		[Ordinal(29)] 
		[RED("idleVPanelC1")] 
		public inkWidgetReference IdleVPanelC1
		{
			get => GetProperty(ref _idleVPanelC1);
			set => SetProperty(ref _idleVPanelC1, value);
		}

		[Ordinal(30)] 
		[RED("idleVPanelC2")] 
		public inkWidgetReference IdleVPanelC2
		{
			get => GetProperty(ref _idleVPanelC2);
			set => SetProperty(ref _idleVPanelC2, value);
		}

		[Ordinal(31)] 
		[RED("idleVPanelC3")] 
		public inkWidgetReference IdleVPanelC3
		{
			get => GetProperty(ref _idleVPanelC3);
			set => SetProperty(ref _idleVPanelC3, value);
		}

		[Ordinal(32)] 
		[RED("idleVPanelC4")] 
		public inkWidgetReference IdleVPanelC4
		{
			get => GetProperty(ref _idleVPanelC4);
			set => SetProperty(ref _idleVPanelC4, value);
		}

		[Ordinal(33)] 
		[RED("hackedGroup")] 
		public inkWidgetReference HackedGroup
		{
			get => GetProperty(ref _hackedGroup);
			set => SetProperty(ref _hackedGroup, value);
		}

		[Ordinal(34)] 
		[RED("idleCanvas1")] 
		public inkWidgetReference IdleCanvas1
		{
			get => GetProperty(ref _idleCanvas1);
			set => SetProperty(ref _idleCanvas1, value);
		}

		[Ordinal(35)] 
		[RED("idleCanvas2")] 
		public inkWidgetReference IdleCanvas2
		{
			get => GetProperty(ref _idleCanvas2);
			set => SetProperty(ref _idleCanvas2, value);
		}

		[Ordinal(36)] 
		[RED("idleCanvas3")] 
		public inkWidgetReference IdleCanvas3
		{
			get => GetProperty(ref _idleCanvas3);
			set => SetProperty(ref _idleCanvas3, value);
		}

		[Ordinal(37)] 
		[RED("idleCanvas4")] 
		public inkWidgetReference IdleCanvas4
		{
			get => GetProperty(ref _idleCanvas4);
			set => SetProperty(ref _idleCanvas4, value);
		}

		[Ordinal(38)] 
		[RED("canvasC1")] 
		public inkWidgetReference CanvasC1
		{
			get => GetProperty(ref _canvasC1);
			set => SetProperty(ref _canvasC1, value);
		}

		[Ordinal(39)] 
		[RED("canvasC2")] 
		public inkWidgetReference CanvasC2
		{
			get => GetProperty(ref _canvasC2);
			set => SetProperty(ref _canvasC2, value);
		}

		[Ordinal(40)] 
		[RED("canvasC3")] 
		public inkWidgetReference CanvasC3
		{
			get => GetProperty(ref _canvasC3);
			set => SetProperty(ref _canvasC3, value);
		}

		[Ordinal(41)] 
		[RED("canvasC4")] 
		public inkWidgetReference CanvasC4
		{
			get => GetProperty(ref _canvasC4);
			set => SetProperty(ref _canvasC4, value);
		}

		public BackdoorDataStreamController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
