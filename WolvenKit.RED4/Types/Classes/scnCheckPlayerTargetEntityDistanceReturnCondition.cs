using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckPlayerTargetEntityDistanceReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckPlayerTargetEntityDistanceReturnConditionParams Params
		{
			get => GetPropertyValue<scnCheckPlayerTargetEntityDistanceReturnConditionParams>();
			set => SetPropertyValue<scnCheckPlayerTargetEntityDistanceReturnConditionParams>(value);
		}

		public scnCheckPlayerTargetEntityDistanceReturnCondition()
		{
			Params = new() { Distance = 5.000000F, ComparisonType = Enums.EComparisonType.Less, TargetEntity = new() { Names = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
