using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexListItemController : inkListItemController
	{
		[Ordinal(16)] 
		[RED("doMarkNew")] 
		public CBool DoMarkNew
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("stateMapperRef")] 
		public inkWidgetReference StateMapperRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("stateMapper")] 
		public CWeakHandle<ListItemStateMapper> StateMapper
		{
			get => GetPropertyValue<CWeakHandle<ListItemStateMapper>>();
			set => SetPropertyValue<CWeakHandle<ListItemStateMapper>>(value);
		}

		public CodexListItemController()
		{
			StateMapperRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
