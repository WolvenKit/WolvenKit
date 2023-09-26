using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetScanningAngleThreshold_NodeType : questIVisionModeNodeType
	{
		[Ordinal(0)] 
		[RED("angleThreshold")] 
		public CFloat AngleThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("debugSource")] 
		public CName DebugSource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questSetScanningAngleThreshold_NodeType()
		{
			AngleThreshold = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
