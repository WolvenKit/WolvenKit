using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Ik2 : animAnimNode_Base
	{
		private animTransformIndex _firstBone;
		private animTransformIndex _secondBone;
		private animTransformIndex _endBone;
		private CEnum<animAxis> _hingeAxis;
		private CFloat _minHingeAngleDegrees;
		private CFloat _maxHingeAngleDegrees;
		private CFloat _firstBoneIkGain;
		private CFloat _secondBoneIkGain;
		private CFloat _endBoneIkGain;
		private CBool _enforceEndPosition;
		private CBool _enforceEndOrientation;
		private Vector4 _endBoneOffsetPositionLS;
		private animTransformIndex _bone;
		private animNamedTrackIndex _floatTrack;
		private animPoseLink _inputPoseNode;
		private animFloatLink _weightNode;
		private animVectorLink _endTargetPositionNode;
		private animQuaternionLink _endTargetOrientationNode;

		[Ordinal(11)] 
		[RED("firstBone")] 
		public animTransformIndex FirstBone
		{
			get => GetProperty(ref _firstBone);
			set => SetProperty(ref _firstBone, value);
		}

		[Ordinal(12)] 
		[RED("secondBone")] 
		public animTransformIndex SecondBone
		{
			get => GetProperty(ref _secondBone);
			set => SetProperty(ref _secondBone, value);
		}

		[Ordinal(13)] 
		[RED("endBone")] 
		public animTransformIndex EndBone
		{
			get => GetProperty(ref _endBone);
			set => SetProperty(ref _endBone, value);
		}

		[Ordinal(14)] 
		[RED("hingeAxis")] 
		public CEnum<animAxis> HingeAxis
		{
			get => GetProperty(ref _hingeAxis);
			set => SetProperty(ref _hingeAxis, value);
		}

		[Ordinal(15)] 
		[RED("minHingeAngleDegrees")] 
		public CFloat MinHingeAngleDegrees
		{
			get => GetProperty(ref _minHingeAngleDegrees);
			set => SetProperty(ref _minHingeAngleDegrees, value);
		}

		[Ordinal(16)] 
		[RED("maxHingeAngleDegrees")] 
		public CFloat MaxHingeAngleDegrees
		{
			get => GetProperty(ref _maxHingeAngleDegrees);
			set => SetProperty(ref _maxHingeAngleDegrees, value);
		}

		[Ordinal(17)] 
		[RED("firstBoneIkGain")] 
		public CFloat FirstBoneIkGain
		{
			get => GetProperty(ref _firstBoneIkGain);
			set => SetProperty(ref _firstBoneIkGain, value);
		}

		[Ordinal(18)] 
		[RED("secondBoneIkGain")] 
		public CFloat SecondBoneIkGain
		{
			get => GetProperty(ref _secondBoneIkGain);
			set => SetProperty(ref _secondBoneIkGain, value);
		}

		[Ordinal(19)] 
		[RED("endBoneIkGain")] 
		public CFloat EndBoneIkGain
		{
			get => GetProperty(ref _endBoneIkGain);
			set => SetProperty(ref _endBoneIkGain, value);
		}

		[Ordinal(20)] 
		[RED("enforceEndPosition")] 
		public CBool EnforceEndPosition
		{
			get => GetProperty(ref _enforceEndPosition);
			set => SetProperty(ref _enforceEndPosition, value);
		}

		[Ordinal(21)] 
		[RED("enforceEndOrientation")] 
		public CBool EnforceEndOrientation
		{
			get => GetProperty(ref _enforceEndOrientation);
			set => SetProperty(ref _enforceEndOrientation, value);
		}

		[Ordinal(22)] 
		[RED("endBoneOffsetPositionLS")] 
		public Vector4 EndBoneOffsetPositionLS
		{
			get => GetProperty(ref _endBoneOffsetPositionLS);
			set => SetProperty(ref _endBoneOffsetPositionLS, value);
		}

		[Ordinal(23)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(24)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get => GetProperty(ref _floatTrack);
			set => SetProperty(ref _floatTrack, value);
		}

		[Ordinal(25)] 
		[RED("inputPoseNode")] 
		public animPoseLink InputPoseNode
		{
			get => GetProperty(ref _inputPoseNode);
			set => SetProperty(ref _inputPoseNode, value);
		}

		[Ordinal(26)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(27)] 
		[RED("endTargetPositionNode")] 
		public animVectorLink EndTargetPositionNode
		{
			get => GetProperty(ref _endTargetPositionNode);
			set => SetProperty(ref _endTargetPositionNode, value);
		}

		[Ordinal(28)] 
		[RED("endTargetOrientationNode")] 
		public animQuaternionLink EndTargetOrientationNode
		{
			get => GetProperty(ref _endTargetOrientationNode);
			set => SetProperty(ref _endTargetOrientationNode, value);
		}

		public animAnimNode_Ik2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
