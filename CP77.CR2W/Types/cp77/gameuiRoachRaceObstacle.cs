using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceObstacle : CVariable
	{
		[Ordinal(0)]  [RED("dynObjectType")] public CName DynObjectType { get; set; }
		[Ordinal(1)]  [RED("interval")] public CFloat Interval { get; set; }

		public gameuiRoachRaceObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
