using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_DroneStateAnimationData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("statePose")] 
		public CInt32 StatePose
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_DroneStateAnimationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
