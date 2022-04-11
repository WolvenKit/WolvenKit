using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayBreathingAnimationEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_CameraBreathing> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_CameraBreathing>>();
			set => SetPropertyValue<CHandle<AnimFeature_CameraBreathing>>(value);
		}

		[Ordinal(1)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
