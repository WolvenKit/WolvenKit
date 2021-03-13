using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddItemsEffector : gameEffector
	{
		[Ordinal(0)] [RED("items")] public CArray<wCHandle<gamedataInventoryItem_Record>> Items { get; set; }

		public AddItemsEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
