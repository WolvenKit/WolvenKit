using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTppRepItemAppearanceInfo : CVariable
	{
		[Ordinal(0)]  [RED("appearance")] public CName Appearance { get; set; }
		[Ordinal(1)]  [RED("itemID")] public TweakDBID ItemID { get; set; }

		public gameTppRepItemAppearanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
