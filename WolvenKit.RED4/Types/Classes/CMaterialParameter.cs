using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameter : ISerializable
	{
		[Ordinal(0)] 
		[RED("parameterName")] 
		public CName ParameterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CUInt32 Register
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CMaterialParameter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
