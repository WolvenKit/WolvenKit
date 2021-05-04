using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleStartedMountingEvent : redEvent
	{
		private CName _slotID;
		private CBool _isMounting;
		private wCHandle<gameObject> _character;
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
		public wCHandle<gameObject> Character
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

		public vehicleStartedMountingEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
