using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class tempshitMapPinManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("forceCaption")] public LocalizationString ForceCaption { get; set; }
		[Ordinal(1)]  [RED("mapPinName")] public CName MapPinName { get; set; }
		[Ordinal(2)]  [RED("nodeRef")] public gameEntityReference NodeRef { get; set; }
		[Ordinal(3)]  [RED("operation")] public CEnum<tempshitMapPinOperation> Operation { get; set; }
		[Ordinal(4)]  [RED("position")] public Vector3 Position { get; set; }

		public tempshitMapPinManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
