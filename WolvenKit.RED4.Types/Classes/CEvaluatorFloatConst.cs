using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEvaluatorFloatConst : IEvaluatorFloat
	{
		private CFloat _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public CEvaluatorFloatConst()
		{
			_value = 1.000000F;
		}
	}
}
