using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStreamingSectorInplaceContent : CResource
	{
		[Ordinal(1)] 
		[RED("inplaceResources")] 
		public CArray<CResourceReference<CResource>> InplaceResources
		{
			get => GetPropertyValue<CArray<CResourceReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<CResource>>>(value);
		}

		public worldStreamingSectorInplaceContent()
		{
			InplaceResources = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
