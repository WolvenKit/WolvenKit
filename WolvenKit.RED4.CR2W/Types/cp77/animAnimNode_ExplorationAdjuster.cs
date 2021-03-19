using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ExplorationAdjuster : animAnimNode_MotionAdjuster
	{
		private animVectorLink _targetPosition2;
		private animVectorLink _targetDirection2;
		private animFloatLink _totalTimeToAdjust2;
		private animVectorLink _targetPosition3;
		private animVectorLink _targetDirection3;
		private animFloatLink _totalTimeToAdjust3;

		[Ordinal(16)] 
		[RED("targetPosition2")] 
		public animVectorLink TargetPosition2
		{
			get => GetProperty(ref _targetPosition2);
			set => SetProperty(ref _targetPosition2, value);
		}

		[Ordinal(17)] 
		[RED("targetDirection2")] 
		public animVectorLink TargetDirection2
		{
			get => GetProperty(ref _targetDirection2);
			set => SetProperty(ref _targetDirection2, value);
		}

		[Ordinal(18)] 
		[RED("totalTimeToAdjust2")] 
		public animFloatLink TotalTimeToAdjust2
		{
			get => GetProperty(ref _totalTimeToAdjust2);
			set => SetProperty(ref _totalTimeToAdjust2, value);
		}

		[Ordinal(19)] 
		[RED("targetPosition3")] 
		public animVectorLink TargetPosition3
		{
			get => GetProperty(ref _targetPosition3);
			set => SetProperty(ref _targetPosition3, value);
		}

		[Ordinal(20)] 
		[RED("targetDirection3")] 
		public animVectorLink TargetDirection3
		{
			get => GetProperty(ref _targetDirection3);
			set => SetProperty(ref _targetDirection3, value);
		}

		[Ordinal(21)] 
		[RED("totalTimeToAdjust3")] 
		public animFloatLink TotalTimeToAdjust3
		{
			get => GetProperty(ref _totalTimeToAdjust3);
			set => SetProperty(ref _totalTimeToAdjust3, value);
		}

		public animAnimNode_ExplorationAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
