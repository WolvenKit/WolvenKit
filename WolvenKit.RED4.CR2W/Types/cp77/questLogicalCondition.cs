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
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<questIBaseCondition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		public questLogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
