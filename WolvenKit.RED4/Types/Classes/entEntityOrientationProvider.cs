using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entEntityOrientationProvider : entIOrientationProvider
	{
		[Ordinal(0)] 
		[RED("slotComponent")] 
		public CWeakHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CWeakHandle<entSlotComponent>>();
			set => SetPropertyValue<CWeakHandle<entSlotComponent>>(value);
		}

		[Ordinal(1)] 
		[RED("slotId")] 
		public CInt32 SlotId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(3)] 
		[RED("orientationEntitySpace")] 
		public Quaternion OrientationEntitySpace
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public entEntityOrientationProvider()
		{
			SlotId = -1;
			OrientationEntitySpace = new Quaternion { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
