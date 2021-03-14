using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestModifyFilters : redEvent
	{
		private CEnum<EQuestFilterType> _incomingFilters;
		private CEnum<EQuestFilterType> _outgoingFilters;

		[Ordinal(0)] 
		[RED("incomingFilters")] 
		public CEnum<EQuestFilterType> IncomingFilters
		{
			get
			{
				if (_incomingFilters == null)
				{
					_incomingFilters = (CEnum<EQuestFilterType>) CR2WTypeManager.Create("EQuestFilterType", "incomingFilters", cr2w, this);
				}
				return _incomingFilters;
			}
			set
			{
				if (_incomingFilters == value)
				{
					return;
				}
				_incomingFilters = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outgoingFilters")] 
		public CEnum<EQuestFilterType> OutgoingFilters
		{
			get
			{
				if (_outgoingFilters == null)
				{
					_outgoingFilters = (CEnum<EQuestFilterType>) CR2WTypeManager.Create("EQuestFilterType", "outgoingFilters", cr2w, this);
				}
				return _outgoingFilters;
			}
			set
			{
				if (_outgoingFilters == value)
				{
					return;
				}
				_outgoingFilters = value;
				PropertySet(this);
			}
		}

		public QuestModifyFilters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
