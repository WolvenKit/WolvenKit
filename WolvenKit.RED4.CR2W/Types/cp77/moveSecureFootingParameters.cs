using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveSecureFootingParameters : CVariable
	{
		private CName _unsecureCollisionFilterName;
		private CFloat _maxVerticalDistanceForCentreRaycast;
		private CFloat _maxAngularDistanceForOtherRaycasts;
		private CUInt32 _standingMinNumberOfRaycasts;
		private CFloat _standingMinCollisionHorizontalDistance;
		private CUInt32 _fallingMinNumberOfRaycasts;
		private CFloat _fallingMinCollisionHorizontalDistance;
		private CFloat _maxStaticGroundFactor;
		private CBool _needsCentreRaycast;
		private CFloat _minVelocityForFalling;
		private CName _slopeCurveName;

		[Ordinal(0)] 
		[RED("unsecureCollisionFilterName")] 
		public CName UnsecureCollisionFilterName
		{
			get => GetProperty(ref _unsecureCollisionFilterName);
			set => SetProperty(ref _unsecureCollisionFilterName, value);
		}

		[Ordinal(1)] 
		[RED("maxVerticalDistanceForCentreRaycast")] 
		public CFloat MaxVerticalDistanceForCentreRaycast
		{
			get => GetProperty(ref _maxVerticalDistanceForCentreRaycast);
			set => SetProperty(ref _maxVerticalDistanceForCentreRaycast, value);
		}

		[Ordinal(2)] 
		[RED("maxAngularDistanceForOtherRaycasts")] 
		public CFloat MaxAngularDistanceForOtherRaycasts
		{
			get => GetProperty(ref _maxAngularDistanceForOtherRaycasts);
			set => SetProperty(ref _maxAngularDistanceForOtherRaycasts, value);
		}

		[Ordinal(3)] 
		[RED("standingMinNumberOfRaycasts")] 
		public CUInt32 StandingMinNumberOfRaycasts
		{
			get => GetProperty(ref _standingMinNumberOfRaycasts);
			set => SetProperty(ref _standingMinNumberOfRaycasts, value);
		}

		[Ordinal(4)] 
		[RED("standingMinCollisionHorizontalDistance")] 
		public CFloat StandingMinCollisionHorizontalDistance
		{
			get => GetProperty(ref _standingMinCollisionHorizontalDistance);
			set => SetProperty(ref _standingMinCollisionHorizontalDistance, value);
		}

		[Ordinal(5)] 
		[RED("fallingMinNumberOfRaycasts")] 
		public CUInt32 FallingMinNumberOfRaycasts
		{
			get => GetProperty(ref _fallingMinNumberOfRaycasts);
			set => SetProperty(ref _fallingMinNumberOfRaycasts, value);
		}

		[Ordinal(6)] 
		[RED("fallingMinCollisionHorizontalDistance")] 
		public CFloat FallingMinCollisionHorizontalDistance
		{
			get => GetProperty(ref _fallingMinCollisionHorizontalDistance);
			set => SetProperty(ref _fallingMinCollisionHorizontalDistance, value);
		}

		[Ordinal(7)] 
		[RED("maxStaticGroundFactor")] 
		public CFloat MaxStaticGroundFactor
		{
			get => GetProperty(ref _maxStaticGroundFactor);
			set => SetProperty(ref _maxStaticGroundFactor, value);
		}

		[Ordinal(8)] 
		[RED("needsCentreRaycast")] 
		public CBool NeedsCentreRaycast
		{
			get => GetProperty(ref _needsCentreRaycast);
			set => SetProperty(ref _needsCentreRaycast, value);
		}

		[Ordinal(9)] 
		[RED("minVelocityForFalling")] 
		public CFloat MinVelocityForFalling
		{
			get => GetProperty(ref _minVelocityForFalling);
			set => SetProperty(ref _minVelocityForFalling, value);
		}

		[Ordinal(10)] 
		[RED("slopeCurveName")] 
		public CName SlopeCurveName
		{
			get => GetProperty(ref _slopeCurveName);
			set => SetProperty(ref _slopeCurveName, value);
		}

		public moveSecureFootingParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
