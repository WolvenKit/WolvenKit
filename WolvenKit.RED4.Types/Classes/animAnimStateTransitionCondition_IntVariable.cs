using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_IntVariable : animIAnimStateTransitionCondition
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
		public CInt32 CompareValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("compareFunc")] 
		public CEnum<animCompareFunc> CompareFunc
		{
			get => GetPropertyValue<CEnum<animCompareFunc>>();
			set => SetPropertyValue<CEnum<animCompareFunc>>(value);
		}

		public animAnimStateTransitionCondition_IntVariable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
