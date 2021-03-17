using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SoldItemsCache : IScriptable
	{
		private CArray<CHandle<SoldItem>> _cache;

		[Ordinal(0)] 
		[RED("cache")] 
		public CArray<CHandle<SoldItem>> Cache
		{
			get => GetProperty(ref _cache);
			set => SetProperty(ref _cache, value);
		}

		public SoldItemsCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
