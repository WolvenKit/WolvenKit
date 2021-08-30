using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Stamina : animAnimFeature
	{
		private CFloat _staminaValue;
		private CFloat _tiredness;

		[Ordinal(0)] 
		[RED("staminaValue")] 
		public CFloat StaminaValue
		{
			get => GetProperty(ref _staminaValue);
			set => SetProperty(ref _staminaValue, value);
		}

		[Ordinal(1)] 
		[RED("tiredness")] 
		public CFloat Tiredness
		{
			get => GetProperty(ref _tiredness);
			set => SetProperty(ref _tiredness, value);
		}

		public AnimFeature_Stamina()
		{
			_staminaValue = 1.000000F;
		}
	}
}
