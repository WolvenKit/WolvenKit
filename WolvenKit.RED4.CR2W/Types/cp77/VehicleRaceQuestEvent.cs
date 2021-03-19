using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRaceQuestEvent : redEvent
	{
		private CEnum<vehicleRaceUI> _mode;
		private CInt32 _maxPosition;
		private CInt32 _maxCheckpoints;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<vehicleRaceUI> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(1)] 
		[RED("maxPosition")] 
		public CInt32 MaxPosition
		{
			get => GetProperty(ref _maxPosition);
			set => SetProperty(ref _maxPosition, value);
		}

		[Ordinal(2)] 
		[RED("maxCheckpoints")] 
		public CInt32 MaxCheckpoints
		{
			get => GetProperty(ref _maxCheckpoints);
			set => SetProperty(ref _maxCheckpoints, value);
		}

		public VehicleRaceQuestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
