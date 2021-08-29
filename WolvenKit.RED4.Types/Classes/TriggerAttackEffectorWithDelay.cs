using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerAttackEffectorWithDelay : redEvent
	{
		private CHandle<gameAttack_GameEffect> _attack;

		[Ordinal(0)] 
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get => GetProperty(ref _attack);
			set => SetProperty(ref _attack, value);
		}
	}
}
