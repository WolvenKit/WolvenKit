using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHoldIndicatorGameController : gameuiWidgetGameController
	{
		private gameuiHoldIndicatorProgressCallback _holdProgress;
		private inkEmptyCallback _holdStart;
		private inkEmptyCallback _holdFinish;
		private inkEmptyCallback _holdStop;

		[Ordinal(2)] 
		[RED("HoldProgress")] 
		public gameuiHoldIndicatorProgressCallback HoldProgress
		{
			get => GetProperty(ref _holdProgress);
			set => SetProperty(ref _holdProgress, value);
		}

		[Ordinal(3)] 
		[RED("HoldStart")] 
		public inkEmptyCallback HoldStart
		{
			get => GetProperty(ref _holdStart);
			set => SetProperty(ref _holdStart, value);
		}

		[Ordinal(4)] 
		[RED("HoldFinish")] 
		public inkEmptyCallback HoldFinish
		{
			get => GetProperty(ref _holdFinish);
			set => SetProperty(ref _holdFinish, value);
		}

		[Ordinal(5)] 
		[RED("HoldStop")] 
		public inkEmptyCallback HoldStop
		{
			get => GetProperty(ref _holdStop);
			set => SetProperty(ref _holdStop, value);
		}

		public gameuiHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
