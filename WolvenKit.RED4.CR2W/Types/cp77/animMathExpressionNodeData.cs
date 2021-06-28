using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animMathExpressionNodeData : CVariable
	{
		private CHandle<mathExprExpression> _expression;
		private CArray<animAnimMathExpressionFloatSocket> _floatSockets;
		private CArray<animAnimMathExpressionVectorSocket> _vectorSockets;
		private CArray<animAnimMathExpressionQuaternionSocket> _quaternionSockets;

		[Ordinal(0)] 
		[RED("expression")] 
		public CHandle<mathExprExpression> Expression
		{
			get => GetProperty(ref _expression);
			set => SetProperty(ref _expression, value);
		}

		[Ordinal(1)] 
		[RED("floatSockets")] 
		public CArray<animAnimMathExpressionFloatSocket> FloatSockets
		{
			get => GetProperty(ref _floatSockets);
			set => SetProperty(ref _floatSockets, value);
		}

		[Ordinal(2)] 
		[RED("vectorSockets")] 
		public CArray<animAnimMathExpressionVectorSocket> VectorSockets
		{
			get => GetProperty(ref _vectorSockets);
			set => SetProperty(ref _vectorSockets, value);
		}

		[Ordinal(3)] 
		[RED("quaternionSockets")] 
		public CArray<animAnimMathExpressionQuaternionSocket> QuaternionSockets
		{
			get => GetProperty(ref _quaternionSockets);
			set => SetProperty(ref _quaternionSockets, value);
		}

		public animMathExpressionNodeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
