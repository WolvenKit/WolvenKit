using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckFactInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckFactInterruptConditionParams Params
		{
			get => GetPropertyValue<scnCheckFactInterruptConditionParams>();
			set => SetPropertyValue<scnCheckFactInterruptConditionParams>(value);
		}

		public scnCheckFactInterruptCondition()
		{
			Params = new scnCheckFactInterruptConditionParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
