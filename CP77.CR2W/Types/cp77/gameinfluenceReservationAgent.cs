using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceReservationAgent : gameinfluenceIAgent
	{
		[Ordinal(0)]  [RED("radius")] public CFloat Radius { get; set; }

		public gameinfluenceReservationAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
