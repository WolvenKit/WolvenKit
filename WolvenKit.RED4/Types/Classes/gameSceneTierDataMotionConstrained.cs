using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSceneTierDataMotionConstrained : gameSceneTierData
	{
		[Ordinal(3)] 
		[RED("params")] 
		public gameMotionConstrainedTierDataParams Params
		{
			get => GetPropertyValue<gameMotionConstrainedTierDataParams>();
			set => SetPropertyValue<gameMotionConstrainedTierDataParams>(value);
		}

		public gameSceneTierDataMotionConstrained()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
