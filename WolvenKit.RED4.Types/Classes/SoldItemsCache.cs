using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SoldItemsCache : IScriptable
	{
		private CArray<CHandle<SoldItem>> _cache;

		[Ordinal(0)] 
		[RED("cache")] 
		public CArray<CHandle<SoldItem>> Cache
		{
			get => GetProperty(ref _cache);
			set => SetProperty(ref _cache, value);
		}
	}
}
