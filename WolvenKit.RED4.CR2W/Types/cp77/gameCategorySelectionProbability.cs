using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCategorySelectionProbability : CVariable
	{
		private CArray<gameSpotSequenceCategory> _probabilities;

		[Ordinal(0)] 
		[RED("probabilities")] 
		public CArray<gameSpotSequenceCategory> Probabilities
		{
			get => GetProperty(ref _probabilities);
			set => SetProperty(ref _probabilities, value);
		}

		public gameCategorySelectionProbability(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
