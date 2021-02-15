using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldInteriorAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] [RED("gameRestrictionIDs")] public CArray<TweakDBID> GameRestrictionIDs { get; set; }
		[Ordinal(4)] [RED("treatAsInterior")] public CBool TreatAsInterior { get; set; }
		[Ordinal(5)] [RED("setTier2")] public CBool SetTier2 { get; set; }

		public worldInteriorAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
