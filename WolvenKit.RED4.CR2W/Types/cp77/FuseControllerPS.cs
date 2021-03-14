using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseControllerPS : MasterControllerPS
	{
		private CHandle<DeviceTimeTableManager> _timeTableSetup;
		private CInt32 _maxLightsSwitchedAtOnce;
		private CFloat _timeToNextSwitch;
		private CEnum<ELightSwitchRandomizerType> _lightSwitchRandomizerType;
		private TweakDBID _alternativeNameForON;
		private TweakDBID _alternativeNameForOFF;
		private CBool _isCLSInitialized;

		[Ordinal(104)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get
			{
				if (_timeTableSetup == null)
				{
					_timeTableSetup = (CHandle<DeviceTimeTableManager>) CR2WTypeManager.Create("handle:DeviceTimeTableManager", "timeTableSetup", cr2w, this);
				}
				return _timeTableSetup;
			}
			set
			{
				if (_timeTableSetup == value)
				{
					return;
				}
				_timeTableSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("maxLightsSwitchedAtOnce")] 
		public CInt32 MaxLightsSwitchedAtOnce
		{
			get
			{
				if (_maxLightsSwitchedAtOnce == null)
				{
					_maxLightsSwitchedAtOnce = (CInt32) CR2WTypeManager.Create("Int32", "maxLightsSwitchedAtOnce", cr2w, this);
				}
				return _maxLightsSwitchedAtOnce;
			}
			set
			{
				if (_maxLightsSwitchedAtOnce == value)
				{
					return;
				}
				_maxLightsSwitchedAtOnce = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("timeToNextSwitch")] 
		public CFloat TimeToNextSwitch
		{
			get
			{
				if (_timeToNextSwitch == null)
				{
					_timeToNextSwitch = (CFloat) CR2WTypeManager.Create("Float", "timeToNextSwitch", cr2w, this);
				}
				return _timeToNextSwitch;
			}
			set
			{
				if (_timeToNextSwitch == value)
				{
					return;
				}
				_timeToNextSwitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("lightSwitchRandomizerType")] 
		public CEnum<ELightSwitchRandomizerType> LightSwitchRandomizerType
		{
			get
			{
				if (_lightSwitchRandomizerType == null)
				{
					_lightSwitchRandomizerType = (CEnum<ELightSwitchRandomizerType>) CR2WTypeManager.Create("ELightSwitchRandomizerType", "lightSwitchRandomizerType", cr2w, this);
				}
				return _lightSwitchRandomizerType;
			}
			set
			{
				if (_lightSwitchRandomizerType == value)
				{
					return;
				}
				_lightSwitchRandomizerType = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("alternativeNameForON")] 
		public TweakDBID AlternativeNameForON
		{
			get
			{
				if (_alternativeNameForON == null)
				{
					_alternativeNameForON = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeNameForON", cr2w, this);
				}
				return _alternativeNameForON;
			}
			set
			{
				if (_alternativeNameForON == value)
				{
					return;
				}
				_alternativeNameForON = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("alternativeNameForOFF")] 
		public TweakDBID AlternativeNameForOFF
		{
			get
			{
				if (_alternativeNameForOFF == null)
				{
					_alternativeNameForOFF = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeNameForOFF", cr2w, this);
				}
				return _alternativeNameForOFF;
			}
			set
			{
				if (_alternativeNameForOFF == value)
				{
					return;
				}
				_alternativeNameForOFF = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("isCLSInitialized")] 
		public CBool IsCLSInitialized
		{
			get
			{
				if (_isCLSInitialized == null)
				{
					_isCLSInitialized = (CBool) CR2WTypeManager.Create("Bool", "isCLSInitialized", cr2w, this);
				}
				return _isCLSInitialized;
			}
			set
			{
				if (_isCLSInitialized == value)
				{
					return;
				}
				_isCLSInitialized = value;
				PropertySet(this);
			}
		}

		public FuseControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
