using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TriggerNotifier_BarbedWire : entTriggerNotifier_Script
	{
		[Ordinal(0)]  [RED("attackType")] public TweakDBID AttackType { get; set; }

		public TriggerNotifier_BarbedWire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
