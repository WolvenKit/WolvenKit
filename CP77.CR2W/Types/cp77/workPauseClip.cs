using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workPauseClip : workIEntry
	{
		[Ordinal(0)]  [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }
		[Ordinal(1)]  [RED("timeMax")] public CFloat TimeMax { get; set; }
		[Ordinal(2)]  [RED("timeMin")] public CFloat TimeMin { get; set; }

		public workPauseClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
