using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAssignCharacter_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _characterRef;
		private gameEntityReference _vehicleRef;
		private CBool _isPlayer;
		private CBool _assign;
		private CName _slotName;
		private CBool _isInstant;
		private CName _entryAnimName;
		private CName _entrySlotName;

		[Ordinal(0)] 
		[RED("characterRef")] 
		public gameEntityReference CharacterRef
		{
			get => GetProperty(ref _characterRef);
			set => SetProperty(ref _characterRef, value);
		}

		[Ordinal(1)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(3)] 
		[RED("assign")] 
		public CBool Assign
		{
			get => GetProperty(ref _assign);
			set => SetProperty(ref _assign, value);
		}

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(5)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		[Ordinal(6)] 
		[RED("entryAnimName")] 
		public CName EntryAnimName
		{
			get => GetProperty(ref _entryAnimName);
			set => SetProperty(ref _entryAnimName, value);
		}

		[Ordinal(7)] 
		[RED("entrySlotName")] 
		public CName EntrySlotName
		{
			get => GetProperty(ref _entrySlotName);
			set => SetProperty(ref _entrySlotName, value);
		}

		public questAssignCharacter_NodeType()
		{
			_assign = true;
			_slotName = "seat_front_left";
			_entrySlotName = "default";
		}
	}
}
