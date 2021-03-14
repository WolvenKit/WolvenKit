using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationViewData : IScriptable
	{
		private CString _title;
		private CString _text;
		private CName _soundEvent;
		private CName _soundAction;
		private CHandle<GenericNotificationBaseAction> _action;

		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get
			{
				if (_soundEvent == null)
				{
					_soundEvent = (CName) CR2WTypeManager.Create("CName", "soundEvent", cr2w, this);
				}
				return _soundEvent;
			}
			set
			{
				if (_soundEvent == value)
				{
					return;
				}
				_soundEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("soundAction")] 
		public CName SoundAction
		{
			get
			{
				if (_soundAction == null)
				{
					_soundAction = (CName) CR2WTypeManager.Create("CName", "soundAction", cr2w, this);
				}
				return _soundAction;
			}
			set
			{
				if (_soundAction == value)
				{
					return;
				}
				_soundAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("action")] 
		public CHandle<GenericNotificationBaseAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<GenericNotificationBaseAction>) CR2WTypeManager.Create("handle:GenericNotificationBaseAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public gameuiGenericNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
