using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DelayedGameEffectEvent : redEvent
	{
		[Ordinal(0)]  [RED("activator")] public wCHandle<gameObject> Activator { get; set; }
		[Ordinal(1)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(2)]  [RED("effectTag")] public CName EffectTag { get; set; }
		[Ordinal(3)]  [RED("statusEffect")] public CString StatusEffect { get; set; }
		[Ordinal(4)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public DelayedGameEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
