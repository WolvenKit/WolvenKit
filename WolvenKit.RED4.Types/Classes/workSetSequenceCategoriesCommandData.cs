using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workSetSequenceCategoriesCommandData : workIWorkspotCommandData
	{
		[Ordinal(0)] 
		[RED("sequenceCategories")] 
		public gameCategorySelectionProbability SequenceCategories
		{
			get => GetPropertyValue<gameCategorySelectionProbability>();
			set => SetPropertyValue<gameCategorySelectionProbability>(value);
		}

		public workSetSequenceCategoriesCommandData()
		{
			SequenceCategories = new() { Probabilities = new() };
		}
	}
}
