using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsKillRewardEvent : redEvent
	{
		private wCHandle<gameObject> _victim;
		private CEnum<gameKillType> _killType;

		[Ordinal(0)] 
		[RED("victim")] 
		public wCHandle<gameObject> Victim
		{
			get
			{
				if (_victim == null)
				{
					_victim = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "victim", cr2w, this);
				}
				return _victim;
			}
			set
			{
				if (_victim == value)
				{
					return;
				}
				_victim = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get
			{
				if (_killType == null)
				{
					_killType = (CEnum<gameKillType>) CR2WTypeManager.Create("gameKillType", "killType", cr2w, this);
				}
				return _killType;
			}
			set
			{
				if (_killType == value)
				{
					return;
				}
				_killType = value;
				PropertySet(this);
			}
		}

		public gameeventsKillRewardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
