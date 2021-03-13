using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerNotifier_BarbedWire : entTriggerNotifier_Script
	{
		[Ordinal(3)] [RED("attackType")] public TweakDBID AttackType { get; set; }

		public TriggerNotifier_BarbedWire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
