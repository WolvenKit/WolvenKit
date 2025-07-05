using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LcdScreenSignInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("messegeRecord")] 
		public CWeakHandle<gamedataScreenMessageData_Record> MessegeRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataScreenMessageData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataScreenMessageData_Record>>(value);
		}

		[Ordinal(17)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("onMessegeChangedListener")] 
		public CHandle<redCallbackObject> OnMessegeChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public LcdScreenSignInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
