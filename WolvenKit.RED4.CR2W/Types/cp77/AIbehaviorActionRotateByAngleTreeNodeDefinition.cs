using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateByAngleTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _angle;
		private CHandle<AIArgumentMapping> _angleTolerance;

		[Ordinal(1)] 
		[RED("angle")] 
		public CHandle<AIArgumentMapping> Angle
		{
			get
			{
				if (_angle == null)
				{
					_angle = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "angle", cr2w, this);
				}
				return _angle;
			}
			set
			{
				if (_angle == value)
				{
					return;
				}
				_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public AIbehaviorActionRotateByAngleTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
