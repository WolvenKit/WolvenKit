using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CraftBook : IScriptable
	{
		[Ordinal(0)]  [RED("knownRecipes")] public CArray<ItemRecipe> KnownRecipes { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public CraftBook(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
