using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SoldItemsCache : IScriptable
	{
		[Ordinal(0)]  [RED("cache")] public CArray<CHandle<SoldItem>> Cache { get; set; }

		public SoldItemsCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
