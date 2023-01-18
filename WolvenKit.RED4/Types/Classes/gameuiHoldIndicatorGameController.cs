using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHoldIndicatorGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("HoldProgress")] 
		public gameuiHoldIndicatorProgressCallback HoldProgress
		{
			get => GetPropertyValue<gameuiHoldIndicatorProgressCallback>();
			set => SetPropertyValue<gameuiHoldIndicatorProgressCallback>(value);
		}

		[Ordinal(3)] 
		[RED("HoldStart")] 
		public inkEmptyCallback HoldStart
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(4)] 
		[RED("HoldFinish")] 
		public inkEmptyCallback HoldFinish
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		[Ordinal(5)] 
		[RED("HoldStop")] 
		public inkEmptyCallback HoldStop
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		public gameuiHoldIndicatorGameController()
		{
			HoldProgress = new();
			HoldStart = new();
			HoldFinish = new();
			HoldStop = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
