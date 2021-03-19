using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FootStepAdjuster : animAnimNode_OnePoseInput
	{
		private animTransformIndex _leftToeName;
		private animTransformIndex _rightToeName;
		private animTransformIndex _leftFootName;
		private animTransformIndex _rightFootName;
		private animTransformIndex _leftCalfName;
		private animTransformIndex _rightCalfName;
		private animTransformIndex _leftThighName;
		private animTransformIndex _rightThighName;
		private animTransformIndex _pelvisBoneName;
		private Vector4 _calfHingeAxis;
		private CFloat _iKBlendTime;
		private CFloat _pelvisAdjustmentBlendSpeed;
		private CBool _adjustPelvisVertically;
		private CFloat _stepAdjustmentInterval;
		private animFloatLink _controlValueNode;
		private animVectorLink _controlVectorNode;

		[Ordinal(12)] 
		[RED("leftToeName")] 
		public animTransformIndex LeftToeName
		{
			get => GetProperty(ref _leftToeName);
			set => SetProperty(ref _leftToeName, value);
		}

		[Ordinal(13)] 
		[RED("rightToeName")] 
		public animTransformIndex RightToeName
		{
			get => GetProperty(ref _rightToeName);
			set => SetProperty(ref _rightToeName, value);
		}

		[Ordinal(14)] 
		[RED("leftFootName")] 
		public animTransformIndex LeftFootName
		{
			get => GetProperty(ref _leftFootName);
			set => SetProperty(ref _leftFootName, value);
		}

		[Ordinal(15)] 
		[RED("rightFootName")] 
		public animTransformIndex RightFootName
		{
			get => GetProperty(ref _rightFootName);
			set => SetProperty(ref _rightFootName, value);
		}

		[Ordinal(16)] 
		[RED("leftCalfName")] 
		public animTransformIndex LeftCalfName
		{
			get => GetProperty(ref _leftCalfName);
			set => SetProperty(ref _leftCalfName, value);
		}

		[Ordinal(17)] 
		[RED("rightCalfName")] 
		public animTransformIndex RightCalfName
		{
			get => GetProperty(ref _rightCalfName);
			set => SetProperty(ref _rightCalfName, value);
		}

		[Ordinal(18)] 
		[RED("leftThighName")] 
		public animTransformIndex LeftThighName
		{
			get => GetProperty(ref _leftThighName);
			set => SetProperty(ref _leftThighName, value);
		}

		[Ordinal(19)] 
		[RED("rightThighName")] 
		public animTransformIndex RightThighName
		{
			get => GetProperty(ref _rightThighName);
			set => SetProperty(ref _rightThighName, value);
		}

		[Ordinal(20)] 
		[RED("pelvisBoneName")] 
		public animTransformIndex PelvisBoneName
		{
			get => GetProperty(ref _pelvisBoneName);
			set => SetProperty(ref _pelvisBoneName, value);
		}

		[Ordinal(21)] 
		[RED("calfHingeAxis")] 
		public Vector4 CalfHingeAxis
		{
			get => GetProperty(ref _calfHingeAxis);
			set => SetProperty(ref _calfHingeAxis, value);
		}

		[Ordinal(22)] 
		[RED("IKBlendTime")] 
		public CFloat IKBlendTime
		{
			get => GetProperty(ref _iKBlendTime);
			set => SetProperty(ref _iKBlendTime, value);
		}

		[Ordinal(23)] 
		[RED("pelvisAdjustmentBlendSpeed")] 
		public CFloat PelvisAdjustmentBlendSpeed
		{
			get => GetProperty(ref _pelvisAdjustmentBlendSpeed);
			set => SetProperty(ref _pelvisAdjustmentBlendSpeed, value);
		}

		[Ordinal(24)] 
		[RED("adjustPelvisVertically")] 
		public CBool AdjustPelvisVertically
		{
			get => GetProperty(ref _adjustPelvisVertically);
			set => SetProperty(ref _adjustPelvisVertically, value);
		}

		[Ordinal(25)] 
		[RED("stepAdjustmentInterval")] 
		public CFloat StepAdjustmentInterval
		{
			get => GetProperty(ref _stepAdjustmentInterval);
			set => SetProperty(ref _stepAdjustmentInterval, value);
		}

		[Ordinal(26)] 
		[RED("controlValueNode")] 
		public animFloatLink ControlValueNode
		{
			get => GetProperty(ref _controlValueNode);
			set => SetProperty(ref _controlValueNode, value);
		}

		[Ordinal(27)] 
		[RED("controlVectorNode")] 
		public animVectorLink ControlVectorNode
		{
			get => GetProperty(ref _controlVectorNode);
			set => SetProperty(ref _controlVectorNode, value);
		}

		public animAnimNode_FootStepAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
