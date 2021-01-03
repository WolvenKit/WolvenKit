using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CombatState : animAnimFeature
	{
		[Ordinal(0)]  [RED("isInCombat")] public CBool IsInCombat { get; set; }

		public AnimFeature_CombatState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
