using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotomodeCameraSwitchedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("camera")] 
		public CWeakHandle<entEntity> Camera
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public gameuiPhotomodeCameraSwitchedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
