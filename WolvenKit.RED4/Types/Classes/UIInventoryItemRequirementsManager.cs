using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemRequirementsManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemRequiredLevel")] 
		public CInt32 ItemRequiredLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("requiredStrength")] 
		public CInt32 RequiredStrength
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("requiredReflex")] 
		public CInt32 RequiredReflex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("perkRequirementName")] 
		public CString PerkRequirementName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("isSmartlinkRequirementMet")] 
		public CBool IsSmartlinkRequirementMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isLevelRequirementMet")] 
		public CBool IsLevelRequirementMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isStrengthRequirementMet")] 
		public CBool IsStrengthRequirementMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isReflexRequirementMet")] 
		public CBool IsReflexRequirementMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isPerkRequirementMet")] 
		public CBool IsPerkRequirementMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isHumanityRequirementMet")] 
		public CBool IsHumanityRequirementMet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isEquippable")] 
		public CBool IsEquippable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("isEquippableAdditionalValue")] 
		public CBool IsEquippableAdditionalValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("isEquippableFetched")] 
		public CBool IsEquippableFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("equipRequirements")] 
		public CArray<gameSItemStackRequirementData> EquipRequirements
		{
			get => GetPropertyValue<CArray<gameSItemStackRequirementData>>();
			set => SetPropertyValue<CArray<gameSItemStackRequirementData>>(value);
		}

		[Ordinal(14)] 
		[RED("equipRequirementsFetched")] 
		public CBool EquipRequirementsFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(16)] 
		[RED("attachedItem")] 
		public CWeakHandle<UIInventoryItem> AttachedItem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		public UIInventoryItemRequirementsManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
