using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectDuration_Infinite : gameEffectDurationModifier
	{
		public gameEffectDuration_Infinite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
