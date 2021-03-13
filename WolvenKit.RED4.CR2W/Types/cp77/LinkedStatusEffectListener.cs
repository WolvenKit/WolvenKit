using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkedStatusEffectListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] [RED("instigatorObject")] public wCHandle<gameObject> InstigatorObject { get; set; }
		[Ordinal(1)] [RED("linkedEffect")] public TweakDBID LinkedEffect { get; set; }
		[Ordinal(2)] [RED("evt")] public CHandle<RemoveLinkedStatusEffectsEvent> Evt { get; set; }
		[Ordinal(3)] [RED("statusEffect")] public CHandle<gameStatusEffect> StatusEffect { get; set; }

		public LinkedStatusEffectListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
