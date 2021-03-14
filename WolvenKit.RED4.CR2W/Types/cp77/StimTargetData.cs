using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimTargetData : CVariable
	{
		[Ordinal(0)] [RED("spawnerRef")] public NodeRef SpawnerRef { get; set; }
		[Ordinal(1)] [RED("entryID")] public CName EntryID { get; set; }

		public StimTargetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
