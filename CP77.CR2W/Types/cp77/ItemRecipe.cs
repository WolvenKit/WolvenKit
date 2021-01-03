using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemRecipe : CVariable
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("isHidden")] public CBool IsHidden { get; set; }
		[Ordinal(2)]  [RED("targetItem")] public TweakDBID TargetItem { get; set; }

		public ItemRecipe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
