using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_BodySlam : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("chargeLevel")] 
		public CInt32 ChargeLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_BodySlam()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
