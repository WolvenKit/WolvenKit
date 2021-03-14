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
			get
			{
				if (_activeRadioStation == null)
				{
					_activeRadioStation = (CName) CR2WTypeManager.Create("CName", "activeRadioStation", cr2w, this);
				}
				return _activeRadioStation;
			}
			set
			{
				if (_activeRadioStation == value)
				{
					return;
				}
				_activeRadioStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("acousticIsolationFactor")] 
		public CFloat AcousticIsolationFactor
		{
			get
			{
				if (_acousticIsolationFactor == null)
				{
					_acousticIsolationFactor = (CFloat) CR2WTypeManager.Create("Float", "acousticIsolationFactor", cr2w, this);
				}
				return _acousticIsolationFactor;
			}
			set
			{
				if (_acousticIsolationFactor == value)
				{
					return;
				}
				_acousticIsolationFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPlayerVehicleSummoned")] 
		public CBool IsPlayerVehicleSummoned
		{
			get
			{
				if (_isPlayerVehicleSummoned == null)
				{
					_isPlayerVehicleSummoned = (CBool) CR2WTypeManager.Create("Bool", "isPlayerVehicleSummoned", cr2w, this);
				}
				return _isPlayerVehicleSummoned;
			}
			set
			{
				if (_isPlayerVehicleSummoned == value)
				{
					return;
				}
				_isPlayerVehicleSummoned = value;
				PropertySet(this);
			}
		}

		public vehicleAudioPSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
