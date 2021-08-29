using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeLoopCurveEvent : redEvent
	{
		private CFloat _loopTime;
		private CName _loopCurve;

		[Ordinal(0)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get => GetProperty(ref _loopTime);
			set => SetProperty(ref _loopTime, value);
		}

		[Ordinal(1)] 
		[RED("loopCurve")] 
		public CName LoopCurve
		{
			get => GetProperty(ref _loopCurve);
			set => SetProperty(ref _loopCurve, value);
		}
	}
}
