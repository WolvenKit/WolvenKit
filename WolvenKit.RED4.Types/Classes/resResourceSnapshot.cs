using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class resResourceSnapshot : CResource
	{
		private CArray<CResourceAsyncReference<CResource>> _resources;

		[Ordinal(1)] 
		[RED("resources")] 
		public CArray<CResourceAsyncReference<CResource>> Resources
		{
			get => GetProperty(ref _resources);
			set => SetProperty(ref _resources, value);
		}
	}
}
