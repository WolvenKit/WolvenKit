using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnVarComparison_FactConditionType : scnInterruptFactConditionType
	{
		private scnVarComparison_FactConditionTypeParams _params;

		[Ordinal(0)] 
		[RED("params")] 
		public scnVarComparison_FactConditionTypeParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
