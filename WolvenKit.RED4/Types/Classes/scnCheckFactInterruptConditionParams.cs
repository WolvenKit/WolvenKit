using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckFactInterruptConditionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("factCondition")] 
		public CHandle<scnInterruptFactConditionType> FactCondition
		{
			get => GetPropertyValue<CHandle<scnInterruptFactConditionType>>();
			set => SetPropertyValue<CHandle<scnInterruptFactConditionType>>(value);
		}

		public scnCheckFactInterruptConditionParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
