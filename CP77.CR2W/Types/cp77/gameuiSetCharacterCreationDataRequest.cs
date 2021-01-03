using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiSetCharacterCreationDataRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("attributes")] public CArray<gameuiCharacterCustomizationAttribute> Attributes { get; set; }
		[Ordinal(1)]  [RED("lifepath")] public TweakDBID Lifepath { get; set; }

		public gameuiSetCharacterCreationDataRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
