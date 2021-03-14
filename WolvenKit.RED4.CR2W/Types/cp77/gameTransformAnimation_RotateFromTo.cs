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
			get
			{
				if (_startRotationEvaluator == null)
				{
					_startRotationEvaluator = (CHandle<gameTransformAnimation_Rotation>) CR2WTypeManager.Create("handle:gameTransformAnimation_Rotation", "startRotationEvaluator", cr2w, this);
				}
				return _startRotationEvaluator;
			}
			set
			{
				if (_startRotationEvaluator == value)
				{
					return;
				}
				_startRotationEvaluator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetRotationEvaluator")] 
		public CHandle<gameTransformAnimation_Rotation> TargetRotationEvaluator
		{
			get
			{
				if (_targetRotationEvaluator == null)
				{
					_targetRotationEvaluator = (CHandle<gameTransformAnimation_Rotation>) CR2WTypeManager.Create("handle:gameTransformAnimation_Rotation", "targetRotationEvaluator", cr2w, this);
				}
				return _targetRotationEvaluator;
			}
			set
			{
				if (_targetRotationEvaluator == value)
				{
					return;
				}
				_targetRotationEvaluator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get
			{
				if (_movement == null)
				{
					_movement = (CHandle<gameTransformAnimation_Movement>) CR2WTypeManager.Create("handle:gameTransformAnimation_Movement", "movement", cr2w, this);
				}
				return _movement;
			}
			set
			{
				if (_movement == value)
				{
					return;
				}
				_movement = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_RotateFromTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
