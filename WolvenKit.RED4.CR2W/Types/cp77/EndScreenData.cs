using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EndScreenData : CVariable
	{
		private CArray<ProgramData> _unlockedPrograms;
		private CEnum<OutcomeMessage> _outcome;

		[Ordinal(0)] 
		[RED("unlockedPrograms")] 
		public CArray<ProgramData> UnlockedPrograms
		{
			get
			{
				if (_unlockedPrograms == null)
				{
					_unlockedPrograms = (CArray<ProgramData>) CR2WTypeManager.Create("array:ProgramData", "unlockedPrograms", cr2w, this);
				}
				return _unlockedPrograms;
			}
			set
			{
				if (_unlockedPrograms == value)
				{
					return;
				}
				_unlockedPrograms = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outcome")] 
		public CEnum<OutcomeMessage> Outcome
		{
			get
			{
				if (_outcome == null)
				{
					_outcome = (CEnum<OutcomeMessage>) CR2WTypeManager.Create("OutcomeMessage", "outcome", cr2w, this);
				}
				return _outcome;
			}
			set
			{
				if (_outcome == value)
				{
					return;
				}
				_outcome = value;
				PropertySet(this);
			}
		}

		public EndScreenData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
