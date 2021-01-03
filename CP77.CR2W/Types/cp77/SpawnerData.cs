using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SpawnerData : CVariable
	{
		[Ordinal(0)]  [RED("entryNames")] public CArray<CName> EntryNames { get; set; }
		[Ordinal(1)]  [RED("spawnerID")] public entEntityID SpawnerID { get; set; }

		public SpawnerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
