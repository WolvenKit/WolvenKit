using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddOrRemoveListenerEvent : redEvent
	{
		private CHandle<PuppetListener> _listener;
		private CBool _add;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<PuppetListener> Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CHandle<PuppetListener>) CR2WTypeManager.Create("handle:PuppetListener", "listener", cr2w, this);
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
		[RED("add")] 
		public CBool Add
		{
			get
			{
				if (_add == null)
				{
					_add = (CBool) CR2WTypeManager.Create("Bool", "add", cr2w, this);
				}
				return _add;
			}
			set
			{
				if (_add == value)
				{
					return;
				}
				_add = value;
				PropertySet(this);
			}
		}

		public AddOrRemoveListenerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
