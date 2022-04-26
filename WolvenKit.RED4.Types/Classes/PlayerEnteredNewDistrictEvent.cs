using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerEnteredNewDistrictEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("gunshotRange")] 
		public CFloat GunshotRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("explosionRange")] 
		public CFloat ExplosionRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PlayerEnteredNewDistrictEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
