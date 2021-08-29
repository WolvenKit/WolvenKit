using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		private inkWidgetReference _projection;
		private inkWidgetReference _displayName;
		private inkWidgetReference _iconHolder;
		private inkWidgetReference _mappinSlot;
		private inkWidgetReference _chattersSlot;
		private CWeakHandle<inkCompoundWidget> _rootWidget;
		private CWeakHandle<NameplateVisualsLogicController> _visualController;
		private CArray<CWeakHandle<gameuiMappinBaseController>> _cachedMappinControllers;
		private CBool _visualControllerNeedsMappinsUpdate;
		private CHandle<inkScreenProjection> _nameplateProjection;
		private CHandle<inkScreenProjection> _nameplateProjectionCloseDistance;
		private CHandle<inkScreenProjection> _nameplateProjectionDevice;
		private CHandle<inkScreenProjection> _nameplateProjectionDeviceCloseDistance;
		private CWeakHandle<gameObject> _bufferedGameObject;
		private CBool _bufferedPuppetHideNameTag;
		private CHandle<gamedataUINameplate_Record> _bufferedCharacterNamePlateRecord;
		private CBool _isScanning;
		private CBool _isNewNPC;
		private CEnum<EAIAttitude> _attitude;
		private CHandle<UI_NameplateDataDef> _uI_NameplateDataDef;
		private CFloat _zoom;
		private CInt32 _currentHealth;
		private CInt32 _maximumHealth;
		private CFloat _c_DisplayRange;
		private CFloat _c_MaxDisplayRange;
		private CFloat _c_MaxDisplayRangeNotAggressive;
		private CFloat _c_DisplayRangeNotAggressive;
		private CHandle<redCallbackObject> _bbNameplateData;
		private CHandle<redCallbackObject> _bbBuffsList;
		private CHandle<redCallbackObject> _bbDebuffsList;
		private CHandle<redCallbackObject> _bbHighLevelStateID;
		private CHandle<redCallbackObject> _bbNPCNamesEnabledID;
		private CHandle<redCallbackObject> _visionStateBlackboardId;
		private CHandle<redCallbackObject> _zoomStateBlackboardId;
		private CHandle<redCallbackObject> _playerZonesBlackboardID;
		private CHandle<redCallbackObject> _playerCombatBlackboardID;
		private CHandle<redCallbackObject> _playerAimStatusBlackboardID;
		private CHandle<redCallbackObject> _damagePreviewBlackboardID;
		private CWeakHandle<gameIBlackboard> _uiBlackboardTargetNPC;
		private CWeakHandle<gameIBlackboard> _uiBlackboardInteractions;
		private CWeakHandle<gameIBlackboard> _interfaceOptionsBlackboard;
		private CWeakHandle<gameIBlackboard> _uiBlackboardNameplateBlackboard;
		private CFloat _nextDistanceCheckTime;

		[Ordinal(9)] 
		[RED("projection")] 
		public inkWidgetReference Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}

		[Ordinal(10)] 
		[RED("displayName")] 
		public inkWidgetReference DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(11)] 
		[RED("iconHolder")] 
		public inkWidgetReference IconHolder
		{
			get => GetProperty(ref _iconHolder);
			set => SetProperty(ref _iconHolder, value);
		}

		[Ordinal(12)] 
		[RED("mappinSlot")] 
		public inkWidgetReference MappinSlot
		{
			get => GetProperty(ref _mappinSlot);
			set => SetProperty(ref _mappinSlot, value);
		}

		[Ordinal(13)] 
		[RED("chattersSlot")] 
		public inkWidgetReference ChattersSlot
		{
			get => GetProperty(ref _chattersSlot);
			set => SetProperty(ref _chattersSlot, value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("visualController")] 
		public CWeakHandle<NameplateVisualsLogicController> VisualController
		{
			get => GetProperty(ref _visualController);
			set => SetProperty(ref _visualController, value);
		}

		[Ordinal(16)] 
		[RED("cachedMappinControllers")] 
		public CArray<CWeakHandle<gameuiMappinBaseController>> CachedMappinControllers
		{
			get => GetProperty(ref _cachedMappinControllers);
			set => SetProperty(ref _cachedMappinControllers, value);
		}

		[Ordinal(17)] 
		[RED("visualControllerNeedsMappinsUpdate")] 
		public CBool VisualControllerNeedsMappinsUpdate
		{
			get => GetProperty(ref _visualControllerNeedsMappinsUpdate);
			set => SetProperty(ref _visualControllerNeedsMappinsUpdate, value);
		}

		[Ordinal(18)] 
		[RED("nameplateProjection")] 
		public CHandle<inkScreenProjection> NameplateProjection
		{
			get => GetProperty(ref _nameplateProjection);
			set => SetProperty(ref _nameplateProjection, value);
		}

		[Ordinal(19)] 
		[RED("nameplateProjectionCloseDistance")] 
		public CHandle<inkScreenProjection> NameplateProjectionCloseDistance
		{
			get => GetProperty(ref _nameplateProjectionCloseDistance);
			set => SetProperty(ref _nameplateProjectionCloseDistance, value);
		}

		[Ordinal(20)] 
		[RED("nameplateProjectionDevice")] 
		public CHandle<inkScreenProjection> NameplateProjectionDevice
		{
			get => GetProperty(ref _nameplateProjectionDevice);
			set => SetProperty(ref _nameplateProjectionDevice, value);
		}

		[Ordinal(21)] 
		[RED("nameplateProjectionDeviceCloseDistance")] 
		public CHandle<inkScreenProjection> NameplateProjectionDeviceCloseDistance
		{
			get => GetProperty(ref _nameplateProjectionDeviceCloseDistance);
			set => SetProperty(ref _nameplateProjectionDeviceCloseDistance, value);
		}

		[Ordinal(22)] 
		[RED("bufferedGameObject")] 
		public CWeakHandle<gameObject> BufferedGameObject
		{
			get => GetProperty(ref _bufferedGameObject);
			set => SetProperty(ref _bufferedGameObject, value);
		}

		[Ordinal(23)] 
		[RED("bufferedPuppetHideNameTag")] 
		public CBool BufferedPuppetHideNameTag
		{
			get => GetProperty(ref _bufferedPuppetHideNameTag);
			set => SetProperty(ref _bufferedPuppetHideNameTag, value);
		}

		[Ordinal(24)] 
		[RED("bufferedCharacterNamePlateRecord")] 
		public CHandle<gamedataUINameplate_Record> BufferedCharacterNamePlateRecord
		{
			get => GetProperty(ref _bufferedCharacterNamePlateRecord);
			set => SetProperty(ref _bufferedCharacterNamePlateRecord, value);
		}

		[Ordinal(25)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetProperty(ref _isScanning);
			set => SetProperty(ref _isScanning, value);
		}

		[Ordinal(26)] 
		[RED("isNewNPC")] 
		public CBool IsNewNPC
		{
			get => GetProperty(ref _isNewNPC);
			set => SetProperty(ref _isNewNPC, value);
		}

		[Ordinal(27)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		[Ordinal(28)] 
		[RED("UI_NameplateDataDef")] 
		public CHandle<UI_NameplateDataDef> UI_NameplateDataDef
		{
			get => GetProperty(ref _uI_NameplateDataDef);
			set => SetProperty(ref _uI_NameplateDataDef, value);
		}

		[Ordinal(29)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get => GetProperty(ref _zoom);
			set => SetProperty(ref _zoom, value);
		}

		[Ordinal(30)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(31)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(32)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get => GetProperty(ref _c_DisplayRange);
			set => SetProperty(ref _c_DisplayRange, value);
		}

		[Ordinal(33)] 
		[RED("c_MaxDisplayRange")] 
		public CFloat C_MaxDisplayRange
		{
			get => GetProperty(ref _c_MaxDisplayRange);
			set => SetProperty(ref _c_MaxDisplayRange, value);
		}

		[Ordinal(34)] 
		[RED("c_MaxDisplayRangeNotAggressive")] 
		public CFloat C_MaxDisplayRangeNotAggressive
		{
			get => GetProperty(ref _c_MaxDisplayRangeNotAggressive);
			set => SetProperty(ref _c_MaxDisplayRangeNotAggressive, value);
		}

		[Ordinal(35)] 
		[RED("c_DisplayRangeNotAggressive")] 
		public CFloat C_DisplayRangeNotAggressive
		{
			get => GetProperty(ref _c_DisplayRangeNotAggressive);
			set => SetProperty(ref _c_DisplayRangeNotAggressive, value);
		}

		[Ordinal(36)] 
		[RED("bbNameplateData")] 
		public CHandle<redCallbackObject> BbNameplateData
		{
			get => GetProperty(ref _bbNameplateData);
			set => SetProperty(ref _bbNameplateData, value);
		}

		[Ordinal(37)] 
		[RED("bbBuffsList")] 
		public CHandle<redCallbackObject> BbBuffsList
		{
			get => GetProperty(ref _bbBuffsList);
			set => SetProperty(ref _bbBuffsList, value);
		}

		[Ordinal(38)] 
		[RED("bbDebuffsList")] 
		public CHandle<redCallbackObject> BbDebuffsList
		{
			get => GetProperty(ref _bbDebuffsList);
			set => SetProperty(ref _bbDebuffsList, value);
		}

		[Ordinal(39)] 
		[RED("bbHighLevelStateID")] 
		public CHandle<redCallbackObject> BbHighLevelStateID
		{
			get => GetProperty(ref _bbHighLevelStateID);
			set => SetProperty(ref _bbHighLevelStateID, value);
		}

		[Ordinal(40)] 
		[RED("bbNPCNamesEnabledID")] 
		public CHandle<redCallbackObject> BbNPCNamesEnabledID
		{
			get => GetProperty(ref _bbNPCNamesEnabledID);
			set => SetProperty(ref _bbNPCNamesEnabledID, value);
		}

		[Ordinal(41)] 
		[RED("VisionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetProperty(ref _visionStateBlackboardId);
			set => SetProperty(ref _visionStateBlackboardId, value);
		}

		[Ordinal(42)] 
		[RED("ZoomStateBlackboardId")] 
		public CHandle<redCallbackObject> ZoomStateBlackboardId
		{
			get => GetProperty(ref _zoomStateBlackboardId);
			set => SetProperty(ref _zoomStateBlackboardId, value);
		}

		[Ordinal(43)] 
		[RED("playerZonesBlackboardID")] 
		public CHandle<redCallbackObject> PlayerZonesBlackboardID
		{
			get => GetProperty(ref _playerZonesBlackboardID);
			set => SetProperty(ref _playerZonesBlackboardID, value);
		}

		[Ordinal(44)] 
		[RED("playerCombatBlackboardID")] 
		public CHandle<redCallbackObject> PlayerCombatBlackboardID
		{
			get => GetProperty(ref _playerCombatBlackboardID);
			set => SetProperty(ref _playerCombatBlackboardID, value);
		}

		[Ordinal(45)] 
		[RED("playerAimStatusBlackboardID")] 
		public CHandle<redCallbackObject> PlayerAimStatusBlackboardID
		{
			get => GetProperty(ref _playerAimStatusBlackboardID);
			set => SetProperty(ref _playerAimStatusBlackboardID, value);
		}

		[Ordinal(46)] 
		[RED("damagePreviewBlackboardID")] 
		public CHandle<redCallbackObject> DamagePreviewBlackboardID
		{
			get => GetProperty(ref _damagePreviewBlackboardID);
			set => SetProperty(ref _damagePreviewBlackboardID, value);
		}

		[Ordinal(47)] 
		[RED("uiBlackboardTargetNPC")] 
		public CWeakHandle<gameIBlackboard> UiBlackboardTargetNPC
		{
			get => GetProperty(ref _uiBlackboardTargetNPC);
			set => SetProperty(ref _uiBlackboardTargetNPC, value);
		}

		[Ordinal(48)] 
		[RED("uiBlackboardInteractions")] 
		public CWeakHandle<gameIBlackboard> UiBlackboardInteractions
		{
			get => GetProperty(ref _uiBlackboardInteractions);
			set => SetProperty(ref _uiBlackboardInteractions, value);
		}

		[Ordinal(49)] 
		[RED("interfaceOptionsBlackboard")] 
		public CWeakHandle<gameIBlackboard> InterfaceOptionsBlackboard
		{
			get => GetProperty(ref _interfaceOptionsBlackboard);
			set => SetProperty(ref _interfaceOptionsBlackboard, value);
		}

		[Ordinal(50)] 
		[RED("uiBlackboardNameplateBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboardNameplateBlackboard
		{
			get => GetProperty(ref _uiBlackboardNameplateBlackboard);
			set => SetProperty(ref _uiBlackboardNameplateBlackboard, value);
		}

		[Ordinal(51)] 
		[RED("nextDistanceCheckTime")] 
		public CFloat NextDistanceCheckTime
		{
			get => GetProperty(ref _nextDistanceCheckTime);
			set => SetProperty(ref _nextDistanceCheckTime, value);
		}
	}
}
