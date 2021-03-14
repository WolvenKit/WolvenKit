using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityNoticedPlayerPrereqState : gamePrereqState
	{
		private wCHandle<gameObject> _owner;
		private CUInt32 _listenerInt;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("listenerInt")] 
		public CUInt32 ListenerInt
		{
			get
			{
				if (_listenerInt == null)
				{
					_listenerInt = (CUInt32) CR2WTypeManager.Create("Uint32", "listenerInt", cr2w, this);
				}
				return _listenerInt;
			}
			set
			{
				if (_listenerInt == value)
				{
					return;
				}
				_listenerInt = value;
				PropertySet(this);
			}
		}

		public EntityNoticedPlayerPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
