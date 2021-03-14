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
			get
			{
				if (_expression == null)
				{
					_expression = (CHandle<mathExprExpression>) CR2WTypeManager.Create("handle:mathExprExpression", "expression", cr2w, this);
				}
				return _expression;
			}
			set
			{
				if (_expression == value)
				{
					return;
				}
				_expression = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("floatSockets")] 
		public CArray<animAnimMathExpressionFloatSocket> FloatSockets
		{
			get
			{
				if (_floatSockets == null)
				{
					_floatSockets = (CArray<animAnimMathExpressionFloatSocket>) CR2WTypeManager.Create("array:animAnimMathExpressionFloatSocket", "floatSockets", cr2w, this);
				}
				return _floatSockets;
			}
			set
			{
				if (_floatSockets == value)
				{
					return;
				}
				_floatSockets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("vectorSockets")] 
		public CArray<animAnimMathExpressionVectorSocket> VectorSockets
		{
			get
			{
				if (_vectorSockets == null)
				{
					_vectorSockets = (CArray<animAnimMathExpressionVectorSocket>) CR2WTypeManager.Create("array:animAnimMathExpressionVectorSocket", "vectorSockets", cr2w, this);
				}
				return _vectorSockets;
			}
			set
			{
				if (_vectorSockets == value)
				{
					return;
				}
				_vectorSockets = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("quaternionSockets")] 
		public CArray<animAnimMathExpressionQuaternionSocket> QuaternionSockets
		{
			get
			{
				if (_quaternionSockets == null)
				{
					_quaternionSockets = (CArray<animAnimMathExpressionQuaternionSocket>) CR2WTypeManager.Create("array:animAnimMathExpressionQuaternionSocket", "quaternionSockets", cr2w, this);
				}
				return _quaternionSockets;
			}
			set
			{
				if (_quaternionSockets == value)
				{
					return;
				}
				_quaternionSockets = value;
				PropertySet(this);
			}
		}

		public animMathExpressionNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
