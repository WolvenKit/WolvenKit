using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnlocLangId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("langId")] 
		public CUInt8 LangId
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public scnlocLangId()
		{
			LangId = 255;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
