using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceChunk : CVariable
	{
		[Ordinal(0)] [RED("obstacles")] public CArray<gameuiRoachRaceObstacle> Obstacles { get; set; }

		public gameuiRoachRaceChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
