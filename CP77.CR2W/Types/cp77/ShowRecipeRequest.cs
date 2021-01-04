using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShowRecipeRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("recipe")] public TweakDBID Recipe { get; set; }

		public ShowRecipeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
