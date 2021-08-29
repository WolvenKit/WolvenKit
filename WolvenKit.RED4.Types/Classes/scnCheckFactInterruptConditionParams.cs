using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckFactInterruptConditionParams : RedBaseClass
	{
		private CHandle<scnInterruptFactConditionType> _factCondition;

		[Ordinal(0)] 
		[RED("factCondition")] 
		public CHandle<scnInterruptFactConditionType> FactCondition
		{
			get => GetProperty(ref _factCondition);
			set => SetProperty(ref _factCondition, value);
		}
	}
}
