using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleAudioPSData : CVariable
	{
		private CName _activeRadioStation;
		private CFloat _acousticIsolationFactor;
		private CBool _isPlayerVehicleSummoned;

		[Ordinal(0)] 
		[RED("activeRadioStation")] 
		public CName ActiveRadioStation
		{
			get => GetProperty(ref _activeRadioStation);
			set => SetProperty(ref _activeRadioStation, value);
		}

		[Ordinal(1)] 
		[RED("acousticIsolationFactor")] 
		public CFloat AcousticIsolationFactor
		{
			get => GetProperty(ref _acousticIsolationFactor);
			set => SetProperty(ref _acousticIsolationFactor, value);
		}

		[Ordinal(2)] 
		[RED("isPlayerVehicleSummoned")] 
		public CBool IsPlayerVehicleSummoned
		{
			get => GetProperty(ref _isPlayerVehicleSummoned);
			set => SetProperty(ref _isPlayerVehicleSummoned, value);
		}

		public vehicleAudioPSData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
