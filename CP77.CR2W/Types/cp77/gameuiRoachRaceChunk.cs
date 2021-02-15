using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceChunk : CVariable
	{
		[Ordinal(0)] [RED("obstacles")] public CArray<gameuiRoachRaceObstacle> Obstacles { get; set; }

		public gameuiRoachRaceChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
