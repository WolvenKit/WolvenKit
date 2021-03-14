using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workPauseClip : workIEntry
	{
		[Ordinal(2)] [RED("timeMin")] public CFloat TimeMin { get; set; }
		[Ordinal(3)] [RED("timeMax")] public CFloat TimeMax { get; set; }
		[Ordinal(4)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }

		public workPauseClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
