using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModFilterExceptionFolder : ModFilterCategoryFolder
	{
		[Ordinal(36)] 
		[RED("likeFilterItem")] 
		public CWeakHandle<ModFilterExceptionItem> LikeFilterItem
		{
			get => GetPropertyValue<CWeakHandle<ModFilterExceptionItem>>();
			set => SetPropertyValue<CWeakHandle<ModFilterExceptionItem>>(value);
		}

		public ModFilterExceptionFolder()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
