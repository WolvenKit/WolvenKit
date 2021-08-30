using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayFactCondition : GameplayConditionBase
	{
		private CName _factName;
		private CInt32 _value;
		private CEnum<ECompareOp> _comparisonType;
		private CString _description;

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<ECompareOp> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(4)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		public GameplayFactCondition()
		{
			_description = new() { Text = "Quest progress" };
		}
	}
}
