using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqCheckData : RedBaseClass
	{
		private CEnum<gameEPrerequisiteType> _prereqType;
		private CEnum<EComparisonType> _comparisonType;
		private CString _contextObject;
		private CFloat _valueToCompare;

		[Ordinal(0)] 
		[RED("prereqType")] 
		public CEnum<gameEPrerequisiteType> PrereqType
		{
			get => GetProperty(ref _prereqType);
			set => SetProperty(ref _prereqType, value);
		}

		[Ordinal(1)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(2)] 
		[RED("contextObject")] 
		public CString ContextObject
		{
			get => GetProperty(ref _contextObject);
			set => SetProperty(ref _contextObject, value);
		}

		[Ordinal(3)] 
		[RED("valueToCompare")] 
		public CFloat ValueToCompare
		{
			get => GetProperty(ref _valueToCompare);
			set => SetProperty(ref _valueToCompare, value);
		}

		public gamePrereqCheckData()
		{
			_comparisonType = new() { Value = Enums.EComparisonType.Equal };
		}
	}
}
