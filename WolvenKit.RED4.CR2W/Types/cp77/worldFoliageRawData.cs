using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageRawData : ISerializable
	{
		[Ordinal(0)] [RED("items")] public CArray<CHandle<worldFoliageRawItem>> Items { get; set; }

		public worldFoliageRawData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
