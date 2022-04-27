using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SFactToChange : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("factName")] 
		public CName FactName
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
		[RED("operationType")] 
		public CEnum<EMathOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<EMathOperationType>>();
			set => SetPropertyValue<CEnum<EMathOperationType>>(value);
		}

		public SFactToChange()
		{
			OperationType = Enums.EMathOperationType.Set;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
