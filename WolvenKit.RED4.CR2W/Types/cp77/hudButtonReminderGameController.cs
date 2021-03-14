using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudButtonReminderGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _button1;
		private inkCompoundWidgetReference _button2;
		private inkCompoundWidgetReference _button3;
		private CHandle<gameIBlackboard> _uiHudButtonHelpBB;
		private CUInt32 _interactingWithDeviceBBID;

		[Ordinal(9)] 
		[RED("Button1")] 
		public inkCompoundWidgetReference Button1
		{
			get
			{
				if (_button1 == null)
				{
					_button1 = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "Button1", cr2w, this);
				}
				return _button1;
			}
			set
			{
				if (_button1 == value)
				{
					return;
				}
				_button1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("Button2")] 
		public inkCompoundWidgetReference Button2
		{
			get
			{
				if (_button2 == null)
				{
					_button2 = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "Button2", cr2w, this);
				}
				return _button2;
			}
			set
			{
				if (_button2 == value)
				{
					return;
				}
				_button2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Button3")] 
		public inkCompoundWidgetReference Button3
		{
			get
			{
				if (_button3 == null)
				{
					_button3 = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "Button3", cr2w, this);
				}
				return _button3;
			}
			set
			{
				if (_button3 == value)
				{
					return;
				}
				_button3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("uiHudButtonHelpBB")] 
		public CHandle<gameIBlackboard> UiHudButtonHelpBB
		{
			get
			{
				if (_uiHudButtonHelpBB == null)
				{
					_uiHudButtonHelpBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiHudButtonHelpBB", cr2w, this);
				}
				return _uiHudButtonHelpBB;
			}
			set
			{
				if (_uiHudButtonHelpBB == value)
				{
					return;
				}
				_uiHudButtonHelpBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("interactingWithDeviceBBID")] 
		public CUInt32 InteractingWithDeviceBBID
		{
			get
			{
				if (_interactingWithDeviceBBID == null)
				{
					_interactingWithDeviceBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "interactingWithDeviceBBID", cr2w, this);
				}
				return _interactingWithDeviceBBID;
			}
			set
			{
				if (_interactingWithDeviceBBID == value)
				{
					return;
				}
				_interactingWithDeviceBBID = value;
				PropertySet(this);
			}
		}

		public hudButtonReminderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
