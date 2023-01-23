using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCategorySelectionProbability : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("probabilities")] 
		public CArray<gameSpotSequenceCategory> Probabilities
		{
			get => GetPropertyValue<CArray<gameSpotSequenceCategory>>();
			set => SetPropertyValue<CArray<gameSpotSequenceCategory>>(value);
		}

		public gameCategorySelectionProbability()
		{
			Probabilities = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
