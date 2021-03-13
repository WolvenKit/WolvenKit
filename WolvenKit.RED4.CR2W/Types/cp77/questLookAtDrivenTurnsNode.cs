using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLookAtDrivenTurnsNode : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("mode")] public CEnum<questLookAtDrivenTurnsMode> Mode { get; set; }
		[Ordinal(3)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(4)] [RED("canLookAtDrivenTurnsInterruptGesture")] public CBool CanLookAtDrivenTurnsInterruptGesture { get; set; }

		public questLookAtDrivenTurnsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
