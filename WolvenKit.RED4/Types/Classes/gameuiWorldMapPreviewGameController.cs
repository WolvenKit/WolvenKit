using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiWorldMapPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("viewTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> ViewTemplate
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		[Ordinal(4)] 
		[RED("viewEnvironmentDefinition")] 
		public CResourceReference<worldEnvironmentAreaParameters> ViewEnvironmentDefinition
		{
			get => GetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>();
			set => SetPropertyValue<CResourceReference<worldEnvironmentAreaParameters>>(value);
		}

		[Ordinal(5)] 
		[RED("cursorTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> CursorTemplate
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		[Ordinal(6)] 
		[RED("canvas")] 
		public inkImageWidgetReference Canvas
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public gameuiWorldMapPreviewGameController()
		{
			Canvas = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
