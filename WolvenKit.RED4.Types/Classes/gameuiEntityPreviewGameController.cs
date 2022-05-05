using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiEntityPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("entityToPreview")] 
		public CResourceAsyncReference<entEntityTemplate> EntityToPreview
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		public gameuiEntityPreviewGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
