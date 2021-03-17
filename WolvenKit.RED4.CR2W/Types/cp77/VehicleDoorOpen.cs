using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorOpen : ActionBool
	{
		private CName _slotID;
		private CBool _shouldAutoClose;
		private CFloat _autoCloseTime;

		[Ordinal(25)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(26)] 
		[RED("shouldAutoClose")] 
		public CBool ShouldAutoClose
		{
			get => GetProperty(ref _shouldAutoClose);
			set => SetProperty(ref _shouldAutoClose, value);
		}

		[Ordinal(27)] 
		[RED("autoCloseTime")] 
		public CFloat AutoCloseTime
		{
			get => GetProperty(ref _autoCloseTime);
			set => SetProperty(ref _autoCloseTime, value);
		}

		public VehicleDoorOpen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
