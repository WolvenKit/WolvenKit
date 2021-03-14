using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameLogicController : inkWidgetLogicController
	{
		private CName _gameName;
		private CUInt32 _startHealth;
		private CName _playerLibraryName;
		private Vector2 _playerColliderPositionOffset;
		private Vector2 _playerColliderSizeOffset;
		private inkCompoundWidgetReference _gameplayRoot;
		private CFloat _baseSpeed;
		private CArray<CName> _spawnedListLibraryNames;
		private CBool _isGameRunning;

		[Ordinal(1)] 
		[RED("gameName")] 
		public CName GameName
		{
			get
			{
				if (_gameName == null)
				{
					_gameName = (CName) CR2WTypeManager.Create("CName", "gameName", cr2w, this);
				}
				return _gameName;
			}
			set
			{
				if (_gameName == value)
				{
					return;
				}
				_gameName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startHealth")] 
		public CUInt32 StartHealth
		{
			get
			{
				if (_startHealth == null)
				{
					_startHealth = (CUInt32) CR2WTypeManager.Create("Uint32", "startHealth", cr2w, this);
				}
				return _startHealth;
			}
			set
			{
				if (_startHealth == value)
				{
					return;
				}
				_startHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playerLibraryName")] 
		public CName PlayerLibraryName
		{
			get
			{
				if (_playerLibraryName == null)
				{
					_playerLibraryName = (CName) CR2WTypeManager.Create("CName", "playerLibraryName", cr2w, this);
				}
				return _playerLibraryName;
			}
			set
			{
				if (_playerLibraryName == value)
				{
					return;
				}
				_playerLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerColliderPositionOffset")] 
		public Vector2 PlayerColliderPositionOffset
		{
			get
			{
				if (_playerColliderPositionOffset == null)
				{
					_playerColliderPositionOffset = (Vector2) CR2WTypeManager.Create("Vector2", "playerColliderPositionOffset", cr2w, this);
				}
				return _playerColliderPositionOffset;
			}
			set
			{
				if (_playerColliderPositionOffset == value)
				{
					return;
				}
				_playerColliderPositionOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("playerColliderSizeOffset")] 
		public Vector2 PlayerColliderSizeOffset
		{
			get
			{
				if (_playerColliderSizeOffset == null)
				{
					_playerColliderSizeOffset = (Vector2) CR2WTypeManager.Create("Vector2", "playerColliderSizeOffset", cr2w, this);
				}
				return _playerColliderSizeOffset;
			}
			set
			{
				if (_playerColliderSizeOffset == value)
				{
					return;
				}
				_playerColliderSizeOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gameplayRoot")] 
		public inkCompoundWidgetReference GameplayRoot
		{
			get
			{
				if (_gameplayRoot == null)
				{
					_gameplayRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "gameplayRoot", cr2w, this);
				}
				return _gameplayRoot;
			}
			set
			{
				if (_gameplayRoot == value)
				{
					return;
				}
				_gameplayRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get
			{
				if (_baseSpeed == null)
				{
					_baseSpeed = (CFloat) CR2WTypeManager.Create("Float", "baseSpeed", cr2w, this);
				}
				return _baseSpeed;
			}
			set
			{
				if (_baseSpeed == value)
				{
					return;
				}
				_baseSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("spawnedListLibraryNames")] 
		public CArray<CName> SpawnedListLibraryNames
		{
			get
			{
				if (_spawnedListLibraryNames == null)
				{
					_spawnedListLibraryNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "spawnedListLibraryNames", cr2w, this);
				}
				return _spawnedListLibraryNames;
			}
			set
			{
				if (_spawnedListLibraryNames == value)
				{
					return;
				}
				_spawnedListLibraryNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isGameRunning")] 
		public CBool IsGameRunning
		{
			get
			{
				if (_isGameRunning == null)
				{
					_isGameRunning = (CBool) CR2WTypeManager.Create("Bool", "isGameRunning", cr2w, this);
				}
				return _isGameRunning;
			}
			set
			{
				if (_isGameRunning == value)
				{
					return;
				}
				_isGameRunning = value;
				PropertySet(this);
			}
		}

		public gameuiSideScrollerMiniGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
