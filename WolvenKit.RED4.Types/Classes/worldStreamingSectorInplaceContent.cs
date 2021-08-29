using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStreamingSectorInplaceContent : CResource
	{
		private CArray<CResourceReference<CResource>> _inplaceResources;

		[Ordinal(1)] 
		[RED("inplaceResources")] 
		public CArray<CResourceReference<CResource>> InplaceResources
		{
			get => GetProperty(ref _inplaceResources);
			set => SetProperty(ref _inplaceResources, value);
		}
	}
}
