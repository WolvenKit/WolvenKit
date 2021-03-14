using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericHotkeyController : gameuiHUDGameController
	{
		private inkImageWidgetReference _hotkeyBackground;
		private inkWidgetReference _buttonHint;
		private CEnum<gameEHotkey> _hotkey;
		private CBool _pressStarted;
		private CHandle<inkInputDisplayController> _buttonHintController;
		private CName _questActivatingFact;
		private CArray<CName> _restrictions;
		private CHandle<HotkeyWidgetStatsListener> _statusEffectsListener;
		private CArray<CUInt32> _debugCommands;
		private CUInt32 _factListenerId;

		[Ordinal(9)] 
		[RED("hotkeyBackground")] 
		public inkImageWidgetReference HotkeyBackground
		{
			get
			{
				if (_hotkeyBackground == null)
				{
					_hotkeyBackground = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "hotkeyBackground", cr2w, this);
				}
				return _hotkeyBackground;
			}
			set
			{
				if (_hotkeyBackground == value)
				{
					return;
				}
				_hotkeyBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("buttonHint")] 
		public inkWidgetReference ButtonHint
		{
			get
			{
				if (_buttonHint == null)
				{
					_buttonHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHint", cr2w, this);
				}
				return _buttonHint;
			}
			set
			{
				if (_buttonHint == value)
				{
					return;
				}
				_buttonHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get
			{
				if (_hotkey == null)
				{
					_hotkey = (CEnum<gameEHotkey>) CR2WTypeManager.Create("gameEHotkey", "hotkey", cr2w, this);
				}
				return _hotkey;
			}
			set
			{
				if (_hotkey == value)
				{
					return;
				}
				_hotkey = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("pressStarted")] 
		public CBool PressStarted
		{
			get
			{
				if (_pressStarted == null)
				{
					_pressStarted = (CBool) CR2WTypeManager.Create("Bool", "pressStarted", cr2w, this);
				}
				return _pressStarted;
			}
			set
			{
				if (_pressStarted == value)
				{
					return;
				}
				_pressStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("buttonHintController")] 
		public CHandle<inkInputDisplayController> ButtonHintController
		{
			get
			{
				if (_buttonHintController == null)
				{
					_buttonHintController = (CHandle<inkInputDisplayController>) CR2WTypeManager.Create("handle:inkInputDisplayController", "buttonHintController", cr2w, this);
				}
				return _buttonHintController;
			}
			set
			{
				if (_buttonHintController == value)
				{
					return;
				}
				_buttonHintController = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("questActivatingFact")] 
		public CName QuestActivatingFact
		{
			get
			{
				if (_questActivatingFact == null)
				{
					_questActivatingFact = (CName) CR2WTypeManager.Create("CName", "questActivatingFact", cr2w, this);
				}
				return _questActivatingFact;
			}
			set
			{
				if (_questActivatingFact == value)
				{
					return;
				}
				_questActivatingFact = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("restrictions")] 
		public CArray<CName> Restrictions
		{
			get
			{
				if (_restrictions == null)
				{
					_restrictions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "restrictions", cr2w, this);
				}
				return _restrictions;
			}
			set
			{
				if (_restrictions == value)
				{
					return;
				}
				_restrictions = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("statusEffectsListener")] 
		public CHandle<HotkeyWidgetStatsListener> StatusEffectsListener
		{
			get
			{
				if (_statusEffectsListener == null)
				{
					_statusEffectsListener = (CHandle<HotkeyWidgetStatsListener>) CR2WTypeManager.Create("handle:HotkeyWidgetStatsListener", "statusEffectsListener", cr2w, this);
				}
				return _statusEffectsListener;
			}
			set
			{
				if (_statusEffectsListener == value)
				{
					return;
				}
				_statusEffectsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("debugCommands")] 
		public CArray<CUInt32> DebugCommands
		{
			get
			{
				if (_debugCommands == null)
				{
					_debugCommands = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "debugCommands", cr2w, this);
				}
				return _debugCommands;
			}
			set
			{
				if (_debugCommands == value)
				{
					return;
				}
				_debugCommands = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("factListenerId")] 
		public CUInt32 FactListenerId
		{
			get
			{
				if (_factListenerId == null)
				{
					_factListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "factListenerId", cr2w, this);
				}
				return _factListenerId;
			}
			set
			{
				if (_factListenerId == value)
				{
					return;
				}
				_factListenerId = value;
				PropertySet(this);
			}
		}

		public GenericHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
