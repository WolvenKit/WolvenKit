using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckSpeakersDistanceInterruptCondition : scnIInterruptCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckSpeakersDistanceInterruptConditionParams Params
		{
			get => GetPropertyValue<scnCheckSpeakersDistanceInterruptConditionParams>();
			set => SetPropertyValue<scnCheckSpeakersDistanceInterruptConditionParams>(value);
		}

		public scnCheckSpeakersDistanceInterruptCondition()
		{
			Params = new() { Distance = 6.000000F };
		}
	}
}
