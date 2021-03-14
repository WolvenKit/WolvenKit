using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedGameEffectEvent : redEvent
	{
		[Ordinal(0)] [RED("activator")] public wCHandle<gameObject> Activator { get; set; }
		[Ordinal(1)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(2)] [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(3)] [RED("effectTag")] public CName EffectTag { get; set; }
		[Ordinal(4)] [RED("statusEffect")] public CString StatusEffect { get; set; }

		public DelayedGameEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
