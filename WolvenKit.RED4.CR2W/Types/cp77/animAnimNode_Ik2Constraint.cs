using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Ik2Constraint : animAnimNode_OnePoseInput
	{
		private CHandle<animIAnimNodeSourceChannel_Vector> _inputTarget;
		private CHandle<animIAnimNodeSourceChannel_Vector> _inputPoleVector;
		private CHandle<animAnimNodeSourceChannel_WeightedQuat> _inputTargetOrientation;
		private animTransformIndex _firstBoneIndex;
		private animTransformIndex _secondBoneIndex;
		private animTransformIndex _endBoneIndex;
		private CEnum<animAxis> _hingeAxis;
		private CFloat _twistValue;
		private CFloat _weight;
		private animNamedTrackIndex _weightFloatTrack;
		private animFloatLink _weightNode;
		private animFloatLink _twistNode;
		private CFloat _maxHingeAngle;

		[Ordinal(12)] 
		[RED("inputTarget")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> InputTarget
		{
			get => GetProperty(ref _inputTarget);
			set => SetProperty(ref _inputTarget, value);
		}

		[Ordinal(13)] 
		[RED("inputPoleVector")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> InputPoleVector
		{
			get => GetProperty(ref _inputPoleVector);
			set => SetProperty(ref _inputPoleVector, value);
		}

		[Ordinal(14)] 
		[RED("inputTargetOrientation")] 
		public CHandle<animAnimNodeSourceChannel_WeightedQuat> InputTargetOrientation
		{
			get => GetProperty(ref _inputTargetOrientation);
			set => SetProperty(ref _inputTargetOrientation, value);
		}

		[Ordinal(15)] 
		[RED("firstBoneIndex")] 
		public animTransformIndex FirstBoneIndex
		{
			get => GetProperty(ref _firstBoneIndex);
			set => SetProperty(ref _firstBoneIndex, value);
		}

		[Ordinal(16)] 
		[RED("secondBoneIndex")] 
		public animTransformIndex SecondBoneIndex
		{
			get => GetProperty(ref _secondBoneIndex);
			set => SetProperty(ref _secondBoneIndex, value);
		}

		[Ordinal(17)] 
		[RED("endBoneIndex")] 
		public animTransformIndex EndBoneIndex
		{
			get => GetProperty(ref _endBoneIndex);
			set => SetProperty(ref _endBoneIndex, value);
		}

		[Ordinal(18)] 
		[RED("hingeAxis")] 
		public CEnum<animAxis> HingeAxis
		{
			get => GetProperty(ref _hingeAxis);
			set => SetProperty(ref _hingeAxis, value);
		}

		[Ordinal(19)] 
		[RED("twistValue")] 
		public CFloat TwistValue
		{
			get => GetProperty(ref _twistValue);
			set => SetProperty(ref _twistValue, value);
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

		[Ordinal(22)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(23)] 
		[RED("twistNode")] 
		public animFloatLink TwistNode
		{
			get => GetProperty(ref _twistNode);
			set => SetProperty(ref _twistNode, value);
		}

		[Ordinal(24)] 
		[RED("maxHingeAngle")] 
		public CFloat MaxHingeAngle
		{
			get => GetProperty(ref _maxHingeAngle);
			set => SetProperty(ref _maxHingeAngle, value);
		}

		public animAnimNode_Ik2Constraint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
