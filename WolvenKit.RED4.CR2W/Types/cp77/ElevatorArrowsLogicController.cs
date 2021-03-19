using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorArrowsLogicController : DeviceInkLogicControllerBase
	{
		private inkWidgetReference _arrow1Widget;
		private inkWidgetReference _arrow2Widget;
		private inkWidgetReference _arrow3Widget;
		private CHandle<inkanimDefinition> _animFade1;
		private CHandle<inkanimDefinition> _animFade2;
		private CHandle<inkanimDefinition> _animFade3;
		private CHandle<inkanimDefinition> _animSlow1;
		private CHandle<inkanimDefinition> _animSlow2;
		private inkanimPlaybackOptions _animOptions1;
		private inkanimPlaybackOptions _animOptions2;
		private inkanimPlaybackOptions _animOptions3;

		[Ordinal(5)] 
		[RED("arrow1Widget")] 
		public inkWidgetReference Arrow1Widget
		{
			get => GetProperty(ref _arrow1Widget);
			set => SetProperty(ref _arrow1Widget, value);
		}

		[Ordinal(6)] 
		[RED("arrow2Widget")] 
		public inkWidgetReference Arrow2Widget
		{
			get => GetProperty(ref _arrow2Widget);
			set => SetProperty(ref _arrow2Widget, value);
		}

		[Ordinal(7)] 
		[RED("arrow3Widget")] 
		public inkWidgetReference Arrow3Widget
		{
			get => GetProperty(ref _arrow3Widget);
			set => SetProperty(ref _arrow3Widget, value);
		}

		[Ordinal(8)] 
		[RED("animFade1")] 
		public CHandle<inkanimDefinition> AnimFade1
		{
			get => GetProperty(ref _animFade1);
			set => SetProperty(ref _animFade1, value);
		}

		[Ordinal(9)] 
		[RED("animFade2")] 
		public CHandle<inkanimDefinition> AnimFade2
		{
			get => GetProperty(ref _animFade2);
			set => SetProperty(ref _animFade2, value);
		}

		[Ordinal(10)] 
		[RED("animFade3")] 
		public CHandle<inkanimDefinition> AnimFade3
		{
			get => GetProperty(ref _animFade3);
			set => SetProperty(ref _animFade3, value);
		}

		[Ordinal(11)] 
		[RED("animSlow1")] 
		public CHandle<inkanimDefinition> AnimSlow1
		{
			get => GetProperty(ref _animSlow1);
			set => SetProperty(ref _animSlow1, value);
		}

		[Ordinal(12)] 
		[RED("animSlow2")] 
		public CHandle<inkanimDefinition> AnimSlow2
		{
			get => GetProperty(ref _animSlow2);
			set => SetProperty(ref _animSlow2, value);
		}

		[Ordinal(13)] 
		[RED("animOptions1")] 
		public inkanimPlaybackOptions AnimOptions1
		{
			get => GetProperty(ref _animOptions1);
			set => SetProperty(ref _animOptions1, value);
		}

		[Ordinal(14)] 
		[RED("animOptions2")] 
		public inkanimPlaybackOptions AnimOptions2
		{
			get => GetProperty(ref _animOptions2);
			set => SetProperty(ref _animOptions2, value);
		}

		[Ordinal(15)] 
		[RED("animOptions3")] 
		public inkanimPlaybackOptions AnimOptions3
		{
			get => GetProperty(ref _animOptions3);
			set => SetProperty(ref _animOptions3, value);
		}

		public ElevatorArrowsLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
