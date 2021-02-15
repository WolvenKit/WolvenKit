using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectResource : CResource
	{
		[Ordinal(1)] [RED("entryPoints")] public CArray<gameSmartObjectGate> EntryPoints { get; set; }
		[Ordinal(2)] [RED("exitPoints")] public CArray<gameSmartObjectGate> ExitPoints { get; set; }
		[Ordinal(3)] [RED("bodyTypes")] public CArray<gameBodyTypeAnimationDefinition> BodyTypes { get; set; }
		[Ordinal(4)] [RED("loopAnimations")] public CArray<gameSmartObjectGate> LoopAnimations { get; set; }
		[Ordinal(5)] [RED("type")] public CEnum<gameSmartObjectType> Type { get; set; }

		public gameSmartObjectResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
