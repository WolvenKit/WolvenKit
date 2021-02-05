using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AddRecipeRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("recipe")] public TweakDBID Recipe { get; set; }
		[Ordinal(1)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(2)]  [RED("hideOnItemsAdded")] public CArray<wCHandle<gamedataItem_Record>> HideOnItemsAdded { get; set; }

		public AddRecipeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
