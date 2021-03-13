using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questActorOverrideEntry : CVariable
	{
		[Ordinal(0)] [RED("MetadataForOverride")] public CName MetadataForOverride { get; set; }
		[Ordinal(1)] [RED("ActorName")] public CName ActorName { get; set; }

		public questActorOverrideEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
