using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTrapTooltipDisplayer : inkWidgetLogicController
	{
		private CWeakHandle<gamedataMiniGame_Trap_Record> _trap;
		private CFloat _delayDuration;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(1)] 
		[RED("trap")] 
		public CWeakHandle<gamedataMiniGame_Trap_Record> Trap
		{
			get => GetProperty(ref _trap);
			set => SetProperty(ref _trap, value);
		}

		[Ordinal(2)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get => GetProperty(ref _delayDuration);
			set => SetProperty(ref _delayDuration, value);
		}

		[Ordinal(3)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}
	}
}
