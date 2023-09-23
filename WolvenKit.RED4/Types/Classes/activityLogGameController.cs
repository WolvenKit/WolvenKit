using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class activityLogGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("readIndex")] 
		public CInt32 ReadIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("writeIndex")] 
		public CInt32 WriteIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("maxSize")] 
		public CInt32 MaxSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("entries")] 
		public CArray<CString> Entries
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(13)] 
		[RED("panel")] 
		public inkVerticalPanelWidgetReference Panel
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("onNewEntries")] 
		public CHandle<redCallbackObject> OnNewEntries
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("onHide")] 
		public CHandle<redCallbackObject> OnHide
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public activityLogGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
