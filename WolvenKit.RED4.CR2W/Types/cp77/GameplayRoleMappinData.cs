using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayRoleMappinData : gamemappinsMappinScriptData
	{
		private CEnum<EMappinVisualState> _mappinVisualState;
		private CBool _isTagged;
		private CBool _isQuest;
		private CBool _isIconic;
		private CBool _isScanningCluesBlocked;
		private CBool _isCurrentTarget;
		private CBool _visibleThroughWalls;
		private CBool _hasOffscreenArrow;
		private CFloat _range;
		private CFloat _duration;
		private CEnum<EProgressBarType> _progressBarType;
		private CEnum<EProgressBarContext> _progressBarContext;
		private CEnum<EGameplayRole> _gameplayRole;
		private CEnum<braindanceVisionMode> _braindanceLayer;
		private CEnum<gamedataQuality> _quality;
		private CName _slotName;
		private TweakDBID _textureID;

		[Ordinal(1)] 
		[RED("mappinVisualState")] 
		public CEnum<EMappinVisualState> MappinVisualState
		{
			get
			{
				if (_mappinVisualState == null)
				{
					_mappinVisualState = (CEnum<EMappinVisualState>) CR2WTypeManager.Create("EMappinVisualState", "mappinVisualState", cr2w, this);
				}
				return _mappinVisualState;
			}
			set
			{
				if (_mappinVisualState == value)
				{
					return;
				}
				_mappinVisualState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get
			{
				if (_isTagged == null)
				{
					_isTagged = (CBool) CR2WTypeManager.Create("Bool", "isTagged", cr2w, this);
				}
				return _isTagged;
			}
			set
			{
				if (_isTagged == value)
				{
					return;
				}
				_isTagged = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get
			{
				if (_isQuest == null)
				{
					_isQuest = (CBool) CR2WTypeManager.Create("Bool", "isQuest", cr2w, this);
				}
				return _isQuest;
			}
			set
			{
				if (_isQuest == value)
				{
					return;
				}
				_isQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get
			{
				if (_isIconic == null)
				{
					_isIconic = (CBool) CR2WTypeManager.Create("Bool", "isIconic", cr2w, this);
				}
				return _isIconic;
			}
			set
			{
				if (_isIconic == value)
				{
					return;
				}
				_isIconic = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get
			{
				if (_isScanningCluesBlocked == null)
				{
					_isScanningCluesBlocked = (CBool) CR2WTypeManager.Create("Bool", "isScanningCluesBlocked", cr2w, this);
				}
				return _isScanningCluesBlocked;
			}
			set
			{
				if (_isScanningCluesBlocked == value)
				{
					return;
				}
				_isScanningCluesBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get
			{
				if (_visibleThroughWalls == null)
				{
					_visibleThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "visibleThroughWalls", cr2w, this);
				}
				return _visibleThroughWalls;
			}
			set
			{
				if (_visibleThroughWalls == value)
				{
					return;
				}
				_visibleThroughWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hasOffscreenArrow")] 
		public CBool HasOffscreenArrow
		{
			get
			{
				if (_hasOffscreenArrow == null)
				{
					_hasOffscreenArrow = (CBool) CR2WTypeManager.Create("Bool", "hasOffscreenArrow", cr2w, this);
				}
				return _hasOffscreenArrow;
			}
			set
			{
				if (_hasOffscreenArrow == value)
				{
					return;
				}
				_hasOffscreenArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("progressBarType")] 
		public CEnum<EProgressBarType> ProgressBarType
		{
			get
			{
				if (_progressBarType == null)
				{
					_progressBarType = (CEnum<EProgressBarType>) CR2WTypeManager.Create("EProgressBarType", "progressBarType", cr2w, this);
				}
				return _progressBarType;
			}
			set
			{
				if (_progressBarType == value)
				{
					return;
				}
				_progressBarType = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("progressBarContext")] 
		public CEnum<EProgressBarContext> ProgressBarContext
		{
			get
			{
				if (_progressBarContext == null)
				{
					_progressBarContext = (CEnum<EProgressBarContext>) CR2WTypeManager.Create("EProgressBarContext", "progressBarContext", cr2w, this);
				}
				return _progressBarContext;
			}
			set
			{
				if (_progressBarContext == value)
				{
					return;
				}
				_progressBarContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("braindanceLayer")] 
		public CEnum<braindanceVisionMode> BraindanceLayer
		{
			get
			{
				if (_braindanceLayer == null)
				{
					_braindanceLayer = (CEnum<braindanceVisionMode>) CR2WTypeManager.Create("braindanceVisionMode", "braindanceLayer", cr2w, this);
				}
				return _braindanceLayer;
			}
			set
			{
				if (_braindanceLayer == value)
				{
					return;
				}
				_braindanceLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "quality", cr2w, this);
				}
				return _quality;
			}
			set
			{
				if (_quality == value)
				{
					return;
				}
				_quality = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("textureID")] 
		public TweakDBID TextureID
		{
			get
			{
				if (_textureID == null)
				{
					_textureID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "textureID", cr2w, this);
				}
				return _textureID;
			}
			set
			{
				if (_textureID == value)
				{
					return;
				}
				_textureID = value;
				PropertySet(this);
			}
		}

		public GameplayRoleMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
