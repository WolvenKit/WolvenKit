using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_VehicleNPCData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isDriver")] 
		public CBool IsDriver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("side")] 
		public CInt32 Side
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_VehicleNPCData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
