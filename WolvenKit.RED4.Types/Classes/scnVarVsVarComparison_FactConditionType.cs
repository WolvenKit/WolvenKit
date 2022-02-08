using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnVarVsVarComparison_FactConditionType : scnInterruptFactConditionType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnVarVsVarComparison_FactConditionTypeParams Params
		{
			get => GetPropertyValue<scnVarVsVarComparison_FactConditionTypeParams>();
			set => SetPropertyValue<scnVarVsVarComparison_FactConditionTypeParams>(value);
		}

		public scnVarVsVarComparison_FactConditionType()
		{
			Params = new();
		}
	}
}
