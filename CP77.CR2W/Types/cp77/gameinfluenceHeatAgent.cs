using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceHeatAgent : gameinfluenceIAgent
	{
		[Ordinal(0)] [RED("timeToNextUpdate")] public CFloat TimeToNextUpdate { get; set; }
		[Ordinal(1)] [RED("heatRadius")] public CFloat HeatRadius { get; set; }
		[Ordinal(2)] [RED("heatValue")] public CFloat HeatValue { get; set; }

		public gameinfluenceHeatAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
