using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCategorySelectionProbability : RedBaseClass
	{
		private CArray<gameSpotSequenceCategory> _probabilities;

		[Ordinal(0)] 
		[RED("probabilities")] 
		public CArray<gameSpotSequenceCategory> Probabilities
		{
			get => GetProperty(ref _probabilities);
			set => SetProperty(ref _probabilities, value);
		}
	}
}
