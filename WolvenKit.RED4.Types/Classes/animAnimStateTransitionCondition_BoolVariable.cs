using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_BoolVariable : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("compareValue")] 
		public CBool CompareValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
