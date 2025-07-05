using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDebugChoice : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("choiceName")] 
		public CName ChoiceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("factmode")] 
		public CEnum<EVarDBMode> Factmode
		{
			get => GetPropertyValue<CEnum<EVarDBMode>>();
			set => SetPropertyValue<CEnum<EVarDBMode>>(value);
		}

		public SDebugChoice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
