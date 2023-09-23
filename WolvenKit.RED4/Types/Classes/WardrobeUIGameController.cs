using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WardrobeUIGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("setEditorWidget")] 
		public inkWidgetReference SetEditorWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("setGridWidget")] 
		public inkCompoundWidgetReference SetGridWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(8)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(9)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(10)] 
		[RED("setEditorController")] 
		public CWeakHandle<WardrobeSetEditorUIController> SetEditorController
		{
			get => GetPropertyValue<CWeakHandle<WardrobeSetEditorUIController>>();
			set => SetPropertyValue<CWeakHandle<WardrobeSetEditorUIController>>(value);
		}

		[Ordinal(11)] 
		[RED("isMainScreen")] 
		public CBool IsMainScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("tooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(14)] 
		[RED("sets")] 
		public CArray<CHandle<gameClothingSet>> Sets
		{
			get => GetPropertyValue<CArray<CHandle<gameClothingSet>>>();
			set => SetPropertyValue<CArray<CHandle<gameClothingSet>>>(value);
		}

		[Ordinal(15)] 
		[RED("currentSetController")] 
		public CWeakHandle<ClothingSetController> CurrentSetController
		{
			get => GetPropertyValue<CWeakHandle<ClothingSetController>>();
			set => SetPropertyValue<CWeakHandle<ClothingSetController>>(value);
		}

		[Ordinal(16)] 
		[RED("maxSetsAmount")] 
		public CInt32 MaxSetsAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("setControllers")] 
		public CArray<CWeakHandle<ClothingSetController>> SetControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<ClothingSetController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<ClothingSetController>>>(value);
		}

		[Ordinal(18)] 
		[RED("confirmationRequestToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationRequestToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(19)] 
		[RED("deletedSetController")] 
		public CWeakHandle<ClothingSetController> DeletedSetController
		{
			get => GetPropertyValue<CWeakHandle<ClothingSetController>>();
			set => SetPropertyValue<CWeakHandle<ClothingSetController>>(value);
		}

		[Ordinal(20)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("outroAnimProxy")] 
		public CHandle<inkanimProxy> OutroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("introFinished")] 
		public CBool IntroFinished
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("finalEquippedSet")] 
		public CEnum<gameWardrobeClothingSetIndex> FinalEquippedSet
		{
			get => GetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>();
			set => SetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>(value);
		}

		[Ordinal(24)] 
		[RED("equipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(25)] 
		[RED("equipmentInProgressCallback")] 
		public CHandle<redCallbackObject> EquipmentInProgressCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public WardrobeUIGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
