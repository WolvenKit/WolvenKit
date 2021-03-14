using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workConditionalSequence : workSequence
	{
		private CEnum<workLogicalOperation> _multipleConditionOperator;
		private CArray<CHandle<workIWorkspotCondition>> _conditionList;

		[Ordinal(7)] 
		[RED("multipleConditionOperator")] 
		public CEnum<workLogicalOperation> MultipleConditionOperator
		{
			get
			{
				if (_multipleConditionOperator == null)
				{
					_multipleConditionOperator = (CEnum<workLogicalOperation>) CR2WTypeManager.Create("workLogicalOperation", "multipleConditionOperator", cr2w, this);
				}
				return _multipleConditionOperator;
			}
			set
			{
				if (_multipleConditionOperator == value)
				{
					return;
				}
				_multipleConditionOperator = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("conditionList")] 
		public CArray<CHandle<workIWorkspotCondition>> ConditionList
		{
			get
			{
				if (_conditionList == null)
				{
					_conditionList = (CArray<CHandle<workIWorkspotCondition>>) CR2WTypeManager.Create("array:handle:workIWorkspotCondition", "conditionList", cr2w, this);
				}
				return _conditionList;
			}
			set
			{
				if (_conditionList == value)
				{
					return;
				}
				_conditionList = value;
				PropertySet(this);
			}
		}

		public workConditionalSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
