using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidResourceHandler : RedBaseClass
	{
		private scnRidResourceId _id;
		private CResourceReference<scnRidResource> _ridResource;

		[Ordinal(0)] 
		[RED("id")] 
		public scnRidResourceId Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("ridResource")] 
		public CResourceReference<scnRidResource> RidResource
		{
			get => GetProperty(ref _ridResource);
			set => SetProperty(ref _ridResource, value);
		}
	}
}
