using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCookedGpsMappinData : CVariable
	{
		[Ordinal(0)]  [RED("journalPathHash")] public CUInt32 JournalPathHash { get; set; }
		[Ordinal(1)]  [RED("positions")] public CArray<Vector3> Positions { get; set; }

		public gameCookedGpsMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
