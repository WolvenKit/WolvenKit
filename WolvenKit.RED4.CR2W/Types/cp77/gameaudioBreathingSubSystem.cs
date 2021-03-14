using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioBreathingSubSystem : gameaudioISoundComponentSubSystem
	{
		[Ordinal(0)] [RED("metadataName")] public CName MetadataName { get; set; }

		public gameaudioBreathingSubSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
