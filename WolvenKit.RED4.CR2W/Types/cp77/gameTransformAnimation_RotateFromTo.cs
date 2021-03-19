using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_RotateFromTo : gameTransformAnimationTrackItemImpl
	{
		private CHandle<gameTransformAnimation_Rotation> _startRotationEvaluator;
		private CHandle<gameTransformAnimation_Rotation> _targetRotationEvaluator;
		private CHandle<gameTransformAnimation_Movement> _movement;

		[Ordinal(0)] 
		[RED("startRotationEvaluator")] 
		public CHandle<gameTransformAnimation_Rotation> StartRotationEvaluator
		{
			get => GetProperty(ref _startRotationEvaluator);
			set => SetProperty(ref _startRotationEvaluator, value);
		}

		[Ordinal(1)] 
		[RED("targetRotationEvaluator")] 
		public CHandle<gameTransformAnimation_Rotation> TargetRotationEvaluator
		{
			get => GetProperty(ref _targetRotationEvaluator);
			set => SetProperty(ref _targetRotationEvaluator, value);
		}

		[Ordinal(2)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get => GetProperty(ref _movement);
			set => SetProperty(ref _movement, value);
		}

		public gameTransformAnimation_RotateFromTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
