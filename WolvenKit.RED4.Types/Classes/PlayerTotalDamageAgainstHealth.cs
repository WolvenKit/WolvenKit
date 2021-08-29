using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerTotalDamageAgainstHealth : RedBaseClass
	{
		private CWeakHandle<gameObject> _player;
		private CFloat _totalDamage;
		private CFloat _targetHealth;

		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("totalDamage")] 
		public CFloat TotalDamage
		{
			get => GetProperty(ref _totalDamage);
			set => SetProperty(ref _totalDamage, value);
		}

		[Ordinal(2)] 
		[RED("targetHealth")] 
		public CFloat TargetHealth
		{
			get => GetProperty(ref _targetHealth);
			set => SetProperty(ref _targetHealth, value);
		}
	}
}
