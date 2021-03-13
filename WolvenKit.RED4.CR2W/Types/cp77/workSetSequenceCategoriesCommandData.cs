using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workSetSequenceCategoriesCommandData : workIWorkspotCommandData
	{
		[Ordinal(0)] [RED("sequenceCategories")] public gameCategorySelectionProbability SequenceCategories { get; set; }

		public workSetSequenceCategoriesCommandData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
