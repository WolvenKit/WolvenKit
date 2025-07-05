using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNetrunnerPrototypeStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("entityTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> EntityTemplate
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		public gameNetrunnerPrototypeStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
