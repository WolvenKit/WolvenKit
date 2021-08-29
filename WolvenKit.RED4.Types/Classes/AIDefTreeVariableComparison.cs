using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDefTreeVariableComparison : LibTreeDefTreeVariableBoolBase
	{
		private CBool _exportAsProperty;
		private CUInt16 _referenceVariableId;
		private CName _referenceVariableName;
		private CName _referenceVariableShortName;
		private CName _referenceType;
		private CEnum<EComparisonType> _operator;
		private CVariant _referenceValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get => GetProperty(ref _exportAsProperty);
			set => SetProperty(ref _exportAsProperty, value);
		}

		[Ordinal(3)] 
		[RED("referenceVariableId")] 
		public CUInt16 ReferenceVariableId
		{
			get => GetProperty(ref _referenceVariableId);
			set => SetProperty(ref _referenceVariableId, value);
		}

		[Ordinal(4)] 
		[RED("referenceVariableName")] 
		public CName ReferenceVariableName
		{
			get => GetProperty(ref _referenceVariableName);
			set => SetProperty(ref _referenceVariableName, value);
		}

		[Ordinal(5)] 
		[RED("referenceVariableShortName")] 
		public CName ReferenceVariableShortName
		{
			get => GetProperty(ref _referenceVariableShortName);
			set => SetProperty(ref _referenceVariableShortName, value);
		}

		[Ordinal(6)] 
		[RED("referenceType")] 
		public CName ReferenceType
		{
			get => GetProperty(ref _referenceType);
			set => SetProperty(ref _referenceType, value);
		}

		[Ordinal(7)] 
		[RED("operator")] 
		public CEnum<EComparisonType> Operator
		{
			get => GetProperty(ref _operator);
			set => SetProperty(ref _operator, value);
		}

		[Ordinal(8)] 
		[RED("referenceValue")] 
		public CVariant ReferenceValue
		{
			get => GetProperty(ref _referenceValue);
			set => SetProperty(ref _referenceValue, value);
		}
	}
}
