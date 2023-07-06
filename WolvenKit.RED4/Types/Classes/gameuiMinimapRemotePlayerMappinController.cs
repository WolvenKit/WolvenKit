using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapRemotePlayerMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("rootWidget")] 
		public inkWidgetReference RootWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("shapeWidget")] 
		public inkWidgetReference ShapeWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("dataWidget")] 
		public inkWidgetReference DataWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("playerMappin")] 
		public CWeakHandle<gamemappinsRemotePlayerMappin> PlayerMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsRemotePlayerMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsRemotePlayerMappin>>(value);
		}

		public gameuiMinimapRemotePlayerMappinController()
		{
			RootWidget = new inkWidgetReference();
			ShapeWidget = new inkWidgetReference();
			DataWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
