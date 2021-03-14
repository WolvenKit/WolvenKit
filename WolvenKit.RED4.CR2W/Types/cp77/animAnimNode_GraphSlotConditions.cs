using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlotConditions : animAnimNode_GraphSlot
	{
		private CArray<animGraphSlotCondition> _conditions;

		[Ordinal(14)] 
		[RED("conditions")] 
		public CArray<animGraphSlotCondition> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<animGraphSlotCondition>) CR2WTypeManager.Create("array:animGraphSlotCondition", "conditions", cr2w, this);
				}
				return _conditions;
			}
			set
			{
				if (_conditions == value)
				{
					return;
				}
				_conditions = value;
				PropertySet(this);
			}
		}

		public animAnimNode_GraphSlotConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
