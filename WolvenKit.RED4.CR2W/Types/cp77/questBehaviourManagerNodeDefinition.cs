using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBehaviourManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("puppet")] public gameEntityReference Puppet { get; set; }
		[Ordinal(3)] [RED("type")] public CHandle<workIWorkspotQuestAction> Type { get; set; }
		[Ordinal(4)] [RED("newType")] public CHandle<questIBehaviourManager_NodeType> NewType { get; set; }

		public questBehaviourManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
