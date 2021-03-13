using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTppRepItemAppearanceInfo : CVariable
	{
		[Ordinal(0)] [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(1)] [RED("appearance")] public CName Appearance { get; set; }

		public gameTppRepItemAppearanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
