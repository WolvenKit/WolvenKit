using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleExternalWindowRequestEvent : redEvent
	{
		private CName _slotName;
		private CBool _shouldOpen;
		private CName _speed;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("shouldOpen")] 
		public CBool ShouldOpen
		{
			get => GetProperty(ref _shouldOpen);
			set => SetProperty(ref _shouldOpen, value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CName Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		public VehicleExternalWindowRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
