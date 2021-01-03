using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MuteArm : gameweaponObject
	{
		[Ordinal(0)]  [RED("gameEffectInstance")] public CHandle<gameEffectInstance> GameEffectInstance { get; set; }
		[Ordinal(1)]  [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }

		public MuteArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
