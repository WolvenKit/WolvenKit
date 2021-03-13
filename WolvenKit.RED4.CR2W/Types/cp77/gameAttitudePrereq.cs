using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttitudePrereq : gameIPrereq
	{
		[Ordinal(0)] [RED("attitude")] public CEnum<EAIAttitude> Attitude { get; set; }

		public gameAttitudePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
