using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTriggerAreaNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("notifiers")] public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers { get; set; }

		public worldTriggerAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
