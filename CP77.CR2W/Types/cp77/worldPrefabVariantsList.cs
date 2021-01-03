using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldPrefabVariantsList : ISerializable
	{
		[Ordinal(0)]  [RED("activeVariants")] public CArray<CName> ActiveVariants { get; set; }

		public worldPrefabVariantsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
