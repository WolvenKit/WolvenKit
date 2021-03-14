using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionSlideNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _duration;
		private CHandle<AIArgumentMapping> _ignoreNavigation;
		private CHandle<AIArgumentMapping> _rotateTowardsMovementDirection;

		[Ordinal(1)] 
		[RED("duration")] 
		public CHandle<AIArgumentMapping> Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ignoreNavigation")] 
		public CHandle<AIArgumentMapping> IgnoreNavigation
		{
			get
			{
				if (_ignoreNavigation == null)
				{
					_ignoreNavigation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "ignoreNavigation", cr2w, this);
				}
				return _ignoreNavigation;
			}
			set
			{
				if (_ignoreNavigation == value)
				{
					return;
				}
				_ignoreNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rotateTowardsMovementDirection")] 
		public CHandle<AIArgumentMapping> RotateTowardsMovementDirection
		{
			get
			{
				if (_rotateTowardsMovementDirection == null)
				{
					_rotateTowardsMovementDirection = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rotateTowardsMovementDirection", cr2w, this);
				}
				return _rotateTowardsMovementDirection;
			}
			set
			{
				if (_rotateTowardsMovementDirection == value)
				{
					return;
				}
				_rotateTowardsMovementDirection = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionSlideNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
