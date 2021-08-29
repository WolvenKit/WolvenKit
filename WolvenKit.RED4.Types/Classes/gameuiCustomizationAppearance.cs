using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCustomizationAppearance : gameuiCensorshipInfo
	{
		private CName _name;
		private CResourceAsyncReference<appearanceAppearanceResource> _resource;
		private CName _definition;

		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(3)] 
		[RED("resource")] 
		public CResourceAsyncReference<appearanceAppearanceResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(4)] 
		[RED("definition")] 
		public CName Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}
	}
}
