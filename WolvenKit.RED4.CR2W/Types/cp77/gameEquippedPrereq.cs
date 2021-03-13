using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEquippedPrereq : gameIPrereq
	{
		[Ordinal(0)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)] [RED("slot")] public TweakDBID Slot { get; set; }

		public gameEquippedPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
