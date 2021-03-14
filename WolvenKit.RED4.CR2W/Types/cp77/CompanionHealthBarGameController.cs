using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CompanionHealthBarGameController : gameuiHUDGameController
	{
		private inkWidgetReference _healthbar;
		private wCHandle<inkWidget> _root;
		private CUInt32 _flatheadListener;
		private CBool _isActive;
		private CFloat _maxHealth;
		private CHandle<CompanionHealthStatListener> _healthStatListener;
		private CHandle<gameIBlackboard> _companionBlackboard;
		private ScriptGameInstance _gameInstance;
		private CHandle<gameStatPoolsSystem> _statSystem;

		[Ordinal(9)] 
		[RED("healthbar")] 
		public inkWidgetReference Healthbar
		{
			get
			{
				if (_healthbar == null)
				{
					_healthbar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "healthbar", cr2w, this);
				}
				return _healthbar;
			}
			set
			{
				if (_healthbar == value)
				{
					return;
				}
				_healthbar = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
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

		[Ordinal(11)] 
		[RED("flatheadListener")] 
		public CUInt32 FlatheadListener
		{
			get
			{
				if (_flatheadListener == null)
				{
					_flatheadListener = (CUInt32) CR2WTypeManager.Create("Uint32", "flatheadListener", cr2w, this);
				}
				return _flatheadListener;
			}
			set
			{
				if (_flatheadListener == value)
				{
					return;
				}
				_flatheadListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("maxHealth")] 
		public CFloat MaxHealth
		{
			get
			{
				if (_maxHealth == null)
				{
					_maxHealth = (CFloat) CR2WTypeManager.Create("Float", "maxHealth", cr2w, this);
				}
				return _maxHealth;
			}
			set
			{
				if (_maxHealth == value)
				{
					return;
				}
				_maxHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("healthStatListener")] 
		public CHandle<CompanionHealthStatListener> HealthStatListener
		{
			get
			{
				if (_healthStatListener == null)
				{
					_healthStatListener = (CHandle<CompanionHealthStatListener>) CR2WTypeManager.Create("handle:CompanionHealthStatListener", "healthStatListener", cr2w, this);
				}
				return _healthStatListener;
			}
			set
			{
				if (_healthStatListener == value)
				{
					return;
				}
				_healthStatListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("companionBlackboard")] 
		public CHandle<gameIBlackboard> CompanionBlackboard
		{
			get
			{
				if (_companionBlackboard == null)
				{
					_companionBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "companionBlackboard", cr2w, this);
				}
				return _companionBlackboard;
			}
			set
			{
				if (_companionBlackboard == value)
				{
					return;
				}
				_companionBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("statSystem")] 
		public CHandle<gameStatPoolsSystem> StatSystem
		{
			get
			{
				if (_statSystem == null)
				{
					_statSystem = (CHandle<gameStatPoolsSystem>) CR2WTypeManager.Create("handle:gameStatPoolsSystem", "statSystem", cr2w, this);
				}
				return _statSystem;
			}
			set
			{
				if (_statSystem == value)
				{
					return;
				}
				_statSystem = value;
				PropertySet(this);
			}
		}

		public CompanionHealthBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
