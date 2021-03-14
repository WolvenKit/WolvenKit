using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestContext : CVariable
	{
		private gameJournalRequestStateFilter _stateFilter;
		private gameJournalRequestClassFilter _classFilter;

		[Ordinal(0)] 
		[RED("stateFilter")] 
		public gameJournalRequestStateFilter StateFilter
		{
			get
			{
				if (_stateFilter == null)
				{
					_stateFilter = (gameJournalRequestStateFilter) CR2WTypeManager.Create("gameJournalRequestStateFilter", "stateFilter", cr2w, this);
				}
				return _stateFilter;
			}
			set
			{
				if (_stateFilter == value)
				{
					return;
				}
				_stateFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("classFilter")] 
		public gameJournalRequestClassFilter ClassFilter
		{
			get
			{
				if (_classFilter == null)
				{
					_classFilter = (gameJournalRequestClassFilter) CR2WTypeManager.Create("gameJournalRequestClassFilter", "classFilter", cr2w, this);
				}
				return _classFilter;
			}
			set
			{
				if (_classFilter == value)
				{
					return;
				}
				_classFilter = value;
				PropertySet(this);
			}
		}

		public gameJournalRequestContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
