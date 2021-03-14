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
			get
			{
				if (_probabilities == null)
				{
					_probabilities = (CArray<gameSpotSequenceCategory>) CR2WTypeManager.Create("array:gameSpotSequenceCategory", "probabilities", cr2w, this);
				}
				return _probabilities;
			}
			set
			{
				if (_probabilities == value)
				{
					return;
				}
				_probabilities = value;
				PropertySet(this);
			}
		}

		public gameCategorySelectionProbability(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
