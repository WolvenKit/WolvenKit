using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckFactReturnConditionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("factCondition")] 
		public CHandle<scnInterruptFactConditionType> FactCondition
		{
			get => GetPropertyValue<CHandle<scnInterruptFactConditionType>>();
			set => SetPropertyValue<CHandle<scnInterruptFactConditionType>>(value);
		}

		public scnCheckFactReturnConditionParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
