using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class appearanceAppearancePart : RedBaseClass
	{
		private CResourceAsyncReference<entEntityTemplate> _resource;

		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceAsyncReference<entEntityTemplate> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}
	}
}
