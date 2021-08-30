using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entMarketingAnimationComponent : entIPlacedComponent
	{
		private CBool _freezeAnimations;
		private CArray<entMarketingAnimationEntry> _animations;
		private CBool _enableLookAt;
		private CHandle<animLookAtPreset_FullControl> _lookAtSettings;
		private CFloat _lookAtOrbitDistance;
		private CFloat _lookAtTargetPitch;
		private CFloat _lookAtTargetYaw;

		[Ordinal(5)] 
		[RED("freezeAnimations")] 
		public CBool FreezeAnimations
		{
			get => GetProperty(ref _freezeAnimations);
			set => SetProperty(ref _freezeAnimations, value);
		}

		[Ordinal(6)] 
		[RED("animations")] 
		public CArray<entMarketingAnimationEntry> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(7)] 
		[RED("enableLookAt")] 
		public CBool EnableLookAt
		{
			get => GetProperty(ref _enableLookAt);
			set => SetProperty(ref _enableLookAt, value);
		}

		[Ordinal(8)] 
		[RED("lookAtSettings")] 
		public CHandle<animLookAtPreset_FullControl> LookAtSettings
		{
			get => GetProperty(ref _lookAtSettings);
			set => SetProperty(ref _lookAtSettings, value);
		}

		[Ordinal(9)] 
		[RED("lookAtOrbitDistance")] 
		public CFloat LookAtOrbitDistance
		{
			get => GetProperty(ref _lookAtOrbitDistance);
			set => SetProperty(ref _lookAtOrbitDistance, value);
		}

		[Ordinal(10)] 
		[RED("lookAtTargetPitch")] 
		public CFloat LookAtTargetPitch
		{
			get => GetProperty(ref _lookAtTargetPitch);
			set => SetProperty(ref _lookAtTargetPitch, value);
		}

		[Ordinal(11)] 
		[RED("lookAtTargetYaw")] 
		public CFloat LookAtTargetYaw
		{
			get => GetProperty(ref _lookAtTargetYaw);
			set => SetProperty(ref _lookAtTargetYaw, value);
		}

		public entMarketingAnimationComponent()
		{
			_freezeAnimations = true;
			_lookAtOrbitDistance = 3.000000F;
		}
	}
}
