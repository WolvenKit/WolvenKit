using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityOrientationProvider : entIOrientationProvider
	{
		private CWeakHandle<entSlotComponent> _slotComponent;
		private CInt32 _slotId;
		private CWeakHandle<entEntity> _entity;
		private Quaternion _orientationEntitySpace;

		[Ordinal(0)] 
		[RED("slotComponent")] 
		public CWeakHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}

		[Ordinal(1)] 
		[RED("slotId")] 
		public CInt32 SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(3)] 
		[RED("orientationEntitySpace")] 
		public Quaternion OrientationEntitySpace
		{
			get => GetProperty(ref _orientationEntitySpace);
			set => SetProperty(ref _orientationEntitySpace, value);
		}
	}
}
