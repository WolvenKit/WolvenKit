using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddRecipeRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("recipe")] public TweakDBID Recipe { get; set; }
		[Ordinal(2)] [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(3)] [RED("hideOnItemsAdded")] public CArray<wCHandle<gamedataItem_Record>> HideOnItemsAdded { get; set; }

		public AddRecipeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
