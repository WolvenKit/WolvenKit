using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ConditionalSegmentBegin_ : animAnimNode_OnePoseInput
	{
		private animConditionalSegmentCondition _condition;

		[Ordinal(13)] 
		[RED("condition")] 
		public animConditionalSegmentCondition Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (animConditionalSegmentCondition) CR2WTypeManager.Create("animConditionalSegmentCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		public animAnimNode_ConditionalSegmentBegin_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
