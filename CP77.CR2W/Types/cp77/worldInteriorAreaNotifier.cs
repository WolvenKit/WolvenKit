using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldInteriorAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(0)]  [RED("gameRestrictionIDs")] public CArray<TweakDBID> GameRestrictionIDs { get; set; }
		[Ordinal(1)]  [RED("setTier2")] public CBool SetTier2 { get; set; }
		[Ordinal(2)]  [RED("treatAsInterior")] public CBool TreatAsInterior { get; set; }

		public worldInteriorAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
