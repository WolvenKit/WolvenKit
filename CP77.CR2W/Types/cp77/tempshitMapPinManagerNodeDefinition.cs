using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class tempshitMapPinManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("mapPinName")] public CName MapPinName { get; set; }
		[Ordinal(3)] [RED("operation")] public CEnum<tempshitMapPinOperation> Operation { get; set; }
		[Ordinal(4)] [RED("nodeRef")] public gameEntityReference NodeRef { get; set; }
		[Ordinal(5)] [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(6)] [RED("forceCaption")] public LocalizationString ForceCaption { get; set; }

		public tempshitMapPinManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
