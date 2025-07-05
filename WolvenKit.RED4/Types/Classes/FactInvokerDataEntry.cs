using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactInvokerDataEntry : IScriptable
	{
		[Ordinal(0)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("password")] 
		public CName Password
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public FactInvokerDataEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
