using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MuteArm : gameweaponObject
	{
		[Ordinal(57)] [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }
		[Ordinal(58)] [RED("gameEffectInstance")] public CHandle<gameEffectInstance> GameEffectInstance { get; set; }

		public MuteArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
