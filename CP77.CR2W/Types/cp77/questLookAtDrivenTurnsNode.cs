using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questLookAtDrivenTurnsNode : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("mode")] public CEnum<questLookAtDrivenTurnsMode> Mode { get; set; }
		[Ordinal(1)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(2)]  [RED("canLookAtDrivenTurnsInterruptGesture")] public CBool CanLookAtDrivenTurnsInterruptGesture { get; set; }

		public questLookAtDrivenTurnsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
