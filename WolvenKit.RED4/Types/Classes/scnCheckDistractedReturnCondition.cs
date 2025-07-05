using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckDistractedReturnCondition : scnIReturnCondition
	{
		[Ordinal(0)] 
		[RED("params")] 
		public scnCheckDistractedReturnConditionParams Params
		{
			get => GetPropertyValue<scnCheckDistractedReturnConditionParams>();
			set => SetPropertyValue<scnCheckDistractedReturnConditionParams>(value);
		}

		public scnCheckDistractedReturnCondition()
		{
			Params = new scnCheckDistractedReturnConditionParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
