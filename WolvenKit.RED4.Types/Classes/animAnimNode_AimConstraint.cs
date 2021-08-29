using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_AimConstraint : animAnimNode_OnePoseInput
	{
		private CBool _areSourceChannelsResaved;
		private CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> _targetTransforms;
		private animTransformIndex _targetTransform;
		private CHandle<animIAnimNodeSourceChannel_Vector> _upTransform;
		private animTransformIndex _transformIndex;
		private Vector3 _forwardAxisLS;
		private Vector3 _upAxisLS;
		private CEnum<animConstraintWeightMode> _weightMode;
		private CFloat _weight;
		private animNamedTrackIndex _weightFloatTrack;

		[Ordinal(12)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetProperty(ref _areSourceChannelsResaved);
			set => SetProperty(ref _areSourceChannelsResaved, value);
		}

		[Ordinal(13)] 
		[RED("targetTransforms")] 
		public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> TargetTransforms
		{
			get => GetProperty(ref _targetTransforms);
			set => SetProperty(ref _targetTransforms, value);
		}

		[Ordinal(14)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get => GetProperty(ref _targetTransform);
			set => SetProperty(ref _targetTransform, value);
		}

		[Ordinal(15)] 
		[RED("upTransform")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> UpTransform
		{
			get => GetProperty(ref _upTransform);
			set => SetProperty(ref _upTransform, value);
		}

		[Ordinal(16)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(17)] 
		[RED("forwardAxisLS")] 
		public Vector3 ForwardAxisLS
		{
			get => GetProperty(ref _forwardAxisLS);
			set => SetProperty(ref _forwardAxisLS, value);
		}

		[Ordinal(18)] 
		[RED("upAxisLS")] 
		public Vector3 UpAxisLS
		{
			get => GetProperty(ref _upAxisLS);
			set => SetProperty(ref _upAxisLS, value);
		}

		[Ordinal(19)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetProperty(ref _weightMode);
			set => SetProperty(ref _weightMode, value);
		}

		[Ordinal(20)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(21)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetProperty(ref _weightFloatTrack);
			set => SetProperty(ref _weightFloatTrack, value);
		}
	}
}
