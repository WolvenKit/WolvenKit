using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_Explosion : gameEffectObjectProvider
	{
		[Ordinal(0)]  [RED("destructibleAndDynamic")] public CBool DestructibleAndDynamic { get; set; }
		[Ordinal(1)]  [RED("gameObjects")] public CBool GameObjects { get; set; }
		[Ordinal(2)]  [RED("puppets")] public CBool Puppets { get; set; }

		public gameEffectObjectProvider_Explosion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
