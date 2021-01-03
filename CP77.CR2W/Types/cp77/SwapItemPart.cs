using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SwapItemPart : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("baseItem")] public gameItemID BaseItem { get; set; }
		[Ordinal(1)]  [RED("obj")] public wCHandle<gameObject> Obj { get; set; }
		[Ordinal(2)]  [RED("partToInstall")] public gameItemID PartToInstall { get; set; }
		[Ordinal(3)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public SwapItemPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
