using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MaterialParameterInstance : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CVariant Data
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}
	}
}
