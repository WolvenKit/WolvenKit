using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_Sound : animAnimEvent
	{
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _params;
		private CArray<CName> _dynamicParams;
		private CName _metadataContext;
		private CName _onlyPlayOn;
		private CName _dontPlayOn;
		private CEnum<animAnimEventGenderAlt> _playerGenderAlt;

		[Ordinal(3)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get
			{
				if (_switches == null)
				{
					_switches = (CArray<audioAudSwitch>) CR2WTypeManager.Create("array:audioAudSwitch", "switches", cr2w, this);
				}
				return _switches;
			}
			set
			{
				if (_switches == value)
				{
					return;
				}
				_switches = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CArray<audioAudParameter>) CR2WTypeManager.Create("array:audioAudParameter", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dynamicParams")] 
		public CArray<CName> DynamicParams
		{
			get
			{
				if (_dynamicParams == null)
				{
					_dynamicParams = (CArray<CName>) CR2WTypeManager.Create("array:CName", "dynamicParams", cr2w, this);
				}
				return _dynamicParams;
			}
			set
			{
				if (_dynamicParams == value)
				{
					return;
				}
				_dynamicParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("metadataContext")] 
		public CName MetadataContext
		{
			get
			{
				if (_metadataContext == null)
				{
					_metadataContext = (CName) CR2WTypeManager.Create("CName", "metadataContext", cr2w, this);
				}
				return _metadataContext;
			}
			set
			{
				if (_metadataContext == value)
				{
					return;
				}
				_metadataContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("onlyPlayOn")] 
		public CName OnlyPlayOn
		{
			get
			{
				if (_onlyPlayOn == null)
				{
					_onlyPlayOn = (CName) CR2WTypeManager.Create("CName", "onlyPlayOn", cr2w, this);
				}
				return _onlyPlayOn;
			}
			set
			{
				if (_onlyPlayOn == value)
				{
					return;
				}
				_onlyPlayOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("dontPlayOn")] 
		public CName DontPlayOn
		{
			get
			{
				if (_dontPlayOn == null)
				{
					_dontPlayOn = (CName) CR2WTypeManager.Create("CName", "dontPlayOn", cr2w, this);
				}
				return _dontPlayOn;
			}
			set
			{
				if (_dontPlayOn == value)
				{
					return;
				}
				_dontPlayOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("playerGenderAlt")] 
		public CEnum<animAnimEventGenderAlt> PlayerGenderAlt
		{
			get
			{
				if (_playerGenderAlt == null)
				{
					_playerGenderAlt = (CEnum<animAnimEventGenderAlt>) CR2WTypeManager.Create("animAnimEventGenderAlt", "playerGenderAlt", cr2w, this);
				}
				return _playerGenderAlt;
			}
			set
			{
				if (_playerGenderAlt == value)
				{
					return;
				}
				_playerGenderAlt = value;
				PropertySet(this);
			}
		}

		public animAnimEvent_Sound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
