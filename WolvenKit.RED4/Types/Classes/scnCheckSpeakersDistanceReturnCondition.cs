using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckSpeakersDistanceReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckSpeakersDistanceReturnConditionParams Params
		{
			get => GetPropertyValue<scnCheckSpeakersDistanceReturnConditionParams>();
			set => SetPropertyValue<scnCheckSpeakersDistanceReturnConditionParams>(value);
		}

		public scnCheckSpeakersDistanceReturnCondition()
		{
			Params = new scnCheckSpeakersDistanceReturnConditionParams { Distance = 5.000000F, ComparisonType = Enums.EComparisonType.Less };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
