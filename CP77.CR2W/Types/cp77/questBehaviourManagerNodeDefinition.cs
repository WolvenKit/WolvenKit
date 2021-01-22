using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questBehaviourManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("newType")] public CHandle<questIBehaviourManager_NodeType> NewType { get; set; }
		[Ordinal(1)]  [RED("puppet")] public gameEntityReference Puppet { get; set; }
		[Ordinal(2)]  [RED("type")] public CHandle<workIWorkspotQuestAction> Type { get; set; }

		public questBehaviourManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
