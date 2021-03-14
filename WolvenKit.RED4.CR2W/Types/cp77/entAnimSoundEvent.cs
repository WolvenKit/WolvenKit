using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimSoundEvent : entSoundEvent
	{
		[Ordinal(4)] [RED("metadataContext")] public CName MetadataContext { get; set; }

		public entAnimSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
