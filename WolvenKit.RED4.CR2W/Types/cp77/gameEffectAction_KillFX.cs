using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_KillFX : gameEffectAction
	{
		[Ordinal(0)] [RED("action")] public CEnum<gameEffectAction_KillFXAction> Action { get; set; }
		[Ordinal(1)] [RED("effectTag")] public CName EffectTag { get; set; }

		public gameEffectAction_KillFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
