using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiWorldMapPreviewGameController : gameuiMenuGameController
	{
		private CResourceAsyncReference<entEntityTemplate> _viewTemplate;
		private CResourceReference<worldEnvironmentAreaParameters> _viewEnvironmentDefinition;
		private CResourceAsyncReference<entEntityTemplate> _cursorTemplate;

		[Ordinal(3)] 
		[RED("viewTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> ViewTemplate
		{
			get => GetProperty(ref _viewTemplate);
			set => SetProperty(ref _viewTemplate, value);
		}

		[Ordinal(4)] 
		[RED("viewEnvironmentDefinition")] 
		public CResourceReference<worldEnvironmentAreaParameters> ViewEnvironmentDefinition
		{
			get => GetProperty(ref _viewEnvironmentDefinition);
			set => SetProperty(ref _viewEnvironmentDefinition, value);
		}

		[Ordinal(5)] 
		[RED("cursorTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> CursorTemplate
		{
			get => GetProperty(ref _cursorTemplate);
			set => SetProperty(ref _cursorTemplate, value);
		}
	}
}
