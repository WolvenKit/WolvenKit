using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleFinishedMountingEvent : redEvent
	{
		private CName _slotID;
		private CBool _isMounting;
		private wCHandle<gameObject> _character;

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

		public vehicleFinishedMountingEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
