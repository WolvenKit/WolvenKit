using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPuppeteerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("effector")] public CHandle<questPuppetsEffector> Effector { get; set; }
		[Ordinal(1)]  [RED("reference")] public gameEntityReference Reference { get; set; }

		public questPuppeteerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
