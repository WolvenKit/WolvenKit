using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMovementPolicyTaskItemDefinition : ISerializable
	{
		private CEnum<AIbehaviorMovementPolicyTaskFunctions> _function;
		private CStatic<CHandle<AIbehaviorExpressionSocket>> _params;

		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<AIbehaviorMovementPolicyTaskFunctions> Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}

		[Ordinal(1)] 
		[RED("params", 4)] 
		public CStatic<CHandle<AIbehaviorExpressionSocket>> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public AIbehaviorMovementPolicyTaskItemDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
