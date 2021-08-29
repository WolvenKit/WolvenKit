using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCompiledSmartObjectsNode : worldNode
	{
		private CResourceAsyncReference<gameSmartObjectsCompiledResource> _resource;

		[Ordinal(4)] 
		[RED("resource")] 
		public CResourceAsyncReference<gameSmartObjectsCompiledResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}
	}
}
