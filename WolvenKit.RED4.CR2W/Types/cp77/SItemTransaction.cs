using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SItemTransaction : CVariable
	{
		[Ordinal(0)] [RED("itemStack")] public gameSItemStack ItemStack { get; set; }
		[Ordinal(1)] [RED("pricePerItem")] public CInt32 PricePerItem { get; set; }

		public SItemTransaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
