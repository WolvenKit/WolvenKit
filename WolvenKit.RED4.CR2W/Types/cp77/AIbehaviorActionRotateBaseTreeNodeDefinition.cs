using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateBaseTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _angleOffset;
		private CHandle<AIArgumentMapping> _angleTolerance;
		private CHandle<AIArgumentMapping> _speed;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("angleOffset")] 
		public CHandle<AIArgumentMapping> AngleOffset
		{
			get
			{
				if (_angleOffset == null)
				{
					_angleOffset = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "angleOffset", cr2w, this);
				}
				return _angleOffset;
			}
			set
			{
				if (_angleOffset == value)
				{
					return;
				}
				_angleOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("angleTolerance")] 
		public CHandle<AIArgumentMapping> AngleTolerance
		{
			get
			{
				if (_angleTolerance == null)
				{
					_angleTolerance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "angleTolerance", cr2w, this);
				}
				return _angleTolerance;
			}
			set
			{
				if (_angleTolerance == value)
				{
					return;
				}
				_angleTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("speed")] 
		public CHandle<AIArgumentMapping> Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionRotateBaseTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
