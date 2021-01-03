using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimationsLoadedTask : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("coreAnims")] public CBool CoreAnims { get; set; }
		[Ordinal(1)]  [RED("melee")] public CBool Melee { get; set; }
		[Ordinal(2)]  [RED("setSignal")] public CBool SetSignal { get; set; }

		public AnimationsLoadedTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
