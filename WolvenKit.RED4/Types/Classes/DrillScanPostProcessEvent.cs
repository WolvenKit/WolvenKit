using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DrillScanPostProcessEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("IsEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DrillScanPostProcessEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
