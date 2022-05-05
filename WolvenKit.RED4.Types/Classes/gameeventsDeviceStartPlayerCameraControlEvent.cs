using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsDeviceStartPlayerCameraControlEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("playerController")] 
		public CWeakHandle<gameObject> PlayerController
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("initialRotation")] 
		public Vector4 InitialRotation
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("minYaw")] 
		public CFloat MinYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxYaw")] 
		public CFloat MaxYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("minPitch")] 
		public CFloat MinPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxPitch")] 
		public CFloat MaxPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameeventsDeviceStartPlayerCameraControlEvent()
		{
			InitialRotation = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
