using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleTriggerAttackEffect : gameEffector
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(1)] [RED("attackTDBID")] public TweakDBID AttackTDBID { get; set; }
		[Ordinal(2)] [RED("shouldDelay")] public CBool ShouldDelay { get; set; }

		public SimpleTriggerAttackEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
