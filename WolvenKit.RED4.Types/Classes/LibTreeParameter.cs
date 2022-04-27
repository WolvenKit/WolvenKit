using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeParameter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("parameterId")] 
		public CUInt16 ParameterId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("parameterType")] 
		public CEnum<LibTreeEParameterType> ParameterType
		{
			get => GetPropertyValue<CEnum<LibTreeEParameterType>>();
			set => SetPropertyValue<CEnum<LibTreeEParameterType>>(value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public LibTreeParameter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
