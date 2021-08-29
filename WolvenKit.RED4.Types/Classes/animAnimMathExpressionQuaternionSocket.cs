using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimMathExpressionQuaternionSocket : RedBaseClass
	{
		private animQuaternionLink _link;
		private CUInt16 _expressionVarId;

		[Ordinal(0)] 
		[RED("link")] 
		public animQuaternionLink Link
		{
			get => GetProperty(ref _link);
			set => SetProperty(ref _link, value);
		}

		[Ordinal(1)] 
		[RED("expressionVarId")] 
		public CUInt16 ExpressionVarId
		{
			get => GetProperty(ref _expressionVarId);
			set => SetProperty(ref _expressionVarId, value);
		}
	}
}
