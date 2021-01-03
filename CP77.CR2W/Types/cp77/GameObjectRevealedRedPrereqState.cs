using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameObjectRevealedRedPrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("listener")] public CHandle<GameObjectListener> Listener { get; set; }

		public GameObjectRevealedRedPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
