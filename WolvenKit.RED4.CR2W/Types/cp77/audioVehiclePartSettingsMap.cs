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
			get
			{
				if (_minAcousticsIsolationFactorValue == null)
				{
					_minAcousticsIsolationFactorValue = (CFloat) CR2WTypeManager.Create("Float", "minAcousticsIsolationFactorValue", cr2w, this);
				}
				return _minAcousticsIsolationFactorValue;
			}
			set
			{
				if (_minAcousticsIsolationFactorValue == value)
				{
					return;
				}
				_minAcousticsIsolationFactorValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("partSettings")] 
		public CArray<audioVehiclePartSettingsMapItem> PartSettings
		{
			get
			{
				if (_partSettings == null)
				{
					_partSettings = (CArray<audioVehiclePartSettingsMapItem>) CR2WTypeManager.Create("array:audioVehiclePartSettingsMapItem", "partSettings", cr2w, this);
				}
				return _partSettings;
			}
			set
			{
				if (_partSettings == value)
				{
					return;
				}
				_partSettings = value;
				PropertySet(this);
			}
		}

		public audioVehiclePartSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
