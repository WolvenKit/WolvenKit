using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIHumanComponentPS : AICommandQueuePS
	{
		[Ordinal(0)]  [RED("spotUsageToken")] public AISpotUsageToken SpotUsageToken { get; set; }

		public AIHumanComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
