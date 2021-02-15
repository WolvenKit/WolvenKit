using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameTimePrereqState : gamePrereqState
	{
		[Ordinal(0)] [RED("listener")] public CUInt32 Listener { get; set; }

		public GameTimePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
