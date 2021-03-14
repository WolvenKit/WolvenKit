using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		private inkWidgetReference _projection;
		private inkWidgetReference _displayName;
		private inkWidgetReference _iconHolder;
		private inkWidgetReference _mappinSlot;
		private inkWidgetReference _chattersSlot;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private wCHandle<NameplateVisualsLogicController> _visualController;
		private CArray<wCHandle<gameuiMappinBaseController>> _cachedMappinControllers;
		private CBool _visualControllerNeedsMappinsUpdate;
		private CHandle<inkScreenProjection> _nameplateProjection;
		private CHandle<inkScreenProjection> _nameplateProjectionCloseOffset;
		private wCHandle<gameObject> _bufferedNPC;
		private CHandle<gamedataCharacter_Record> _bufferedCharacterRecord;
		private CBool _isScanning;
		private CBool _isNewNPC;
		private CEnum<EAIAttitude> _attitude;
		private CFloat _zoom;
		private CInt32 _currentHealth;
		private CInt32 _maximumHealth;
		private CFloat _c_DisplayRange;
		private CFloat _c_MaxDisplayRange;
		private CFloat _c_MaxDisplayRangeNotAggressive;
		private CFloat _c_DisplayRangeNotAggressive;
		private CUInt32 _bbNameplateData;
		private CUInt32 _bbBuffsList;
		private CUInt32 _bbDebuffsList;
		private CUInt32 _bbHighLevelStateID;
		private CUInt32 _visionStateBlackboardId;
		private CUInt32 _zoomStateBlackboardId;
		private CUInt32 _playerZonesBlackboardID;
		private CUInt32 _playerCombatBlackboardID;
		private CUInt32 _playerAimStatusBlackboardID;
		private CUInt32 _damagePreviewBlackboardID;
		private CHandle<gameIBlackboard> _uiBlackboardTargetNPC;
		private CHandle<gameIBlackboard> _uiBlackboardInteractions;

		[Ordinal(9)] 
		[RED("projection")] 
		public inkWidgetReference Projection
		{
			get
			{
				if (_projection == null)
				{
					_projection = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "projection", cr2w, this);
				}
				return _projection;
			}
			set
			{
				if (_projection == value)
				{
					return;
				}
				_projection = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("displayName")] 
		public inkWidgetReference DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("iconHolder")] 
		public inkWidgetReference IconHolder
		{
			get
			{
				if (_iconHolder == null)
				{
					_iconHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "iconHolder", cr2w, this);
				}
				return _iconHolder;
			}
			set
			{
				if (_iconHolder == value)
				{
					return;
				}
				_iconHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("mappinSlot")] 
		public inkWidgetReference MappinSlot
		{
			get
			{
				if (_mappinSlot == null)
				{
					_mappinSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "mappinSlot", cr2w, this);
				}
				return _mappinSlot;
			}
			set
			{
				if (_mappinSlot == value)
				{
					return;
				}
				_mappinSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("chattersSlot")] 
		public inkWidgetReference ChattersSlot
		{
			get
			{
				if (_chattersSlot == null)
				{
					_chattersSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "chattersSlot", cr2w, this);
				}
				return _chattersSlot;
			}
			set
			{
				if (_chattersSlot == value)
				{
					return;
				}
				_chattersSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("visualController")] 
		public wCHandle<NameplateVisualsLogicController> VisualController
		{
			get
			{
				if (_visualController == null)
				{
					_visualController = (wCHandle<NameplateVisualsLogicController>) CR2WTypeManager.Create("whandle:NameplateVisualsLogicController", "visualController", cr2w, this);
				}
				return _visualController;
			}
			set
			{
				if (_visualController == value)
				{
					return;
				}
				_visualController = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("cachedMappinControllers")] 
		public CArray<wCHandle<gameuiMappinBaseController>> CachedMappinControllers
		{
			get
			{
				if (_cachedMappinControllers == null)
				{
					_cachedMappinControllers = (CArray<wCHandle<gameuiMappinBaseController>>) CR2WTypeManager.Create("array:whandle:gameuiMappinBaseController", "cachedMappinControllers", cr2w, this);
				}
				return _cachedMappinControllers;
			}
			set
			{
				if (_cachedMappinControllers == value)
				{
					return;
				}
				_cachedMappinControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("visualControllerNeedsMappinsUpdate")] 
		public CBool VisualControllerNeedsMappinsUpdate
		{
			get
			{
				if (_visualControllerNeedsMappinsUpdate == null)
				{
					_visualControllerNeedsMappinsUpdate = (CBool) CR2WTypeManager.Create("Bool", "visualControllerNeedsMappinsUpdate", cr2w, this);
				}
				return _visualControllerNeedsMappinsUpdate;
			}
			set
			{
				if (_visualControllerNeedsMappinsUpdate == value)
				{
					return;
				}
				_visualControllerNeedsMappinsUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("nameplateProjection")] 
		public CHandle<inkScreenProjection> NameplateProjection
		{
			get
			{
				if (_nameplateProjection == null)
				{
					_nameplateProjection = (CHandle<inkScreenProjection>) CR2WTypeManager.Create("handle:inkScreenProjection", "nameplateProjection", cr2w, this);
				}
				return _nameplateProjection;
			}
			set
			{
				if (_nameplateProjection == value)
				{
					return;
				}
				_nameplateProjection = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("nameplateProjectionCloseOffset")] 
		public CHandle<inkScreenProjection> NameplateProjectionCloseOffset
		{
			get
			{
				if (_nameplateProjectionCloseOffset == null)
				{
					_nameplateProjectionCloseOffset = (CHandle<inkScreenProjection>) CR2WTypeManager.Create("handle:inkScreenProjection", "nameplateProjectionCloseOffset", cr2w, this);
				}
				return _nameplateProjectionCloseOffset;
			}
			set
			{
				if (_nameplateProjectionCloseOffset == value)
				{
					return;
				}
				_nameplateProjectionCloseOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("bufferedNPC")] 
		public wCHandle<gameObject> BufferedNPC
		{
			get
			{
				if (_bufferedNPC == null)
				{
					_bufferedNPC = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "bufferedNPC", cr2w, this);
				}
				return _bufferedNPC;
			}
			set
			{
				if (_bufferedNPC == value)
				{
					return;
				}
				_bufferedNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("bufferedCharacterRecord")] 
		public CHandle<gamedataCharacter_Record> BufferedCharacterRecord
		{
			get
			{
				if (_bufferedCharacterRecord == null)
				{
					_bufferedCharacterRecord = (CHandle<gamedataCharacter_Record>) CR2WTypeManager.Create("handle:gamedataCharacter_Record", "bufferedCharacterRecord", cr2w, this);
				}
				return _bufferedCharacterRecord;
			}
			set
			{
				if (_bufferedCharacterRecord == value)
				{
					return;
				}
				_bufferedCharacterRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get
			{
				if (_isScanning == null)
				{
					_isScanning = (CBool) CR2WTypeManager.Create("Bool", "isScanning", cr2w, this);
				}
				return _isScanning;
			}
			set
			{
				if (_isScanning == value)
				{
					return;
				}
				_isScanning = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isNewNPC")] 
		public CBool IsNewNPC
		{
			get
			{
				if (_isNewNPC == null)
				{
					_isNewNPC = (CBool) CR2WTypeManager.Create("Bool", "isNewNPC", cr2w, this);
				}
				return _isNewNPC;
			}
			set
			{
				if (_isNewNPC == value)
				{
					return;
				}
				_isNewNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get
			{
				if (_attitude == null)
				{
					_attitude = (CEnum<EAIAttitude>) CR2WTypeManager.Create("EAIAttitude", "attitude", cr2w, this);
				}
				return _attitude;
			}
			set
			{
				if (_attitude == value)
				{
					return;
				}
				_attitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get
			{
				if (_zoom == null)
				{
					_zoom = (CFloat) CR2WTypeManager.Create("Float", "zoom", cr2w, this);
				}
				return _zoom;
			}
			set
			{
				if (_zoom == value)
				{
					return;
				}
				_zoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get
			{
				if (_currentHealth == null)
				{
					_currentHealth = (CInt32) CR2WTypeManager.Create("Int32", "currentHealth", cr2w, this);
				}
				return _currentHealth;
			}
			set
			{
				if (_currentHealth == value)
				{
					return;
				}
				_currentHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get
			{
				if (_maximumHealth == null)
				{
					_maximumHealth = (CInt32) CR2WTypeManager.Create("Int32", "maximumHealth", cr2w, this);
				}
				return _maximumHealth;
			}
			set
			{
				if (_maximumHealth == value)
				{
					return;
				}
				_maximumHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get
			{
				if (_c_DisplayRange == null)
				{
					_c_DisplayRange = (CFloat) CR2WTypeManager.Create("Float", "c_DisplayRange", cr2w, this);
				}
				return _c_DisplayRange;
			}
			set
			{
				if (_c_DisplayRange == value)
				{
					return;
				}
				_c_DisplayRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("c_MaxDisplayRange")] 
		public CFloat C_MaxDisplayRange
		{
			get
			{
				if (_c_MaxDisplayRange == null)
				{
					_c_MaxDisplayRange = (CFloat) CR2WTypeManager.Create("Float", "c_MaxDisplayRange", cr2w, this);
				}
				return _c_MaxDisplayRange;
			}
			set
			{
				if (_c_MaxDisplayRange == value)
				{
					return;
				}
				_c_MaxDisplayRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("c_MaxDisplayRangeNotAggressive")] 
		public CFloat C_MaxDisplayRangeNotAggressive
		{
			get
			{
				if (_c_MaxDisplayRangeNotAggressive == null)
				{
					_c_MaxDisplayRangeNotAggressive = (CFloat) CR2WTypeManager.Create("Float", "c_MaxDisplayRangeNotAggressive", cr2w, this);
				}
				return _c_MaxDisplayRangeNotAggressive;
			}
			set
			{
				if (_c_MaxDisplayRangeNotAggressive == value)
				{
					return;
				}
				_c_MaxDisplayRangeNotAggressive = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("c_DisplayRangeNotAggressive")] 
		public CFloat C_DisplayRangeNotAggressive
		{
			get
			{
				if (_c_DisplayRangeNotAggressive == null)
				{
					_c_DisplayRangeNotAggressive = (CFloat) CR2WTypeManager.Create("Float", "c_DisplayRangeNotAggressive", cr2w, this);
				}
				return _c_DisplayRangeNotAggressive;
			}
			set
			{
				if (_c_DisplayRangeNotAggressive == value)
				{
					return;
				}
				_c_DisplayRangeNotAggressive = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("bbNameplateData")] 
		public CUInt32 BbNameplateData
		{
			get
			{
				if (_bbNameplateData == null)
				{
					_bbNameplateData = (CUInt32) CR2WTypeManager.Create("Uint32", "bbNameplateData", cr2w, this);
				}
				return _bbNameplateData;
			}
			set
			{
				if (_bbNameplateData == value)
				{
					return;
				}
				_bbNameplateData = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("bbBuffsList")] 
		public CUInt32 BbBuffsList
		{
			get
			{
				if (_bbBuffsList == null)
				{
					_bbBuffsList = (CUInt32) CR2WTypeManager.Create("Uint32", "bbBuffsList", cr2w, this);
				}
				return _bbBuffsList;
			}
			set
			{
				if (_bbBuffsList == value)
				{
					return;
				}
				_bbBuffsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("bbDebuffsList")] 
		public CUInt32 BbDebuffsList
		{
			get
			{
				if (_bbDebuffsList == null)
				{
					_bbDebuffsList = (CUInt32) CR2WTypeManager.Create("Uint32", "bbDebuffsList", cr2w, this);
				}
				return _bbDebuffsList;
			}
			set
			{
				if (_bbDebuffsList == value)
				{
					return;
				}
				_bbDebuffsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("bbHighLevelStateID")] 
		public CUInt32 BbHighLevelStateID
		{
			get
			{
				if (_bbHighLevelStateID == null)
				{
					_bbHighLevelStateID = (CUInt32) CR2WTypeManager.Create("Uint32", "bbHighLevelStateID", cr2w, this);
				}
				return _bbHighLevelStateID;
			}
			set
			{
				if (_bbHighLevelStateID == value)
				{
					return;
				}
				_bbHighLevelStateID = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("VisionStateBlackboardId")] 
		public CUInt32 VisionStateBlackboardId
		{
			get
			{
				if (_visionStateBlackboardId == null)
				{
					_visionStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "VisionStateBlackboardId", cr2w, this);
				}
				return _visionStateBlackboardId;
			}
			set
			{
				if (_visionStateBlackboardId == value)
				{
					return;
				}
				_visionStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("ZoomStateBlackboardId")] 
		public CUInt32 ZoomStateBlackboardId
		{
			get
			{
				if (_zoomStateBlackboardId == null)
				{
					_zoomStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "ZoomStateBlackboardId", cr2w, this);
				}
				return _zoomStateBlackboardId;
			}
			set
			{
				if (_zoomStateBlackboardId == value)
				{
					return;
				}
				_zoomStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("playerZonesBlackboardID")] 
		public CUInt32 PlayerZonesBlackboardID
		{
			get
			{
				if (_playerZonesBlackboardID == null)
				{
					_playerZonesBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerZonesBlackboardID", cr2w, this);
				}
				return _playerZonesBlackboardID;
			}
			set
			{
				if (_playerZonesBlackboardID == value)
				{
					return;
				}
				_playerZonesBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("playerCombatBlackboardID")] 
		public CUInt32 PlayerCombatBlackboardID
		{
			get
			{
				if (_playerCombatBlackboardID == null)
				{
					_playerCombatBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerCombatBlackboardID", cr2w, this);
				}
				return _playerCombatBlackboardID;
			}
			set
			{
				if (_playerCombatBlackboardID == value)
				{
					return;
				}
				_playerCombatBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("playerAimStatusBlackboardID")] 
		public CUInt32 PlayerAimStatusBlackboardID
		{
			get
			{
				if (_playerAimStatusBlackboardID == null)
				{
					_playerAimStatusBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerAimStatusBlackboardID", cr2w, this);
				}
				return _playerAimStatusBlackboardID;
			}
			set
			{
				if (_playerAimStatusBlackboardID == value)
				{
					return;
				}
				_playerAimStatusBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("damagePreviewBlackboardID")] 
		public CUInt32 DamagePreviewBlackboardID
		{
			get
			{
				if (_damagePreviewBlackboardID == null)
				{
					_damagePreviewBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "damagePreviewBlackboardID", cr2w, this);
				}
				return _damagePreviewBlackboardID;
			}
			set
			{
				if (_damagePreviewBlackboardID == value)
				{
					return;
				}
				_damagePreviewBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("uiBlackboardTargetNPC")] 
		public CHandle<gameIBlackboard> UiBlackboardTargetNPC
		{
			get
			{
				if (_uiBlackboardTargetNPC == null)
				{
					_uiBlackboardTargetNPC = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBlackboardTargetNPC", cr2w, this);
				}
				return _uiBlackboardTargetNPC;
			}
			set
			{
				if (_uiBlackboardTargetNPC == value)
				{
					return;
				}
				_uiBlackboardTargetNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("uiBlackboardInteractions")] 
		public CHandle<gameIBlackboard> UiBlackboardInteractions
		{
			get
			{
				if (_uiBlackboardInteractions == null)
				{
					_uiBlackboardInteractions = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBlackboardInteractions", cr2w, this);
				}
				return _uiBlackboardInteractions;
			}
			set
			{
				if (_uiBlackboardInteractions == value)
				{
					return;
				}
				_uiBlackboardInteractions = value;
				PropertySet(this);
			}
		}

		public gameuiNpcNameplateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
