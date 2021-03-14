using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameLogicControllerAdvanced : inkWidgetLogicController
	{
		private CName _playerLibraryName;
		private Vector2 _playerColliderPositionOffset;
		private Vector2 _playerColliderSizeOffset;
		private inkCompoundWidgetReference _gameplayRoot;
		private CFloat _baseSpeed;
		private CArray<inkWidgetReference> _layers;
		private CArray<gameuiSideScrollerCheatCode> _cheatCodes;
		private CArray<CName> _acceptableCheatKeys;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("layers")] 
		public CArray<inkWidgetReference> Layers
		{
			get
			{
				if (_layers == null)
				{
					_layers = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "layers", cr2w, this);
				}
				return _layers;
			}
			set
			{
				if (_layers == value)
				{
					return;
				}
				_layers = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cheatCodes")] 
		public CArray<gameuiSideScrollerCheatCode> CheatCodes
		{
			get
			{
				if (_cheatCodes == null)
				{
					_cheatCodes = (CArray<gameuiSideScrollerCheatCode>) CR2WTypeManager.Create("array:gameuiSideScrollerCheatCode", "cheatCodes", cr2w, this);
				}
				return _cheatCodes;
			}
			set
			{
				if (_cheatCodes == value)
				{
					return;
				}
				_cheatCodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("acceptableCheatKeys")] 
		public CArray<CName> AcceptableCheatKeys
		{
			get
			{
				if (_acceptableCheatKeys == null)
				{
					_acceptableCheatKeys = (CArray<CName>) CR2WTypeManager.Create("array:CName", "acceptableCheatKeys", cr2w, this);
				}
				return _acceptableCheatKeys;
			}
			set
			{
				if (_acceptableCheatKeys == value)
				{
					return;
				}
				_acceptableCheatKeys = value;
				PropertySet(this);
			}
		}

		public gameuiSideScrollerMiniGameLogicControllerAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
