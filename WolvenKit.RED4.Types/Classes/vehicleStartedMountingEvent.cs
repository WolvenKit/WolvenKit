using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleStartedMountingEvent : redEvent
	{
		private CName _slotID;
		private CBool _isMounting;
		private CWeakHandle<gameObject> _character;
		private CBool _instant;
		private CBool _silent;

		[Ordinal(0)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("isMounting")] 
		public CBool IsMounting
		{
			get => GetProperty(ref _isMounting);
			set => SetProperty(ref _isMounting, value);
		}

		[Ordinal(2)] 
		[RED("character")] 
		public CWeakHandle<gameObject> Character
		{
			get => GetProperty(ref _character);
			set => SetProperty(ref _character, value);
		}

		[Ordinal(3)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		[Ordinal(4)] 
		[RED("silent")] 
		public CBool Silent
		{
			get => GetProperty(ref _silent);
			set => SetProperty(ref _silent, value);
		}
	}
}
