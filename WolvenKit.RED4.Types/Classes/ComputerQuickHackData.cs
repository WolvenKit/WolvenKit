using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerQuickHackData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("alternativeName")] 
		public TweakDBID AlternativeName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<EMathOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<EMathOperationType>>();
			set => SetPropertyValue<CEnum<EMathOperationType>>(value);
		}

		public ComputerQuickHackData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
