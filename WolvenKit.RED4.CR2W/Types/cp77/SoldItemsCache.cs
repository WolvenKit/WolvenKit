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
			get
			{
				if (_cache == null)
				{
					_cache = (CArray<CHandle<SoldItem>>) CR2WTypeManager.Create("array:handle:SoldItem", "cache", cr2w, this);
				}
				return _cache;
			}
			set
			{
				if (_cache == value)
				{
					return;
				}
				_cache = value;
				PropertySet(this);
			}
		}

		public SoldItemsCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
