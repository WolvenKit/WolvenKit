using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Move : gameTransformAnimationTrackItemImpl
	{
		private CHandle<gameTransformAnimation_Position> _startPositionEvaluator;
		private CHandle<gameTransformAnimation_Position> _targetPositionEvaluator;
		private CHandle<gameTransformAnimation_Movement> _movement;

		[Ordinal(0)] 
		[RED("startPositionEvaluator")] 
		public CHandle<gameTransformAnimation_Position> StartPositionEvaluator
		{
			get
			{
				if (_startPositionEvaluator == null)
				{
					_startPositionEvaluator = (CHandle<gameTransformAnimation_Position>) CR2WTypeManager.Create("handle:gameTransformAnimation_Position", "startPositionEvaluator", cr2w, this);
				}
				return _startPositionEvaluator;
			}
			set
			{
				if (_startPositionEvaluator == value)
				{
					return;
				}
				_startPositionEvaluator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetPositionEvaluator")] 
		public CHandle<gameTransformAnimation_Position> TargetPositionEvaluator
		{
			get
			{
				if (_targetPositionEvaluator == null)
				{
					_targetPositionEvaluator = (CHandle<gameTransformAnimation_Position>) CR2WTypeManager.Create("handle:gameTransformAnimation_Position", "targetPositionEvaluator", cr2w, this);
				}
				return _targetPositionEvaluator;
			}
			set
			{
				if (_targetPositionEvaluator == value)
				{
					return;
				}
				_targetPositionEvaluator = value;
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

		public gameTransformAnimation_Move(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
