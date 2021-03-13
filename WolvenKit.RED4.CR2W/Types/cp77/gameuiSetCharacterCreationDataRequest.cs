using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSetCharacterCreationDataRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("lifepath")] public TweakDBID Lifepath { get; set; }
		[Ordinal(2)] [RED("attributes")] public CArray<gameuiCharacterCustomizationAttribute> Attributes { get; set; }

		public gameuiSetCharacterCreationDataRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
