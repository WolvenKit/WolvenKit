using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeysWidgetController : gameuiHUDGameController
	{
		private inkHorizontalPanelWidgetReference _hotkeysList;
		private inkHorizontalPanelWidgetReference _utilsList;
		private wCHandle<inkWidget> _phone;
		private wCHandle<inkWidget> _car;
		private wCHandle<inkWidget> _consumables;
		private wCHandle<inkWidget> _gadgets;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<inkCompoundWidget> _root;
		private ScriptGameInstance _gameInstance;
		private CUInt32 _fact1ListenerId;
		private CUInt32 _fact2ListenerId;

		[Ordinal(9)] 
		[RED("hotkeysList")] 
		public inkHorizontalPanelWidgetReference HotkeysList
		{
			get
			{
				if (_hotkeysList == null)
				{
					_hotkeysList = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "hotkeysList", cr2w, this);
				}
				return _hotkeysList;
			}
			set
			{
				if (_hotkeysList == value)
				{
					return;
				}
				_hotkeysList = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("utilsList")] 
		public inkHorizontalPanelWidgetReference UtilsList
		{
			get
			{
				if (_utilsList == null)
				{
					_utilsList = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "utilsList", cr2w, this);
				}
				return _utilsList;
			}
			set
			{
				if (_utilsList == value)
				{
					return;
				}
				_utilsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("phone")] 
		public wCHandle<inkWidget> Phone
		{
			get
			{
				if (_phone == null)
				{
					_phone = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "phone", cr2w, this);
				}
				return _phone;
			}
			set
			{
				if (_phone == value)
				{
					return;
				}
				_phone = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("car")] 
		public wCHandle<inkWidget> Car
		{
			get
			{
				if (_car == null)
				{
					_car = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "car", cr2w, this);
				}
				return _car;
			}
			set
			{
				if (_car == value)
				{
					return;
				}
				_car = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("consumables")] 
		public wCHandle<inkWidget> Consumables
		{
			get
			{
				if (_consumables == null)
				{
					_consumables = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "consumables", cr2w, this);
				}
				return _consumables;
			}
			set
			{
				if (_consumables == value)
				{
					return;
				}
				_consumables = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("gadgets")] 
		public wCHandle<inkWidget> Gadgets
		{
			get
			{
				if (_gadgets == null)
				{
					_gadgets = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "gadgets", cr2w, this);
				}
				return _gadgets;
			}
			set
			{
				if (_gadgets == value)
				{
					return;
				}
				_gadgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("fact1ListenerId")] 
		public CUInt32 Fact1ListenerId
		{
			get
			{
				if (_fact1ListenerId == null)
				{
					_fact1ListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "fact1ListenerId", cr2w, this);
				}
				return _fact1ListenerId;
			}
			set
			{
				if (_fact1ListenerId == value)
				{
					return;
				}
				_fact1ListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("fact2ListenerId")] 
		public CUInt32 Fact2ListenerId
		{
			get
			{
				if (_fact2ListenerId == null)
				{
					_fact2ListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "fact2ListenerId", cr2w, this);
				}
				return _fact2ListenerId;
			}
			set
			{
				if (_fact2ListenerId == value)
				{
					return;
				}
				_fact2ListenerId = value;
				PropertySet(this);
			}
		}

		public HotkeysWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
