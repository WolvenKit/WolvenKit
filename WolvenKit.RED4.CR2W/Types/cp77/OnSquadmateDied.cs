using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnSquadmateDied : redEvent
	{
		private CName _squad;
		private wCHandle<entEntity> _squadmate;
		private wCHandle<entEntity> _killer;

		[Ordinal(0)] 
		[RED("squad")] 
		public CName Squad
		{
			get
			{
				if (_squad == null)
				{
					_squad = (CName) CR2WTypeManager.Create("CName", "squad", cr2w, this);
				}
				return _squad;
			}
			set
			{
				if (_squad == value)
				{
					return;
				}
				_squad = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("squadmate")] 
		public wCHandle<entEntity> Squadmate
		{
			get
			{
				if (_squadmate == null)
				{
					_squadmate = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "squadmate", cr2w, this);
				}
				return _squadmate;
			}
			set
			{
				if (_squadmate == value)
				{
					return;
				}
				_squadmate = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("killer")] 
		public wCHandle<entEntity> Killer
		{
			get
			{
				if (_killer == null)
				{
					_killer = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "killer", cr2w, this);
				}
				return _killer;
			}
			set
			{
				if (_killer == value)
				{
					return;
				}
				_killer = value;
				PropertySet(this);
			}
		}

		public OnSquadmateDied(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
