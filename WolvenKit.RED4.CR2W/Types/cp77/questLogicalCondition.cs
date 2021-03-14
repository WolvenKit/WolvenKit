using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLogicalCondition : questCondition
	{
		private CEnum<questLogicalOperation> _operation;
		private CArray<CHandle<questIBaseCondition>> _conditions;

		[Ordinal(0)] 
		[RED("operation")] 
		public CEnum<questLogicalOperation> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CEnum<questLogicalOperation>) CR2WTypeManager.Create("questLogicalOperation", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<questIBaseCondition>> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<CHandle<questIBaseCondition>>) CR2WTypeManager.Create("array:handle:questIBaseCondition", "conditions", cr2w, this);
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

		public questLogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
