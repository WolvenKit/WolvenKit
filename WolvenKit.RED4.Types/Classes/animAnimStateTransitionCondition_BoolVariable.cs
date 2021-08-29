using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_BoolVariable : animIAnimStateTransitionCondition
	{
		private CName _variableName;
		private CBool _compareValue;

		[Ordinal(0)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetProperty(ref _variableName);
			set => SetProperty(ref _variableName, value);
		}

		[Ordinal(1)] 
		[RED("compareValue")] 
		public CBool CompareValue
		{
			get => GetProperty(ref _compareValue);
			set => SetProperty(ref _compareValue, value);
		}
	}
}
