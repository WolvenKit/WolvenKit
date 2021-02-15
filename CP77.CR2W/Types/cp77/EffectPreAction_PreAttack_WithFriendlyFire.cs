using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EffectPreAction_PreAttack_WithFriendlyFire : EffectPreAction_PreAttack
	{
		public EffectPreAction_PreAttack_WithFriendlyFire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
