using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVoicesetManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("type")] public CHandle<questIVoicesetManager_NodeType> Type { get; set; }

		public questVoicesetManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
