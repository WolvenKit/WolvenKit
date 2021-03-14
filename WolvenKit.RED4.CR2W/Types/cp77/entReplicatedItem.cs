using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedItem : CVariable
	{
		private wCHandle<entEntity> _entity;
		private netTime _netTime;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("netTime")] 
		public netTime NetTime
		{
			get
			{
				if (_netTime == null)
				{
					_netTime = (netTime) CR2WTypeManager.Create("netTime", "netTime", cr2w, this);
				}
				return _netTime;
			}
			set
			{
				if (_netTime == value)
				{
					return;
				}
				_netTime = value;
				PropertySet(this);
			}
		}

		public entReplicatedItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
