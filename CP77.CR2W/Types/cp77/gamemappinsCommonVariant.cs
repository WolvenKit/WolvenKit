using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamemappinsCommonVariant : gamemappinsIPointOfInterestVariant
	{
		[Ordinal(0)] [RED("mappinType")] public TweakDBID MappinType { get; set; }
		[Ordinal(1)] [RED("variant")] public CEnum<gamedataMappinVariant> Variant { get; set; }

		public gamemappinsCommonVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
