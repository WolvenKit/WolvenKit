using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PatchNotesGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("notesContainerRef")] 
		public inkCompoundWidgetReference NotesContainerRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("patch20TitleContainerRef")] 
		public inkWidgetReference Patch20TitleContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("patch21TitleContainerRef")] 
		public inkWidgetReference Patch21TitleContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("patch22TitleContainerRef")] 
		public inkWidgetReference Patch22TitleContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("patch23TitleContainerRef")] 
		public inkWidgetReference Patch23TitleContainerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemLibraryName")] 
		public CName ItemLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("outroAnimationName")] 
		public CName OutroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(12)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(13)] 
		[RED("isInputBlocked")] 
		public CBool IsInputBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("data")] 
		public CHandle<PatchNotesPopupData> Data
		{
			get => GetPropertyValue<CHandle<PatchNotesPopupData>>();
			set => SetPropertyValue<CHandle<PatchNotesPopupData>>(value);
		}

		[Ordinal(15)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		public PatchNotesGameController()
		{
			NotesContainerRef = new inkCompoundWidgetReference();
			Patch20TitleContainerRef = new inkWidgetReference();
			Patch21TitleContainerRef = new inkWidgetReference();
			Patch22TitleContainerRef = new inkWidgetReference();
			Patch23TitleContainerRef = new inkWidgetReference();
			ItemLibraryName = "item";
			IntroAnimationName = "intro";
			CloseButtonRef = new inkWidgetReference();
			IsInputBlocked = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
