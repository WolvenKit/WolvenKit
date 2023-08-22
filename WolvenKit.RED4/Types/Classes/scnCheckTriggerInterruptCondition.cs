using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckTriggerInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckTriggerInterruptConditionParams Params
		{
			get => GetPropertyValue<scnCheckTriggerInterruptConditionParams>();
			set => SetPropertyValue<scnCheckTriggerInterruptConditionParams>(value);
		}

		public scnCheckTriggerInterruptCondition()
		{
			Params = new scnCheckTriggerInterruptConditionParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
