using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SoldItemsCache : IScriptable
	{
		[Ordinal(0)] [RED("cache")] public CArray<CHandle<SoldItem>> Cache { get; set; }

		public SoldItemsCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
