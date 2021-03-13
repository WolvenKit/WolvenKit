using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackEffectorWithDelay : redEvent
	{
		[Ordinal(0)] [RED("attack")] public CHandle<gameAttack_GameEffect> Attack { get; set; }

		public TriggerAttackEffectorWithDelay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
