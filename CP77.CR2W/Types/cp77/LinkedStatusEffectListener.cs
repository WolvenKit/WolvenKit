using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LinkedStatusEffectListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)]  [RED("evt")] public CHandle<RemoveLinkedStatusEffectsEvent> Evt { get; set; }
		[Ordinal(1)]  [RED("instigatorObject")] public wCHandle<gameObject> InstigatorObject { get; set; }
		[Ordinal(2)]  [RED("linkedEffect")] public TweakDBID LinkedEffect { get; set; }
		[Ordinal(3)]  [RED("statusEffect")] public CHandle<gameStatusEffect> StatusEffect { get; set; }

		public LinkedStatusEffectListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
