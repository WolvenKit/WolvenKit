using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleWindowClose : ActionBool
	{
		private CName _slotID;
		private CName _speed;
		private CBool _isInteractionSource;

		[Ordinal(25)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(26)] 
		[RED("speed")] 
		public CName Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(27)] 
		[RED("isInteractionSource")] 
		public CBool IsInteractionSource
		{
			get => GetProperty(ref _isInteractionSource);
			set => SetProperty(ref _isInteractionSource, value);
		}

		public VehicleWindowClose(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
