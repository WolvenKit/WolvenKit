using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckPlayerTargetEntityDistanceInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerTargetEntityDistanceInterruptConditionParams Params
		{
			get => GetPropertyValue<scnCheckPlayerTargetEntityDistanceInterruptConditionParams>();
			set => SetPropertyValue<scnCheckPlayerTargetEntityDistanceInterruptConditionParams>(value);
		}

		public scnCheckPlayerTargetEntityDistanceInterruptCondition()
		{
			Params = new scnCheckPlayerTargetEntityDistanceInterruptConditionParams { Distance = 6.000000F, TargetEntity = new gameEntityReference { Names = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
