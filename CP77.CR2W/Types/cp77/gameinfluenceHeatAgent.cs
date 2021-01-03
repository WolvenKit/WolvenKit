using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceHeatAgent : gameinfluenceIAgent
	{
		[Ordinal(0)]  [RED("heatRadius")] public CFloat HeatRadius { get; set; }
		[Ordinal(1)]  [RED("heatValue")] public CFloat HeatValue { get; set; }
		[Ordinal(2)]  [RED("timeToNextUpdate")] public CFloat TimeToNextUpdate { get; set; }

		public gameinfluenceHeatAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
