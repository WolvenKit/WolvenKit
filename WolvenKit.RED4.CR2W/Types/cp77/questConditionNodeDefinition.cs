using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questConditionNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIBaseCondition> _condition;

		[Ordinal(2)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		public questConditionNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
