using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotomodeLightInitializedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("light")] 
		public CWeakHandle<entEntity> Light
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public gameuiPhotomodeLightInitializedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
