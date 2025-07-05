using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterBrighteningAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("effectStrengthMultiplier")] 
		public CFloat EffectStrengthMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("envMultiplier")] 
		public CLegacySingleChannelCurve<CFloat> EnvMultiplier
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public CharacterBrighteningAreaSettings()
		{
			Enable = true;
			EffectStrengthMultiplier = 1.000000F;
			MinDistance = 15.000000F;
			MaxDistance = 30.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
