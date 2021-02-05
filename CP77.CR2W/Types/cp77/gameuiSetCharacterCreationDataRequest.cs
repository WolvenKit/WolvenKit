using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSetCharacterCreationDataRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("lifepath")] public TweakDBID Lifepath { get; set; }
		[Ordinal(1)]  [RED("attributes")] public CArray<gameuiCharacterCustomizationAttribute> Attributes { get; set; }

		public gameuiSetCharacterCreationDataRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
