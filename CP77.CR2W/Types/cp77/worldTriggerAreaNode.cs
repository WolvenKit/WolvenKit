using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTriggerAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }

		public worldTriggerAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
