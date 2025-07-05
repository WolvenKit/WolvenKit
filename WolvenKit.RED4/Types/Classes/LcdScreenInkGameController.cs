using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LcdScreenInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("defaultUI")] 
		public CWeakHandle<inkCanvasWidget> DefaultUI
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("messegeWidget")] 
		public CWeakHandle<inkTextWidget> MessegeWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("backgroundWidget")] 
		public CWeakHandle<inkLeafWidget> BackgroundWidget
		{
			get => GetPropertyValue<CWeakHandle<inkLeafWidget>>();
			set => SetPropertyValue<CWeakHandle<inkLeafWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("messegeRecord")] 
		public CWeakHandle<gamedataScreenMessageData_Record> MessegeRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataScreenMessageData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataScreenMessageData_Record>>(value);
		}

		[Ordinal(21)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("onMessegeChangedListener")] 
		public CHandle<redCallbackObject> OnMessegeChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public LcdScreenInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
