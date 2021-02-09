using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatusEffectTriggerListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)]  [RED("statusEffect")] public TweakDBID StatusEffect { get; set; }
		[Ordinal(2)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(3)]  [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }

		public StatusEffectTriggerListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
