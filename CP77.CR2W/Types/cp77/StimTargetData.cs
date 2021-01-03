using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StimTargetData : CVariable
	{
		[Ordinal(0)]  [RED("entryID")] public CName EntryID { get; set; }
		[Ordinal(1)]  [RED("spawnerRef")] public NodeRef SpawnerRef { get; set; }

		public StimTargetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
