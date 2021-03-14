using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayRoleComponent : gameScriptableComponent
	{
		private CEnum<EGameplayRole> _gameplayRole;
		private CBool _autoDeterminGameplayRole;
		private CEnum<EMappinDisplayMode> _mappinsDisplayMode;
		private CBool _displayAllRolesAsGeneric;
		private CBool _alwaysCreateMappinAsDynamic;
		private CArray<SDeviceMappinData> _mappins;
		private CFloat _offsetValue;
		private CBool _isBeingScanned;
		private CBool _isCurrentTarget;
		private CBool _isShowingMappins;
		private CBool _isHighlightedInFocusMode;
		private CEnum<EGameplayRole> _currentGameplayRole;
		private CBool _isGameplayRoleInitialized;
		private CBool _isForceHidden;
		private CBool _isForcedVisibleThroughWalls;

		[Ordinal(5)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get
			{
				if (_gameplayRole == null)
				{
					_gameplayRole = (CEnum<EGameplayRole>) CR2WTypeManager.Create("EGameplayRole", "gameplayRole", cr2w, this);
				}
				return _gameplayRole;
			}
			set
			{
				if (_gameplayRole == value)
				{
					return;
				}
				_gameplayRole = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("autoDeterminGameplayRole")] 
		public CBool AutoDeterminGameplayRole
		{
			get
			{
				if (_autoDeterminGameplayRole == null)
				{
					_autoDeterminGameplayRole = (CBool) CR2WTypeManager.Create("Bool", "autoDeterminGameplayRole", cr2w, this);
				}
				return _autoDeterminGameplayRole;
			}
			set
			{
				if (_autoDeterminGameplayRole == value)
				{
					return;
				}
				_autoDeterminGameplayRole = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("mappinsDisplayMode")] 
		public CEnum<EMappinDisplayMode> MappinsDisplayMode
		{
			get
			{
				if (_mappinsDisplayMode == null)
				{
					_mappinsDisplayMode = (CEnum<EMappinDisplayMode>) CR2WTypeManager.Create("EMappinDisplayMode", "mappinsDisplayMode", cr2w, this);
				}
				return _mappinsDisplayMode;
			}
			set
			{
				if (_mappinsDisplayMode == value)
				{
					return;
				}
				_mappinsDisplayMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("displayAllRolesAsGeneric")] 
		public CBool DisplayAllRolesAsGeneric
		{
			get
			{
				if (_displayAllRolesAsGeneric == null)
				{
					_displayAllRolesAsGeneric = (CBool) CR2WTypeManager.Create("Bool", "displayAllRolesAsGeneric", cr2w, this);
				}
				return _displayAllRolesAsGeneric;
			}
			set
			{
				if (_displayAllRolesAsGeneric == value)
				{
					return;
				}
				_displayAllRolesAsGeneric = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("alwaysCreateMappinAsDynamic")] 
		public CBool AlwaysCreateMappinAsDynamic
		{
			get
			{
				if (_alwaysCreateMappinAsDynamic == null)
				{
					_alwaysCreateMappinAsDynamic = (CBool) CR2WTypeManager.Create("Bool", "alwaysCreateMappinAsDynamic", cr2w, this);
				}
				return _alwaysCreateMappinAsDynamic;
			}
			set
			{
				if (_alwaysCreateMappinAsDynamic == value)
				{
					return;
				}
				_alwaysCreateMappinAsDynamic = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("mappins")] 
		public CArray<SDeviceMappinData> Mappins
		{
			get
			{
				if (_mappins == null)
				{
					_mappins = (CArray<SDeviceMappinData>) CR2WTypeManager.Create("array:SDeviceMappinData", "mappins", cr2w, this);
				}
				return _mappins;
			}
			set
			{
				if (_mappins == value)
				{
					return;
				}
				_mappins = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("offsetValue")] 
		public CFloat OffsetValue
		{
			get
			{
				if (_offsetValue == null)
				{
					_offsetValue = (CFloat) CR2WTypeManager.Create("Float", "offsetValue", cr2w, this);
				}
				return _offsetValue;
			}
			set
			{
				if (_offsetValue == value)
				{
					return;
				}
				_offsetValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get
			{
				if (_isBeingScanned == null)
				{
					_isBeingScanned = (CBool) CR2WTypeManager.Create("Bool", "isBeingScanned", cr2w, this);
				}
				return _isBeingScanned;
			}
			set
			{
				if (_isBeingScanned == value)
				{
					return;
				}
				_isBeingScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isCurrentTarget")] 
		public CBool IsCurrentTarget
		{
			get
			{
				if (_isCurrentTarget == null)
				{
					_isCurrentTarget = (CBool) CR2WTypeManager.Create("Bool", "isCurrentTarget", cr2w, this);
				}
				return _isCurrentTarget;
			}
			set
			{
				if (_isCurrentTarget == value)
				{
					return;
				}
				_isCurrentTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isShowingMappins")] 
		public CBool IsShowingMappins
		{
			get
			{
				if (_isShowingMappins == null)
				{
					_isShowingMappins = (CBool) CR2WTypeManager.Create("Bool", "isShowingMappins", cr2w, this);
				}
				return _isShowingMappins;
			}
			set
			{
				if (_isShowingMappins == value)
				{
					return;
				}
				_isShowingMappins = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get
			{
				if (_isHighlightedInFocusMode == null)
				{
					_isHighlightedInFocusMode = (CBool) CR2WTypeManager.Create("Bool", "isHighlightedInFocusMode", cr2w, this);
				}
				return _isHighlightedInFocusMode;
			}
			set
			{
				if (_isHighlightedInFocusMode == value)
				{
					return;
				}
				_isHighlightedInFocusMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("currentGameplayRole")] 
		public CEnum<EGameplayRole> CurrentGameplayRole
		{
			get
			{
				if (_currentGameplayRole == null)
				{
					_currentGameplayRole = (CEnum<EGameplayRole>) CR2WTypeManager.Create("EGameplayRole", "currentGameplayRole", cr2w, this);
				}
				return _currentGameplayRole;
			}
			set
			{
				if (_currentGameplayRole == value)
				{
					return;
				}
				_currentGameplayRole = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isGameplayRoleInitialized")] 
		public CBool IsGameplayRoleInitialized
		{
			get
			{
				if (_isGameplayRoleInitialized == null)
				{
					_isGameplayRoleInitialized = (CBool) CR2WTypeManager.Create("Bool", "isGameplayRoleInitialized", cr2w, this);
				}
				return _isGameplayRoleInitialized;
			}
			set
			{
				if (_isGameplayRoleInitialized == value)
				{
					return;
				}
				_isGameplayRoleInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isForceHidden")] 
		public CBool IsForceHidden
		{
			get
			{
				if (_isForceHidden == null)
				{
					_isForceHidden = (CBool) CR2WTypeManager.Create("Bool", "isForceHidden", cr2w, this);
				}
				return _isForceHidden;
			}
			set
			{
				if (_isForceHidden == value)
				{
					return;
				}
				_isForceHidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("isForcedVisibleThroughWalls")] 
		public CBool IsForcedVisibleThroughWalls
		{
			get
			{
				if (_isForcedVisibleThroughWalls == null)
				{
					_isForcedVisibleThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "isForcedVisibleThroughWalls", cr2w, this);
				}
				return _isForcedVisibleThroughWalls;
			}
			set
			{
				if (_isForcedVisibleThroughWalls == value)
				{
					return;
				}
				_isForcedVisibleThroughWalls = value;
				PropertySet(this);
			}
		}

		public GameplayRoleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
