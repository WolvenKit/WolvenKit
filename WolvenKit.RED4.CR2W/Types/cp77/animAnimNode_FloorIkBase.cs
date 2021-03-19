using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloorIkBase : animAnimNode_OnePoseInput
	{
		private CName _requiredAnimEvent;
		private CName _blockAnimEvent;
		private CBool _canBeDisabledDueToFrameRate;
		private CBool _useFixedVersion;
		private CFloat _slopeAngleDamp;
		private animSBehaviorConstraintNodeFloorIKCommonData _common;

		[Ordinal(12)] 
		[RED("requiredAnimEvent")] 
		public CName RequiredAnimEvent
		{
			get => GetProperty(ref _requiredAnimEvent);
			set => SetProperty(ref _requiredAnimEvent, value);
		}

		[Ordinal(13)] 
		[RED("blockAnimEvent")] 
		public CName BlockAnimEvent
		{
			get => GetProperty(ref _blockAnimEvent);
			set => SetProperty(ref _blockAnimEvent, value);
		}

		[Ordinal(14)] 
		[RED("canBeDisabledDueToFrameRate")] 
		public CBool CanBeDisabledDueToFrameRate
		{
			get => GetProperty(ref _canBeDisabledDueToFrameRate);
			set => SetProperty(ref _canBeDisabledDueToFrameRate, value);
		}

		[Ordinal(15)] 
		[RED("useFixedVersion")] 
		public CBool UseFixedVersion
		{
			get => GetProperty(ref _useFixedVersion);
			set => SetProperty(ref _useFixedVersion, value);
		}

		[Ordinal(16)] 
		[RED("slopeAngleDamp")] 
		public CFloat SlopeAngleDamp
		{
			get => GetProperty(ref _slopeAngleDamp);
			set => SetProperty(ref _slopeAngleDamp, value);
		}

		[Ordinal(17)] 
		[RED("common")] 
		public animSBehaviorConstraintNodeFloorIKCommonData Common
		{
			get => GetProperty(ref _common);
			set => SetProperty(ref _common, value);
		}

		public animAnimNode_FloorIkBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
