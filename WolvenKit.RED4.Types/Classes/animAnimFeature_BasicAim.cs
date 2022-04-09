using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_BasicAim : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("aimState")] 
		public CInt32 AimState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("zoomState")] 
		public CInt32 ZoomState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimFeature_BasicAim()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
