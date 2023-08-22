using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnVarComparison_FactConditionType : scnInterruptFactConditionType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnVarComparison_FactConditionTypeParams Params
		{
			get => GetPropertyValue<scnVarComparison_FactConditionTypeParams>();
			set => SetPropertyValue<scnVarComparison_FactConditionTypeParams>(value);
		}

		public scnVarComparison_FactConditionType()
		{
			Params = new scnVarComparison_FactConditionTypeParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
