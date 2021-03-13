using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsCommonVariant : gamemappinsIPointOfInterestVariant
	{
		[Ordinal(0)] [RED("mappinType")] public TweakDBID MappinType { get; set; }
		[Ordinal(1)] [RED("variant")] public CEnum<gamedataMappinVariant> Variant { get; set; }

		public gamemappinsCommonVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
