using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_ModifiedFloatVariable : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("compareValue")] 
		public CFloat CompareValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("compareFunc")] 
		public CEnum<animCompareFunc> CompareFunc
		{
			get => GetPropertyValue<CEnum<animCompareFunc>>();
			set => SetPropertyValue<CEnum<animCompareFunc>>(value);
		}

		public animAnimStateTransitionCondition_ModifiedFloatVariable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
