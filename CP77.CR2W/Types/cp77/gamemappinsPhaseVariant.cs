using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPhaseVariant : gamemappinsIPointOfInterestVariant
	{
		[Ordinal(0)]  [RED("mappinType")] public TweakDBID MappinType { get; set; }
		[Ordinal(1)]  [RED("phase")] public CEnum<gamedataMappinPhase> Phase { get; set; }
		[Ordinal(2)]  [RED("variant")] public CEnum<gamedataMappinVariant> Variant { get; set; }

		public gamemappinsPhaseVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
