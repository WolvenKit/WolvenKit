using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_VehicleNPCDeathData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("deathType")] 
		public CInt32 DeathType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("side")] 
		public CInt32 Side
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_VehicleNPCDeathData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
