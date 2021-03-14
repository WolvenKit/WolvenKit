using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownItemClickedEvent : redEvent
	{
		private wCHandle<IScriptable> _owner;
		private wCHandle<DropdownButtonController> _triggerButton;
		private CVariant _identifier;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<IScriptable> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "owner", cr2w, this);
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
		[RED("triggerButton")] 
		public wCHandle<DropdownButtonController> TriggerButton
		{
			get
			{
				if (_triggerButton == null)
				{
					_triggerButton = (wCHandle<DropdownButtonController>) CR2WTypeManager.Create("whandle:DropdownButtonController", "triggerButton", cr2w, this);
				}
				return _triggerButton;
			}
			set
			{
				if (_triggerButton == value)
				{
					return;
				}
				_triggerButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("identifier")] 
		public CVariant Identifier
		{
			get
			{
				if (_identifier == null)
				{
					_identifier = (CVariant) CR2WTypeManager.Create("Variant", "identifier", cr2w, this);
				}
				return _identifier;
			}
			set
			{
				if (_identifier == value)
				{
					return;
				}
				_identifier = value;
				PropertySet(this);
			}
		}

		public DropdownItemClickedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
