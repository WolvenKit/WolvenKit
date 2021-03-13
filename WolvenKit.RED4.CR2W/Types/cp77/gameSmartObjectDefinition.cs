using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectDefinition : ISerializable
	{
		[Ordinal(0)] [RED("resource")] public rRef<gameSmartObjectResource> Resource { get; set; }
		[Ordinal(1)] [RED("actions")] public CArray<CName> Actions { get; set; }
		[Ordinal(2)] [RED("motionActionDatabase")] public rRef<animActionAnimDatabase> MotionActionDatabase { get; set; }
		[Ordinal(3)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(4)] [RED("overrideGeneratedParameters")] public CBool OverrideGeneratedParameters { get; set; }

		public gameSmartObjectDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
