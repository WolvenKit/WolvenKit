using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimsetVariableCondition : animIRuntimeCondition
	{
		private CName _variableToCompare;
		private CFloat _valueToCompare;

		[Ordinal(0)] 
		[RED("variableToCompare")] 
		public CName VariableToCompare
		{
			get => GetProperty(ref _variableToCompare);
			set => SetProperty(ref _variableToCompare, value);
		}

		[Ordinal(1)] 
		[RED("valueToCompare")] 
		public CFloat ValueToCompare
		{
			get => GetProperty(ref _valueToCompare);
			set => SetProperty(ref _valueToCompare, value);
		}

		public animAnimsetVariableCondition()
		{
			_valueToCompare = 0.500000F;
		}
	}
}
