using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCpoPickableItem : gameObject
	{
		[Ordinal(40)] [RED("itemIDToEquip")] public TweakDBID ItemIDToEquip { get; set; }
		[Ordinal(41)] [RED("quickSlotID")] public CInt32 QuickSlotID { get; set; }

		public gameCpoPickableItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
