using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SoldItemsCache : IScriptable
	{
		[Ordinal(0)] 
		[RED("cache")] 
		public CArray<CHandle<SoldItem>> Cache
		{
			get => GetPropertyValue<CArray<CHandle<SoldItem>>>();
			set => SetPropertyValue<CArray<CHandle<SoldItem>>>(value);
		}

		public SoldItemsCache()
		{
			Cache = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
