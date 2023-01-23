using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTrapTooltipDisplayer : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("trap")] 
		public CWeakHandle<gamedataMiniGame_Trap_Record> Trap
		{
			get => GetPropertyValue<CWeakHandle<gamedataMiniGame_Trap_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataMiniGame_Trap_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiTrapTooltipDisplayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
