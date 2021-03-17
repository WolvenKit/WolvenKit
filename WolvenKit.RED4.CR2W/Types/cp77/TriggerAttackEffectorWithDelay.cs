using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackEffectorWithDelay : redEvent
	{
		private CHandle<gameAttack_GameEffect> _attack;

		[Ordinal(0)] 
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get => GetProperty(ref _attack);
			set => SetProperty(ref _attack, value);
		}

		public TriggerAttackEffectorWithDelay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
