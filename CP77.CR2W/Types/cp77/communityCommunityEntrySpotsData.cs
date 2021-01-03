using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntrySpotsData : CVariable
	{
		[Ordinal(0)]  [RED("entryName")] public CName EntryName { get; set; }
		[Ordinal(1)]  [RED("phasesData")] public CArray<communityCommunityEntryPhaseSpotsData> PhasesData { get; set; }

		public communityCommunityEntrySpotsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
