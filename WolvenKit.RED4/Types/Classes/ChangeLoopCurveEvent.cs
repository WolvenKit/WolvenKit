using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeLoopCurveEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("loopTime")] 
		public CFloat LoopTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("loopCurve")] 
		public CName LoopCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ChangeLoopCurveEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
