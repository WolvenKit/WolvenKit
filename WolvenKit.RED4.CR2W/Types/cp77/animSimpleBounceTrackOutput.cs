using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTrackOutput : CVariable
	{
		[Ordinal(0)] [RED("targetTrack")] public animNamedTrackIndex TargetTrack { get; set; }
		[Ordinal(1)] [RED("multiplier")] public CFloat Multiplier { get; set; }

		public animSimpleBounceTrackOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
