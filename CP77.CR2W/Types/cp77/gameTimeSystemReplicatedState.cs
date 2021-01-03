using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTimeSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)]  [RED("gameTime")] public GameTime GameTime { get; set; }
		[Ordinal(1)]  [RED("paused")] public CBool Paused { get; set; }

		public gameTimeSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
