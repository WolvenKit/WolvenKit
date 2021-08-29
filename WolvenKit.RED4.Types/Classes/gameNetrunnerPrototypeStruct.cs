using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNetrunnerPrototypeStruct : RedBaseClass
	{
		private CName _key;
		private CResourceAsyncReference<entEntityTemplate> _entityTemplate;

		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("entityTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> EntityTemplate
		{
			get => GetProperty(ref _entityTemplate);
			set => SetProperty(ref _entityTemplate, value);
		}
	}
}
