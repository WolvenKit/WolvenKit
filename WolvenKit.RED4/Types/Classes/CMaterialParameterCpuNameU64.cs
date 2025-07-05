using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterCpuNameU64 : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CMaterialParameterCpuNameU64()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
