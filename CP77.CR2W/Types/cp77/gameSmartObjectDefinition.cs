using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectDefinition : ISerializable
	{
		[Ordinal(0)]  [RED("actions")] public CArray<CName> Actions { get; set; }
		[Ordinal(1)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)]  [RED("motionActionDatabase")] public rRef<animActionAnimDatabase> MotionActionDatabase { get; set; }
		[Ordinal(3)]  [RED("overrideGeneratedParameters")] public CBool OverrideGeneratedParameters { get; set; }
		[Ordinal(4)]  [RED("resource")] public rRef<gameSmartObjectResource> Resource { get; set; }

		public gameSmartObjectDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
