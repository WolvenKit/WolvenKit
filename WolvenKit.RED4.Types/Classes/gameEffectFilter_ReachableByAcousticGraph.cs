using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectFilter_ReachableByAcousticGraph : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] 
		[RED("maxPathLength")] 
		public gameEffectInputParameter_Float MaxPathLength
		{
			get => GetPropertyValue<gameEffectInputParameter_Float>();
			set => SetPropertyValue<gameEffectInputParameter_Float>(value);
		}

		public gameEffectFilter_ReachableByAcousticGraph()
		{
			MaxPathLength = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
