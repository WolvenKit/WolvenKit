using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioLoopingSoundController : CVariable
	{
		[Ordinal(0)]  [RED("playEvent")] public CName PlayEvent { get; set; }
		[Ordinal(1)]  [RED("preStopEvent")] public CName PreStopEvent { get; set; }
		[Ordinal(2)]  [RED("stopEvent")] public CName StopEvent { get; set; }

		public audioLoopingSoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
