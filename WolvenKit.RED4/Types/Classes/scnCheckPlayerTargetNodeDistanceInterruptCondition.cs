using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckPlayerTargetNodeDistanceInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerTargetNodeDistanceInterruptConditionParams Params
		{
			get => GetPropertyValue<scnCheckPlayerTargetNodeDistanceInterruptConditionParams>();
			set => SetPropertyValue<scnCheckPlayerTargetNodeDistanceInterruptConditionParams>(value);
		}

		public scnCheckPlayerTargetNodeDistanceInterruptCondition()
		{
			Params = new scnCheckPlayerTargetNodeDistanceInterruptConditionParams { Distance = 6.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
