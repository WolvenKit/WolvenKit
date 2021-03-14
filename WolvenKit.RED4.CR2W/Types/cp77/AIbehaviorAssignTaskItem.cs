using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAssignTaskItem : CVariable
	{
		private CHandle<AIArgumentMapping> _leftHandSide;
		private CHandle<AIArgumentMapping> _rightHandSide;

		[Ordinal(0)] 
		[RED("leftHandSide")] 
		public CHandle<AIArgumentMapping> LeftHandSide
		{
			get
			{
				if (_leftHandSide == null)
				{
					_leftHandSide = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "leftHandSide", cr2w, this);
				}
				return _leftHandSide;
			}
			set
			{
				if (_leftHandSide == value)
				{
					return;
				}
				_leftHandSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rightHandSide")] 
		public CHandle<AIArgumentMapping> RightHandSide
		{
			get
			{
				if (_rightHandSide == null)
				{
					_rightHandSide = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rightHandSide", cr2w, this);
				}
				return _rightHandSide;
			}
			set
			{
				if (_rightHandSide == value)
				{
					return;
				}
				_rightHandSide = value;
				PropertySet(this);
			}
		}

		public AIbehaviorAssignTaskItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
