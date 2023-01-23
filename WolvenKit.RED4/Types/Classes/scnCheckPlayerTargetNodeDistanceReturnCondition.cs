using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckPlayerTargetNodeDistanceReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerTargetNodeDistanceReturnConditionParams Params
		{
			get => GetPropertyValue<scnCheckPlayerTargetNodeDistanceReturnConditionParams>();
			set => SetPropertyValue<scnCheckPlayerTargetNodeDistanceReturnConditionParams>(value);
		}

		public scnCheckPlayerTargetNodeDistanceReturnCondition()
		{
			Params = new() { Distance = 5.000000F, ComparisonType = Enums.EComparisonType.Less };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
