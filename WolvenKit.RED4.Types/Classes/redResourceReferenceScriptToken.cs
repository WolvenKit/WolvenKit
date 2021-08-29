using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redResourceReferenceScriptToken : RedBaseClass
	{
		private CResourceAsyncReference<CResource> _resource;

		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceAsyncReference<CResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}
	}
}
