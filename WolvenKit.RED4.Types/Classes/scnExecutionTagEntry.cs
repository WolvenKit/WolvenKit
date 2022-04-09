using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnExecutionTagEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public scnExecutionTagEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
