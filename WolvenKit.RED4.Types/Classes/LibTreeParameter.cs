using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeParameter : RedBaseClass
	{
		private CName _parameterName;
		private CUInt16 _parameterId;
		private CEnum<LibTreeEParameterType> _parameterType;
		private CVariant _value;

		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetProperty(ref _parameterName);
			set => SetProperty(ref _parameterName, value);
		}

		[Ordinal(1)] 
		[RED("parameterId")] 
		public CUInt16 ParameterId
		{
			get => GetProperty(ref _parameterId);
			set => SetProperty(ref _parameterId, value);
		}

		[Ordinal(2)] 
		[RED("parameterType")] 
		public CEnum<LibTreeEParameterType> ParameterType
		{
			get => GetProperty(ref _parameterType);
			set => SetProperty(ref _parameterType, value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
