using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questLookAtDrivenTurnsNode : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("canLookAtDrivenTurnsInterruptGesture")] public CBool CanLookAtDrivenTurnsInterruptGesture { get; set; }
		[Ordinal(1)]  [RED("mode")] public CEnum<questLookAtDrivenTurnsMode> Mode { get; set; }
		[Ordinal(2)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questLookAtDrivenTurnsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
