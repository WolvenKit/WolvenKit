using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedPointOfInterestMappinData : CVariable
	{
		[Ordinal(0)] [RED("journalPathHash")] public CUInt32 JournalPathHash { get; set; }
		[Ordinal(1)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(2)] [RED("position")] public Vector3 Position { get; set; }

		public gameCookedPointOfInterestMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
