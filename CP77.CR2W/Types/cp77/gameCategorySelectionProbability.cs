using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCategorySelectionProbability : CVariable
	{
		[Ordinal(0)]  [RED("probabilities")] public CArray<gameSpotSequenceCategory> Probabilities { get; set; }

		public gameCategorySelectionProbability(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
