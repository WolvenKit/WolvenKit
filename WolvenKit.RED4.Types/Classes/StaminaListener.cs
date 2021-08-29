using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StaminaListener : gameCustomValueStatPoolsListener
	{
		private CWeakHandle<PlayerPuppet> _player;
		private CBool _psmAdded;
		private CFloat _staminaValue;
		private CFloat _staminPerc;

		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("psmAdded")] 
		public CBool PsmAdded
		{
			get => GetProperty(ref _psmAdded);
			set => SetProperty(ref _psmAdded, value);
		}

		[Ordinal(2)] 
		[RED("staminaValue")] 
		public CFloat StaminaValue
		{
			get => GetProperty(ref _staminaValue);
			set => SetProperty(ref _staminaValue, value);
		}

		[Ordinal(3)] 
		[RED("staminPerc")] 
		public CFloat StaminPerc
		{
			get => GetProperty(ref _staminPerc);
			set => SetProperty(ref _staminPerc, value);
		}
	}
}
