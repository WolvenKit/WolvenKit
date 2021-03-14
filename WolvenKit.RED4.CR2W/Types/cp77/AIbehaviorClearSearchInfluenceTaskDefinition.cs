using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorClearSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _clearedAreaRadius;
		private CHandle<AIArgumentMapping> _clearedAreaDistance;
		private CHandle<AIArgumentMapping> _clearedAreaAngle;

		[Ordinal(1)] 
		[RED("clearedAreaRadius")] 
		public CHandle<AIArgumentMapping> ClearedAreaRadius
		{
			get
			{
				if (_clearedAreaRadius == null)
				{
					_clearedAreaRadius = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "clearedAreaRadius", cr2w, this);
				}
				return _clearedAreaRadius;
			}
			set
			{
				if (_clearedAreaRadius == value)
				{
					return;
				}
				_clearedAreaRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("clearedAreaDistance")] 
		public CHandle<AIArgumentMapping> ClearedAreaDistance
		{
			get
			{
				if (_clearedAreaDistance == null)
				{
					_clearedAreaDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "clearedAreaDistance", cr2w, this);
				}
				return _clearedAreaDistance;
			}
			set
			{
				if (_clearedAreaDistance == value)
				{
					return;
				}
				_clearedAreaDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("clearedAreaAngle")] 
		public CHandle<AIArgumentMapping> ClearedAreaAngle
		{
			get
			{
				if (_clearedAreaAngle == null)
				{
					_clearedAreaAngle = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "clearedAreaAngle", cr2w, this);
				}
				return _clearedAreaAngle;
			}
			set
			{
				if (_clearedAreaAngle == value)
				{
					return;
				}
				_clearedAreaAngle = value;
				PropertySet(this);
			}
		}

		public AIbehaviorClearSearchInfluenceTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
