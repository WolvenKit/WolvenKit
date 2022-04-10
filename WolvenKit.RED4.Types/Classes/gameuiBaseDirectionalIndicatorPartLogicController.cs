using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBaseDirectionalIndicatorPartLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("defaultForwardFovRange")] 
		public CFloat DefaultForwardFovRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("adjustedForwardFovRange")] 
		public CFloat AdjustedForwardFovRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiBaseDirectionalIndicatorPartLogicController()
		{
			DefaultForwardFovRange = 80.000000F;
			AdjustedForwardFovRange = 160.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
