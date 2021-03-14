using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemInSlotPrereqState : gamePrereqState
	{
		private CHandle<ItemInSlotCallback> _listener;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<ItemInSlotCallback> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<ItemInSlotCallback>) CR2WTypeManager.Create("handle:ItemInSlotCallback", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public ItemInSlotPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
