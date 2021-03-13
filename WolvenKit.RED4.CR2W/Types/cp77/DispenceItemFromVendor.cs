using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DispenceItemFromVendor : ActionBool
	{
		[Ordinal(25)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(26)] [RED("price")] public CInt32 Price { get; set; }
		[Ordinal(27)] [RED("atlasTexture")] public CName AtlasTexture { get; set; }

		public DispenceItemFromVendor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
