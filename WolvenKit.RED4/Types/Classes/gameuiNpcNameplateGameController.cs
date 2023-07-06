using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiNpcNameplateGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("projection")] 
		public inkWidgetReference Projection
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("displayName")] 
		public inkWidgetReference DisplayName
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("iconHolder")] 
		public inkWidgetReference IconHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("mappinSlot")] 
		public inkWidgetReference MappinSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("chattersSlot")] 
		public inkWidgetReference ChattersSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("visualController")] 
		public CWeakHandle<NameplateVisualsLogicController> VisualController
		{
			get => GetPropertyValue<CWeakHandle<NameplateVisualsLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateVisualsLogicController>>(value);
		}

		[Ordinal(16)] 
		[RED("cachedMappinControllers")] 
		public CArray<CWeakHandle<gameuiMappinBaseController>> CachedMappinControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameuiMappinBaseController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameuiMappinBaseController>>>(value);
		}

		[Ordinal(17)] 
		[RED("visualControllerNeedsMappinsUpdate")] 
		public CBool VisualControllerNeedsMappinsUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("nameplateProjection")] 
		public CHandle<inkScreenProjection> NameplateProjection
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(19)] 
		[RED("nameplateProjectionCloseDistance")] 
		public CHandle<inkScreenProjection> NameplateProjectionCloseDistance
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(20)] 
		[RED("nameplateProjectionDevice")] 
		public CHandle<inkScreenProjection> NameplateProjectionDevice
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(21)] 
		[RED("nameplateProjectionDeviceCloseDistance")] 
		public CHandle<inkScreenProjection> NameplateProjectionDeviceCloseDistance
		{
			get => GetPropertyValue<CHandle<inkScreenProjection>>();
			set => SetPropertyValue<CHandle<inkScreenProjection>>(value);
		}

		[Ordinal(22)] 
		[RED("bufferedGameObject")] 
		public CWeakHandle<gameObject> BufferedGameObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(23)] 
		[RED("bufferedPuppetHideNameTag")] 
		public CBool BufferedPuppetHideNameTag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("bufferedCharacterNamePlateRecord")] 
		public CHandle<gamedataUINameplate_Record> BufferedCharacterNamePlateRecord
		{
			get => GetPropertyValue<CHandle<gamedataUINameplate_Record>>();
			set => SetPropertyValue<CHandle<gamedataUINameplate_Record>>(value);
		}

		[Ordinal(25)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("isNewNPC")] 
		public CBool IsNewNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}

		[Ordinal(28)] 
		[RED("UI_NameplateDataDef")] 
		public CHandle<UI_NameplateDataDef> UI_NameplateDataDef
		{
			get => GetPropertyValue<CHandle<UI_NameplateDataDef>>();
			set => SetPropertyValue<CHandle<UI_NameplateDataDef>>(value);
		}

		[Ordinal(29)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(32)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("c_MaxDisplayRange")] 
		public CFloat C_MaxDisplayRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("c_MaxDisplayRangeNotAggressive")] 
		public CFloat C_MaxDisplayRangeNotAggressive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("c_DisplayRangeNotAggressive")] 
		public CFloat C_DisplayRangeNotAggressive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("bbNameplateData")] 
		public CHandle<redCallbackObject> BbNameplateData
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("bbBuffsList")] 
		public CHandle<redCallbackObject> BbBuffsList
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("bbDebuffsList")] 
		public CHandle<redCallbackObject> BbDebuffsList
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(39)] 
		[RED("bbHighLevelStateID")] 
		public CHandle<redCallbackObject> BbHighLevelStateID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("bbNPCNamesEnabledID")] 
		public CHandle<redCallbackObject> BbNPCNamesEnabledID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("VisionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("ZoomStateBlackboardId")] 
		public CHandle<redCallbackObject> ZoomStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("playerZonesBlackboardID")] 
		public CHandle<redCallbackObject> PlayerZonesBlackboardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(44)] 
		[RED("playerCombatBlackboardID")] 
		public CHandle<redCallbackObject> PlayerCombatBlackboardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(45)] 
		[RED("playerAimStatusBlackboardID")] 
		public CHandle<redCallbackObject> PlayerAimStatusBlackboardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("damagePreviewBlackboardID")] 
		public CHandle<redCallbackObject> DamagePreviewBlackboardID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(47)] 
		[RED("uiBlackboardTargetNPC")] 
		public CWeakHandle<gameIBlackboard> UiBlackboardTargetNPC
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(48)] 
		[RED("uiBlackboardInteractions")] 
		public CWeakHandle<gameIBlackboard> UiBlackboardInteractions
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(49)] 
		[RED("interfaceOptionsBlackboard")] 
		public CWeakHandle<gameIBlackboard> InterfaceOptionsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(50)] 
		[RED("uiBlackboardNameplateBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboardNameplateBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(51)] 
		[RED("nextDistanceCheckTime")] 
		public CFloat NextDistanceCheckTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiNpcNameplateGameController()
		{
			Projection = new inkWidgetReference();
			DisplayName = new inkWidgetReference();
			IconHolder = new inkWidgetReference();
			MappinSlot = new inkWidgetReference();
			ChattersSlot = new inkWidgetReference();
			CachedMappinControllers = new();
			Zoom = 1.000000F;
			CurrentHealth = 100;
			MaximumHealth = 100;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
