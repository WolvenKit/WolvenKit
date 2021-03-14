using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectCombatTargetTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CBool _targetClosest;

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
		[RED("targetClosest")] 
		public CBool TargetClosest
		{
			get
			{
				if (_targetClosest == null)
				{
					_targetClosest = (CBool) CR2WTypeManager.Create("Bool", "targetClosest", cr2w, this);
				}
				return _targetClosest;
			}
			set
			{
				if (_targetClosest == value)
				{
					return;
				}
				_targetClosest = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSelectCombatTargetTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
