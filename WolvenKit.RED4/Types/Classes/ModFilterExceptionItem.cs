using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModFilterExceptionItem : ModFilterCategoryItem
	{
		[Ordinal(29)] 
		[RED("ownerDrawer")] 
		public CWeakHandle<ModMenuFilterDrawer> OwnerDrawer
		{
			get => GetPropertyValue<CWeakHandle<ModMenuFilterDrawer>>();
			set => SetPropertyValue<CWeakHandle<ModMenuFilterDrawer>>(value);
		}

		public ModFilterExceptionItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
