using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInputHintManagerGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("hintContainerId")] 
		public CName HintContainerId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("baseGroupContainer")] 
		public inkCompoundWidgetReference BaseGroupContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("groupsContainer")] 
		public inkCompoundWidgetReference GroupsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("hintLibRef")] 
		public inkWidgetLibraryReference HintLibRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(6)] 
		[RED("groupLibRef")] 
		public inkWidgetLibraryReference GroupLibRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(7)] 
		[RED("sortInputHints")] 
		public CBool SortInputHints
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("useHideOptim")] 
		public CBool UseHideOptim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiInputHintManagerGameController()
		{
			BaseGroupContainer = new inkCompoundWidgetReference();
			GroupsContainer = new inkCompoundWidgetReference();
			HintLibRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };
			GroupLibRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
