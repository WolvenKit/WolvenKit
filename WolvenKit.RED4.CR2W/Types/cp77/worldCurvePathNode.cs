using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCurvePathNode : worldSplineNode
	{
		private animCurvePathBakerUserInput _userInput;
		private Vector4 _defaultForwardVector;
		private CFloat _globalInBlendTime;
		private CFloat _globalOutBlendTime;
		private CName _defaultPoseAnimationName;
		private CFloat _defaultPoseSampleTime;
		private CFloat _initialDiffYaw;
		private CBool _turnCharacterToMatchVelocity;
		private rRef<animRig> _rig;
		private CArray<rRef<animAnimSet>> _animSets;
		private CFloat _timeDeltaMultiplier;

		[Ordinal(9)] 
		[RED("userInput")] 
		public animCurvePathBakerUserInput UserInput
		{
			get => GetProperty(ref _userInput);
			set => SetProperty(ref _userInput, value);
		}

		[Ordinal(10)] 
		[RED("defaultForwardVector")] 
		public Vector4 DefaultForwardVector
		{
			get => GetProperty(ref _defaultForwardVector);
			set => SetProperty(ref _defaultForwardVector, value);
		}

		[Ordinal(11)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get => GetProperty(ref _globalInBlendTime);
			set => SetProperty(ref _globalInBlendTime, value);
		}

		[Ordinal(12)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get => GetProperty(ref _globalOutBlendTime);
			set => SetProperty(ref _globalOutBlendTime, value);
		}

		[Ordinal(13)] 
		[RED("defaultPoseAnimationName")] 
		public CName DefaultPoseAnimationName
		{
			get => GetProperty(ref _defaultPoseAnimationName);
			set => SetProperty(ref _defaultPoseAnimationName, value);
		}

		[Ordinal(14)] 
		[RED("defaultPoseSampleTime")] 
		public CFloat DefaultPoseSampleTime
		{
			get => GetProperty(ref _defaultPoseSampleTime);
			set => SetProperty(ref _defaultPoseSampleTime, value);
		}

		[Ordinal(15)] 
		[RED("initialDiffYaw")] 
		public CFloat InitialDiffYaw
		{
			get => GetProperty(ref _initialDiffYaw);
			set => SetProperty(ref _initialDiffYaw, value);
		}

		[Ordinal(16)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get => GetProperty(ref _turnCharacterToMatchVelocity);
			set => SetProperty(ref _turnCharacterToMatchVelocity, value);
		}

		[Ordinal(17)] 
		[RED("rig")] 
		public rRef<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(18)] 
		[RED("animSets")] 
		public CArray<rRef<animAnimSet>> AnimSets
		{
			get => GetProperty(ref _animSets);
			set => SetProperty(ref _animSets, value);
		}

		[Ordinal(19)] 
		[RED("timeDeltaMultiplier")] 
		public CFloat TimeDeltaMultiplier
		{
			get => GetProperty(ref _timeDeltaMultiplier);
			set => SetProperty(ref _timeDeltaMultiplier, value);
		}

		public worldCurvePathNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
