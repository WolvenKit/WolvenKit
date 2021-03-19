using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDoorInteraction : ActionBool
	{
		private CName _slotID;
		private CBool _isInteractionSource;

		[Ordinal(25)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(26)] 
		[RED("isInteractionSource")] 
		public CBool IsInteractionSource
		{
			get => GetProperty(ref _isInteractionSource);
			set => SetProperty(ref _isInteractionSource, value);
		}

		public VehicleDoorInteraction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
