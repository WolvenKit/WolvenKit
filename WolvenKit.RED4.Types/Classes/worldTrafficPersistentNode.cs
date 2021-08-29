using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficPersistentNode : worldNode
	{
		private CResourceAsyncReference<worldTrafficPersistentResource> _resource;

		[Ordinal(4)] 
		[RED("resource")] 
		public CResourceAsyncReference<worldTrafficPersistentResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}
	}
}
