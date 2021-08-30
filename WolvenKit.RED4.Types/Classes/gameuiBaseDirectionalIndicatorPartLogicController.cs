using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBaseDirectionalIndicatorPartLogicController : inkWidgetLogicController
	{
		private CFloat _defaultForwardFovRange;
		private CFloat _adjustedForwardFovRange;

		[Ordinal(1)] 
		[RED("defaultForwardFovRange")] 
		public CFloat DefaultForwardFovRange
		{
			get => GetProperty(ref _defaultForwardFovRange);
			set => SetProperty(ref _defaultForwardFovRange, value);
		}

		[Ordinal(2)] 
		[RED("adjustedForwardFovRange")] 
		public CFloat AdjustedForwardFovRange
		{
			get => GetProperty(ref _adjustedForwardFovRange);
			set => SetProperty(ref _adjustedForwardFovRange, value);
		}

		public gameuiBaseDirectionalIndicatorPartLogicController()
		{
			_defaultForwardFovRange = 80.000000F;
			_adjustedForwardFovRange = 160.000000F;
		}
	}
}
