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
			get
			{
				if (_sequenceCategories == null)
				{
					_sequenceCategories = (gameCategorySelectionProbability) CR2WTypeManager.Create("gameCategorySelectionProbability", "sequenceCategories", cr2w, this);
				}
				return _sequenceCategories;
			}
			set
			{
				if (_sequenceCategories == value)
				{
					return;
				}
				_sequenceCategories = value;
				PropertySet(this);
			}
		}

		public workSetSequenceCategoriesCommandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
