using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MathExpressionVector_ : animAnimNode_VectorValue
	{
		private animMathExpressionNodeData _expressionData;

		[Ordinal(11)] 
		[RED("expressionData")] 
		public animMathExpressionNodeData ExpressionData
		{
			get => GetProperty(ref _expressionData);
			set => SetProperty(ref _expressionData, value);
		}

		public animAnimNode_MathExpressionVector_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
