using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehiclePartSettingsMap : audioAudioMetadata
	{
		private CFloat _minAcousticsIsolationFactorValue;
		private CArray<audioVehiclePartSettingsMapItem> _partSettings;

		[Ordinal(1)] 
		[RED("minAcousticsIsolationFactorValue")] 
		public CFloat MinAcousticsIsolationFactorValue
		{
			get => GetProperty(ref _minAcousticsIsolationFactorValue);
			set => SetProperty(ref _minAcousticsIsolationFactorValue, value);
		}

		[Ordinal(2)] 
		[RED("partSettings")] 
		public CArray<audioVehiclePartSettingsMapItem> PartSettings
		{
			get => GetProperty(ref _partSettings);
			set => SetProperty(ref _partSettings, value);
		}

		public audioVehiclePartSettingsMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
