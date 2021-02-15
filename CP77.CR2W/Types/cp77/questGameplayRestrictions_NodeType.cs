using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questGameplayRestrictions_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		[Ordinal(0)] [RED("action")] public CEnum<questGameplayRestrictionAction> Action { get; set; }
		[Ordinal(1)] [RED("source")] public CName Source { get; set; }
		[Ordinal(2)] [RED("restrictionIDs")] public CArray<TweakDBID> RestrictionIDs { get; set; }

		public questGameplayRestrictions_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
