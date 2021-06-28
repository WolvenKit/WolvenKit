using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleRadioStationChanged : redEvent
	{
		private CBool _isActive;
		private CUInt32 _radioIndex;
		private CName _radioStationName;
		private CName _radioSongName;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("radioIndex")] 
		public CUInt32 RadioIndex
		{
			get => GetProperty(ref _radioIndex);
			set => SetProperty(ref _radioIndex, value);
		}

		[Ordinal(2)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get => GetProperty(ref _radioStationName);
			set => SetProperty(ref _radioStationName, value);
		}

		[Ordinal(3)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get => GetProperty(ref _radioSongName);
			set => SetProperty(ref _radioSongName, value);
		}

		public vehicleRadioStationChanged(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
