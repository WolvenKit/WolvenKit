using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animLookAtStateMachineSettings : RedBaseClass
	{
		private CName _partName;
		private CName _partAlias;
		private CName _sphereAttachmentBone;
		private CFloat _sphereRadius;
		private CFloat _followingSpeedFactor;
		private CLegacySingleChannelCurve<CFloat> _followingSpeedByAngleCurve;
		private CName _enableFloatTrack;
		private CName _eyesOverrideFloatTrack;
		private CFloat _transitionSpeedMultiplier;
		private CFloat _blendWeightPowFactor;
		private CName _coneLimitReached;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("partAlias")] 
		public CName PartAlias
		{
			get => GetProperty(ref _partAlias);
			set => SetProperty(ref _partAlias, value);
		}

		[Ordinal(2)] 
		[RED("sphereAttachmentBone")] 
		public CName SphereAttachmentBone
		{
			get => GetProperty(ref _sphereAttachmentBone);
			set => SetProperty(ref _sphereAttachmentBone, value);
		}

		[Ordinal(3)] 
		[RED("sphereRadius")] 
		public CFloat SphereRadius
		{
			get => GetProperty(ref _sphereRadius);
			set => SetProperty(ref _sphereRadius, value);
		}

		[Ordinal(4)] 
		[RED("followingSpeedFactor")] 
		public CFloat FollowingSpeedFactor
		{
			get => GetProperty(ref _followingSpeedFactor);
			set => SetProperty(ref _followingSpeedFactor, value);
		}

		[Ordinal(5)] 
		[RED("followingSpeedByAngleCurve")] 
		public CLegacySingleChannelCurve<CFloat> FollowingSpeedByAngleCurve
		{
			get => GetProperty(ref _followingSpeedByAngleCurve);
			set => SetProperty(ref _followingSpeedByAngleCurve, value);
		}

		[Ordinal(6)] 
		[RED("enableFloatTrack")] 
		public CName EnableFloatTrack
		{
			get => GetProperty(ref _enableFloatTrack);
			set => SetProperty(ref _enableFloatTrack, value);
		}

		[Ordinal(7)] 
		[RED("eyesOverrideFloatTrack")] 
		public CName EyesOverrideFloatTrack
		{
			get => GetProperty(ref _eyesOverrideFloatTrack);
			set => SetProperty(ref _eyesOverrideFloatTrack, value);
		}

		[Ordinal(8)] 
		[RED("transitionSpeedMultiplier")] 
		public CFloat TransitionSpeedMultiplier
		{
			get => GetProperty(ref _transitionSpeedMultiplier);
			set => SetProperty(ref _transitionSpeedMultiplier, value);
		}

		[Ordinal(9)] 
		[RED("blendWeightPowFactor")] 
		public CFloat BlendWeightPowFactor
		{
			get => GetProperty(ref _blendWeightPowFactor);
			set => SetProperty(ref _blendWeightPowFactor, value);
		}

		[Ordinal(10)] 
		[RED("coneLimitReached")] 
		public CName ConeLimitReached
		{
			get => GetProperty(ref _coneLimitReached);
			set => SetProperty(ref _coneLimitReached, value);
		}

		public animLookAtStateMachineSettings()
		{
			_followingSpeedFactor = 1.000000F;
			_eyesOverrideFloatTrack = "pla_force_enable_eyes";
			_transitionSpeedMultiplier = 1.000000F;
			_blendWeightPowFactor = 1.000000F;
		}
	}
}
