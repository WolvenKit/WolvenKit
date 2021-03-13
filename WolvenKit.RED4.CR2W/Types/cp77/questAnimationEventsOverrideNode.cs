using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAnimationEventsOverrideNode : questIAudioNodeType
	{
		[Ordinal(0)] [RED("perActorOverrides")] public CArray<questActorOverrideEntry> PerActorOverrides { get; set; }
		[Ordinal(1)] [RED("GlobalMetadata")] public CName GlobalMetadata { get; set; }

		public questAnimationEventsOverrideNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
