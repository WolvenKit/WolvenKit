using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionLookatParams : CVariable
	{
		private CBool _useLookat;
		private CBool _useLeftHand;
		private CBool _useRightHand;
		private CBool _attachRightHandtoLeftHand;
		private CBool _attachLeftHandtoRightHand;
		private CName _slotName;
		private CEnum<animLookAtStyle> _lookatStyle;
		private CBool _hasOutTransition;
		private CEnum<animLookAtStyle> _outTransitionStyle;
		private CEnum<animLookAtLimitDegreesType> _softLimitDegrees;
		private CEnum<animLookAtLimitDegreesType> _hardLimitDegrees;
		private CEnum<animLookAtLimitDistanceType> _hardLimitDistance;
		private CEnum<animLookAtLimitDegreesType> _backLimitDegrees;
		private CArray<animLookAtPartRequest> _additionalParts;

		[Ordinal(0)] 
		[RED("useLookat")] 
		public CBool UseLookat
		{
			get => GetProperty(ref _useLookat);
			set => SetProperty(ref _useLookat, value);
		}

		[Ordinal(1)] 
		[RED("useLeftHand")] 
		public CBool UseLeftHand
		{
			get => GetProperty(ref _useLeftHand);
			set => SetProperty(ref _useLeftHand, value);
		}

		[Ordinal(2)] 
		[RED("useRightHand")] 
		public CBool UseRightHand
		{
			get => GetProperty(ref _useRightHand);
			set => SetProperty(ref _useRightHand, value);
		}

		[Ordinal(3)] 
		[RED("attachRightHandtoLeftHand")] 
		public CBool AttachRightHandtoLeftHand
		{
			get => GetProperty(ref _attachRightHandtoLeftHand);
			set => SetProperty(ref _attachRightHandtoLeftHand, value);
		}

		[Ordinal(4)] 
		[RED("attachLeftHandtoRightHand")] 
		public CBool AttachLeftHandtoRightHand
		{
			get => GetProperty(ref _attachLeftHandtoRightHand);
			set => SetProperty(ref _attachLeftHandtoRightHand, value);
		}

		[Ordinal(5)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(6)] 
		[RED("lookatStyle")] 
		public CEnum<animLookAtStyle> LookatStyle
		{
			get => GetProperty(ref _lookatStyle);
			set => SetProperty(ref _lookatStyle, value);
		}

		[Ordinal(7)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get => GetProperty(ref _hasOutTransition);
			set => SetProperty(ref _hasOutTransition, value);
		}

		[Ordinal(8)] 
		[RED("outTransitionStyle")] 
		public CEnum<animLookAtStyle> OutTransitionStyle
		{
			get => GetProperty(ref _outTransitionStyle);
			set => SetProperty(ref _outTransitionStyle, value);
		}

		[Ordinal(9)] 
		[RED("softLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> SoftLimitDegrees
		{
			get => GetProperty(ref _softLimitDegrees);
			set => SetProperty(ref _softLimitDegrees, value);
		}

		[Ordinal(10)] 
		[RED("hardLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> HardLimitDegrees
		{
			get => GetProperty(ref _hardLimitDegrees);
			set => SetProperty(ref _hardLimitDegrees, value);
		}

		[Ordinal(11)] 
		[RED("hardLimitDistance")] 
		public CEnum<animLookAtLimitDistanceType> HardLimitDistance
		{
			get => GetProperty(ref _hardLimitDistance);
			set => SetProperty(ref _hardLimitDistance, value);
		}

		[Ordinal(12)] 
		[RED("backLimitDegrees")] 
		public CEnum<animLookAtLimitDegreesType> BackLimitDegrees
		{
			get => GetProperty(ref _backLimitDegrees);
			set => SetProperty(ref _backLimitDegrees, value);
		}

		[Ordinal(13)] 
		[RED("additionalParts")] 
		public CArray<animLookAtPartRequest> AdditionalParts
		{
			get => GetProperty(ref _additionalParts);
			set => SetProperty(ref _additionalParts, value);
		}

		public AIActionLookatParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
