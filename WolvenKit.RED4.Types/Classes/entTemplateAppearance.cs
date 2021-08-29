using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTemplateAppearance : RedBaseClass
	{
		private CName _name;
		private CResourceAsyncReference<appearanceAppearanceResource> _appearanceResource;
		private CName _appearanceName;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("appearanceResource")] 
		public CResourceAsyncReference<appearanceAppearanceResource> AppearanceResource
		{
			get => GetProperty(ref _appearanceResource);
			set => SetProperty(ref _appearanceResource, value);
		}

		[Ordinal(2)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}
	}
}
