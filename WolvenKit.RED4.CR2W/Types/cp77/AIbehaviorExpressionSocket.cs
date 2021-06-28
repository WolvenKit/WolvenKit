using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExpressionSocket : ISerializable
	{
		private AIbehaviorTypeRef _typeHint;
		private CHandle<AIbehaviorPassiveExpressionDefinition> _expression;

		[Ordinal(0)] 
		[RED("typeHint")] 
		public AIbehaviorTypeRef TypeHint
		{
			get => GetProperty(ref _typeHint);
			set => SetProperty(ref _typeHint, value);
		}

		[Ordinal(1)] 
		[RED("expression")] 
		public CHandle<AIbehaviorPassiveExpressionDefinition> Expression
		{
			get => GetProperty(ref _expression);
			set => SetProperty(ref _expression, value);
		}

		public AIbehaviorExpressionSocket(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
