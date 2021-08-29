using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFriendlyFireParams : IScriptable
	{
		private CWeakHandle<gameAttitudeAgent> _attitude;
		private CWeakHandle<entSlotComponent> _slots;
		private CName _attachmentName;
		private CInt32 _slotId;
		private CFloat _spread;
		private CFloat _maxRange;

		[Ordinal(0)] 
		[RED("attitude")] 
		public CWeakHandle<gameAttitudeAgent> Attitude
		{
			get => GetProperty(ref _attitude);
			set => SetProperty(ref _attitude, value);
		}

		[Ordinal(1)] 
		[RED("slots")] 
		public CWeakHandle<entSlotComponent> Slots
		{
			get => GetProperty(ref _slots);
			set => SetProperty(ref _slots, value);
		}

		[Ordinal(2)] 
		[RED("attachmentName")] 
		public CName AttachmentName
		{
			get => GetProperty(ref _attachmentName);
			set => SetProperty(ref _attachmentName, value);
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public CInt32 SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(4)] 
		[RED("spread")] 
		public CFloat Spread
		{
			get => GetProperty(ref _spread);
			set => SetProperty(ref _spread, value);
		}

		[Ordinal(5)] 
		[RED("maxRange")] 
		public CFloat MaxRange
		{
			get => GetProperty(ref _maxRange);
			set => SetProperty(ref _maxRange, value);
		}
	}
}
