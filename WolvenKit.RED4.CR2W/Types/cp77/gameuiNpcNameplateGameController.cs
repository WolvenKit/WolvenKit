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
		private CHandle<inkScreenProjection> _nameplateProjectionCloseDistance;
		private CHandle<inkScreenProjection> _nameplateProjectionDevice;
		private CHandle<inkScreenProjection> _nameplateProjectionDeviceCloseDistance;
		private wCHandle<gameObject> _bufferedGameObject;
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
		private CUInt32 _bbNPCNamesEnabledID;
		private CUInt32 _visionStateBlackboardId;
		private CUInt32 _zoomStateBlackboardId;
		private CUInt32 _playerZonesBlackboardID;
		private CUInt32 _playerCombatBlackboardID;
		private CUInt32 _playerAimStatusBlackboardID;
		private CUInt32 _damagePreviewBlackboardID;
		private CHandle<gameIBlackboard> _uiBlackboardTargetNPC;
		private CHandle<gameIBlackboard> _uiBlackboardInteractions;
		private CHandle<gameIBlackboard> _interfaceOptionsBlackboard;

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
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("visualController")] 
		public wCHandle<NameplateVisualsLogicController> VisualController
		{
			get => GetProperty(ref _visualController);
			set => SetProperty(ref _visualController, value);
		}

		[Ordinal(16)] 
		[RED("cachedMappinControllers")] 
		public CArray<wCHandle<gameuiMappinBaseController>> CachedMappinControllers
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
		public wCHandle<gameObject> BufferedGameObject
		{
			get => GetProperty(ref _bufferedGameObject);
			set => SetProperty(ref _bufferedGameObject, value);
		}

		[Ordinal(23)] 
		[RED("bufferedCharacterRecord")] 
		public CHandle<gamedataCharacter_Record> BufferedCharacterRecord
		{
			get => GetProperty(ref _bufferedCharacterRecord);
			set => SetProperty(ref _bufferedCharacterRecord, value);
		}

		[Ordinal(24)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetProperty(ref _isScanning);
			set => SetProperty(ref _isScanning, value);
		}

		[Ordinal(25)] 
		[RED("isNewNPC")] 
		public CBool IsNewNPC
		{
			get => GetProperty(ref _isNewNPC);
			set => SetProperty(ref _isNewNPC, value);
		}

		[Ordinal(26)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		[Ordinal(27)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get => GetProperty(ref _zoom);
			set => SetProperty(ref _zoom, value);
		}

		[Ordinal(28)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(29)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(30)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get => GetProperty(ref _c_DisplayRange);
			set => SetProperty(ref _c_DisplayRange, value);
		}

		[Ordinal(31)] 
		[RED("c_MaxDisplayRange")] 
		public CFloat C_MaxDisplayRange
		{
			get => GetProperty(ref _c_MaxDisplayRange);
			set => SetProperty(ref _c_MaxDisplayRange, value);
		}

		[Ordinal(32)] 
		[RED("c_MaxDisplayRangeNotAggressive")] 
		public CFloat C_MaxDisplayRangeNotAggressive
		{
			get => GetProperty(ref _c_MaxDisplayRangeNotAggressive);
			set => SetProperty(ref _c_MaxDisplayRangeNotAggressive, value);
		}

		[Ordinal(33)] 
		[RED("c_DisplayRangeNotAggressive")] 
		public CFloat C_DisplayRangeNotAggressive
		{
			get => GetProperty(ref _c_DisplayRangeNotAggressive);
			set => SetProperty(ref _c_DisplayRangeNotAggressive, value);
		}

		[Ordinal(34)] 
		[RED("bbNameplateData")] 
		public CUInt32 BbNameplateData
		{
			get => GetProperty(ref _bbNameplateData);
			set => SetProperty(ref _bbNameplateData, value);
		}

		[Ordinal(35)] 
		[RED("bbBuffsList")] 
		public CUInt32 BbBuffsList
		{
			get => GetProperty(ref _bbBuffsList);
			set => SetProperty(ref _bbBuffsList, value);
		}

		[Ordinal(36)] 
		[RED("bbDebuffsList")] 
		public CUInt32 BbDebuffsList
		{
			get => GetProperty(ref _bbDebuffsList);
			set => SetProperty(ref _bbDebuffsList, value);
		}

		[Ordinal(37)] 
		[RED("bbHighLevelStateID")] 
		public CUInt32 BbHighLevelStateID
		{
			get => GetProperty(ref _bbHighLevelStateID);
			set => SetProperty(ref _bbHighLevelStateID, value);
		}

		[Ordinal(38)] 
		[RED("bbNPCNamesEnabledID")] 
		public CUInt32 BbNPCNamesEnabledID
		{
			get => GetProperty(ref _bbNPCNamesEnabledID);
			set => SetProperty(ref _bbNPCNamesEnabledID, value);
		}

		[Ordinal(39)] 
		[RED("VisionStateBlackboardId")] 
		public CUInt32 VisionStateBlackboardId
		{
			get => GetProperty(ref _visionStateBlackboardId);
			set => SetProperty(ref _visionStateBlackboardId, value);
		}

		[Ordinal(40)] 
		[RED("ZoomStateBlackboardId")] 
		public CUInt32 ZoomStateBlackboardId
		{
			get => GetProperty(ref _zoomStateBlackboardId);
			set => SetProperty(ref _zoomStateBlackboardId, value);
		}

		[Ordinal(41)] 
		[RED("playerZonesBlackboardID")] 
		public CUInt32 PlayerZonesBlackboardID
		{
			get => GetProperty(ref _playerZonesBlackboardID);
			set => SetProperty(ref _playerZonesBlackboardID, value);
		}

		[Ordinal(42)] 
		[RED("playerCombatBlackboardID")] 
		public CUInt32 PlayerCombatBlackboardID
		{
			get => GetProperty(ref _playerCombatBlackboardID);
			set => SetProperty(ref _playerCombatBlackboardID, value);
		}

		[Ordinal(43)] 
		[RED("playerAimStatusBlackboardID")] 
		public CUInt32 PlayerAimStatusBlackboardID
		{
			get => GetProperty(ref _playerAimStatusBlackboardID);
			set => SetProperty(ref _playerAimStatusBlackboardID, value);
		}

		[Ordinal(44)] 
		[RED("damagePreviewBlackboardID")] 
		public CUInt32 DamagePreviewBlackboardID
		{
			get => GetProperty(ref _damagePreviewBlackboardID);
			set => SetProperty(ref _damagePreviewBlackboardID, value);
		}

		[Ordinal(45)] 
		[RED("uiBlackboardTargetNPC")] 
		public CHandle<gameIBlackboard> UiBlackboardTargetNPC
		{
			get => GetProperty(ref _uiBlackboardTargetNPC);
			set => SetProperty(ref _uiBlackboardTargetNPC, value);
		}

		[Ordinal(46)] 
		[RED("uiBlackboardInteractions")] 
		public CHandle<gameIBlackboard> UiBlackboardInteractions
		{
			get => GetProperty(ref _uiBlackboardInteractions);
			set => SetProperty(ref _uiBlackboardInteractions, value);
		}

		[Ordinal(47)] 
		[RED("interfaceOptionsBlackboard")] 
		public CHandle<gameIBlackboard> InterfaceOptionsBlackboard
		{
			get => GetProperty(ref _interfaceOptionsBlackboard);
			set => SetProperty(ref _interfaceOptionsBlackboard, value);
		}

		public gameuiNpcNameplateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
