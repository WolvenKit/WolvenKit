using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Power_Defender : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _leftPart;
		private inkWidgetReference _rightPart;
		private inkWidgetReference _topPart;
		private inkWidgetReference _botPart;

		[Ordinal(18)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(19)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(20)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(21)] 
		[RED("botPart")] 
		public inkWidgetReference BotPart
		{
			get => GetProperty(ref _botPart);
			set => SetProperty(ref _botPart, value);
		}

		public Crosshair_Power_Defender(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
