using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiEntityPreviewGameController : gameuiMenuGameController
	{
		private CResourceAsyncReference<entEntityTemplate> _entityToPreview;

		[Ordinal(3)] 
		[RED("entityToPreview")] 
		public CResourceAsyncReference<entEntityTemplate> EntityToPreview
		{
			get => GetProperty(ref _entityToPreview);
			set => SetProperty(ref _entityToPreview, value);
		}
	}
}
