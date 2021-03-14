using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiKillInfo : CVariable
	{
		private wCHandle<gameObject> _killerEntity;
		private wCHandle<gameObject> _victimEntity;
		private CEnum<gameKillType> _killType;

		[Ordinal(0)] 
		[RED("killerEntity")] 
		public wCHandle<gameObject> KillerEntity
		{
			get
			{
				if (_killerEntity == null)
				{
					_killerEntity = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "killerEntity", cr2w, this);
				}
				return _killerEntity;
			}
			set
			{
				if (_killerEntity == value)
				{
					return;
				}
				_killerEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("victimEntity")] 
		public wCHandle<gameObject> VictimEntity
		{
			get
			{
				if (_victimEntity == null)
				{
					_victimEntity = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "victimEntity", cr2w, this);
				}
				return _victimEntity;
			}
			set
			{
				if (_victimEntity == value)
				{
					return;
				}
				_victimEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public gameuiKillInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
