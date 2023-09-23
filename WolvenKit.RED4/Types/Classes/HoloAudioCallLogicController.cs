using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HoloAudioCallLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("AvatarControllerRef")] 
		public inkWidgetReference AvatarControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("AvatarController")] 
		public CWeakHandle<HudPhoneAvatarController> AvatarController
		{
			get => GetPropertyValue<CWeakHandle<HudPhoneAvatarController>>();
			set => SetPropertyValue<CWeakHandle<HudPhoneAvatarController>>(value);
		}

		[Ordinal(4)] 
		[RED("Owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public HoloAudioCallLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
