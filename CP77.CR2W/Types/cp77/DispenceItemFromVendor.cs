using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DispenceItemFromVendor : ActionBool
	{
		[Ordinal(22)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(23)]  [RED("price")] public CInt32 Price { get; set; }
		[Ordinal(24)]  [RED("atlasTexture")] public CName AtlasTexture { get; set; }

		public DispenceItemFromVendor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
