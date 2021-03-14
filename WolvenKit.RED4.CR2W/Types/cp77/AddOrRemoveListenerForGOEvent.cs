using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddOrRemoveListenerForGOEvent : redEvent
	{
		private CHandle<GameObjectListener> _listener;
		private CBool _shouldAdd;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<GameObjectListener> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<GameObjectListener>) CR2WTypeManager.Create("handle:GameObjectListener", "listener", cr2w, this);
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
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get
			{
				if (_shouldAdd == null)
				{
					_shouldAdd = (CBool) CR2WTypeManager.Create("Bool", "shouldAdd", cr2w, this);
				}
				return _shouldAdd;
			}
			set
			{
				if (_shouldAdd == value)
				{
					return;
				}
				_shouldAdd = value;
				PropertySet(this);
			}
		}

		public AddOrRemoveListenerForGOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
