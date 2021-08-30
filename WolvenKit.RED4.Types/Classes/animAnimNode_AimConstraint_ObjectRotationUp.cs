using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_AimConstraint_ObjectRotationUp : animAnimNode_OnePoseInput
	{
		private animTransformIndex _targetTransform;
		private animTransformIndex _upTransform;
		private Vector3 _upTransformVector;
		private animTransformIndex _transformIndex;
		private Vector3 _forwardAxisLS;
		private Vector3 _upAxisLS;
		private CEnum<animConstraintWeightMode> _weightMode;
		private CFloat _weight;
		private animNamedTrackIndex _weightFloatTrack;

		[Ordinal(12)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get => GetProperty(ref _targetTransform);
			set => SetProperty(ref _targetTransform, value);
		}

		[Ordinal(13)] 
		[RED("upTransform")] 
		public animTransformIndex UpTransform
		{
			get => GetProperty(ref _upTransform);
			set => SetProperty(ref _upTransform, value);
		}

		[Ordinal(14)] 
		[RED("upTransformVector")] 
		public Vector3 UpTransformVector
		{
			get => GetProperty(ref _upTransformVector);
			set => SetProperty(ref _upTransformVector, value);
		}

		[Ordinal(15)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(16)] 
		[RED("forwardAxisLS")] 
		public Vector3 ForwardAxisLS
		{
			get => GetProperty(ref _forwardAxisLS);
			set => SetProperty(ref _forwardAxisLS, value);
		}

		[Ordinal(17)] 
		[RED("upAxisLS")] 
		public Vector3 UpAxisLS
		{
			get => GetProperty(ref _upAxisLS);
			set => SetProperty(ref _upAxisLS, value);
		}

		[Ordinal(18)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetProperty(ref _weightMode);
			set => SetProperty(ref _weightMode, value);
		}

		[Ordinal(19)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(20)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetProperty(ref _weightFloatTrack);
			set => SetProperty(ref _weightFloatTrack, value);
		}

		public animAnimNode_AimConstraint_ObjectRotationUp()
		{
			_weight = 1.000000F;
		}
	}
}
