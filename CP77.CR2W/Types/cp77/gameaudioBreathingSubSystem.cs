using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioBreathingSubSystem : gameaudioISoundComponentSubSystem
	{
		[Ordinal(0)] [RED("metadataName")] public CName MetadataName { get; set; }

		public gameaudioBreathingSubSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
