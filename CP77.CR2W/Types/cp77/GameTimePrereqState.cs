using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameTimePrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("listener")] public CUInt32 Listener { get; set; }

		public GameTimePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
