using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterRandomizationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("punkSlider")] 
		public inkWidgetReference PunkSlider
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("locksGrid")] 
		public inkGridWidgetReference LocksGrid
		{
			get => GetPropertyValue<inkGridWidgetReference>();
			set => SetPropertyValue<inkGridWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("editMode")] 
		public CEnum<gameuiCharacterCustomizationEditTag> EditMode
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationEditTag>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationEditTag>>(value);
		}

		[Ordinal(4)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("lockedCategories")] 
		public CArray<CEnum<gamedataCharacterRandomizationCategory>> LockedCategories
		{
			get => GetPropertyValue<CArray<CEnum<gamedataCharacterRandomizationCategory>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataCharacterRandomizationCategory>>>(value);
		}

		[Ordinal(6)] 
		[RED("excludedCatergoriesMirror")] 
		public CArray<CEnum<gamedataCharacterRandomizationCategory>> ExcludedCatergoriesMirror
		{
			get => GetPropertyValue<CArray<CEnum<gamedataCharacterRandomizationCategory>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataCharacterRandomizationCategory>>>(value);
		}

		[Ordinal(7)] 
		[RED("lockWidgets")] 
		public CArray<CWeakHandle<inkWidget>> LockWidgets
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(8)] 
		[RED("lockLogics")] 
		public CArray<CWeakHandle<RandomizationLockListItem>> LockLogics
		{
			get => GetPropertyValue<CArray<CWeakHandle<RandomizationLockListItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<RandomizationLockListItem>>>(value);
		}

		[Ordinal(9)] 
		[RED("lockDatas")] 
		public CArray<CHandle<gamedataCharacterRandomizationCategoryUI_Record>> LockDatas
		{
			get => GetPropertyValue<CArray<CHandle<gamedataCharacterRandomizationCategoryUI_Record>>>();
			set => SetPropertyValue<CArray<CHandle<gamedataCharacterRandomizationCategoryUI_Record>>>(value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<gameuiCharacterRandomizationParametersData> Data
		{
			get => GetPropertyValue<CHandle<gameuiCharacterRandomizationParametersData>>();
			set => SetPropertyValue<CHandle<gameuiCharacterRandomizationParametersData>>(value);
		}

		[Ordinal(11)] 
		[RED("customizationSystem")] 
		public CWeakHandle<gameuiICharacterCustomizationSystem> CustomizationSystem
		{
			get => GetPropertyValue<CWeakHandle<gameuiICharacterCustomizationSystem>>();
			set => SetPropertyValue<CWeakHandle<gameuiICharacterCustomizationSystem>>(value);
		}

		public gameuiCharacterRandomizationController()
		{
			PunkSlider = new inkWidgetReference();
			LocksGrid = new inkGridWidgetReference();
			LockedCategories = new();
			ExcludedCatergoriesMirror = new();
			LockWidgets = new();
			LockLogics = new();
			LockDatas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
