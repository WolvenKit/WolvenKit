using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workSetSequenceCategoriesCommandData : workIWorkspotCommandData
	{
		private gameCategorySelectionProbability _sequenceCategories;

		[Ordinal(0)] 
		[RED("sequenceCategories")] 
		public gameCategorySelectionProbability SequenceCategories
		{
			get => GetProperty(ref _sequenceCategories);
			set => SetProperty(ref _sequenceCategories, value);
		}
	}
}
