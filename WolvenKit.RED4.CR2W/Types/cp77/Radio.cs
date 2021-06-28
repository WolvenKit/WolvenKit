using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Radio : InteractiveDevice
	{
		private CArray<RadioStationsMap> _stations;
		private CInt32 _startingStation;
		private CBool _isInteractive;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;

		[Ordinal(96)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetProperty(ref _stations);
			set => SetProperty(ref _stations, value);
		}

		[Ordinal(97)] 
		[RED("startingStation")] 
		public CInt32 StartingStation
		{
			get => GetProperty(ref _startingStation);
			set => SetProperty(ref _startingStation, value);
		}

		[Ordinal(98)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		[Ordinal(99)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(100)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		public Radio(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
