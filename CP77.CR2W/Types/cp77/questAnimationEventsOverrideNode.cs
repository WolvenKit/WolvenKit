using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questAnimationEventsOverrideNode : questIAudioNodeType
	{
		[Ordinal(0)]  [RED("GlobalMetadata")] public CName GlobalMetadata { get; set; }
		[Ordinal(1)]  [RED("perActorOverrides")] public CArray<questActorOverrideEntry> PerActorOverrides { get; set; }

		public questAnimationEventsOverrideNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
