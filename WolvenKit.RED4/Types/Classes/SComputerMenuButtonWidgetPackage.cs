using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SComputerMenuButtonWidgetPackage : SWidgetPackage
	{
		[Ordinal(18)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SComputerMenuButtonWidgetPackage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
