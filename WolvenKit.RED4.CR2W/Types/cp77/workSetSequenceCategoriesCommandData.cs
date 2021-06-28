using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workSetSequenceCategoriesCommandData : workIWorkspotCommandData
	{
		private gameCategorySelectionProbability _sequenceCategories;

		[Ordinal(0)] 
		[RED("sequenceCategories")] 
		public gameCategorySelectionProbability SequenceCategories
		{
			get => GetProperty(ref _sequenceCategories);
			set => SetProperty(ref _sequenceCategories, value);
		}

		public workSetSequenceCategoriesCommandData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
