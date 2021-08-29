using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayBreathingAnimationEffector : gameEffector
	{
		private CHandle<AnimFeature_CameraBreathing> _animFeature;
		private CName _animFeatureName;
		private CWeakHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_CameraBreathing> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(1)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
