using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInspectListenerEvent : redEvent
	{
		private CHandle<questObjectInspectListener> _listener;
		private CBool _register;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<questObjectInspectListener> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<questObjectInspectListener>) CR2WTypeManager.Create("handle:questObjectInspectListener", "listener", cr2w, this);
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
		[RED("register")] 
		public CBool Register
		{
			get
			{
				if (_register == null)
				{
					_register = (CBool) CR2WTypeManager.Create("Bool", "register", cr2w, this);
				}
				return _register;
			}
			set
			{
				if (_register == value)
				{
					return;
				}
				_register = value;
				PropertySet(this);
			}
		}

		public questInspectListenerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
