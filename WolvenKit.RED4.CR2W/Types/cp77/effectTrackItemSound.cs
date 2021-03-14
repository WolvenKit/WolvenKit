using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemSound : effectTrackItem
	{
		private CName _eventName;
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _params;
		private CName _positionName;
		private CName _emitterMetadataName;
		private CName _rtpcName;
		private CHandle<IEvaluatorFloat> _rtpcValue;

		[Ordinal(3)] 
		[RED("eventName")] 
		public CName EventName
		{
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("positionName")] 
		public CName PositionName
		{
			get
			{
				if (_positionName == null)
				{
					_positionName = (CName) CR2WTypeManager.Create("CName", "positionName", cr2w, this);
				}
				return _positionName;
			}
			set
			{
				if (_positionName == value)
				{
					return;
				}
				_positionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get
			{
				if (_emitterMetadataName == null)
				{
					_emitterMetadataName = (CName) CR2WTypeManager.Create("CName", "emitterMetadataName", cr2w, this);
				}
				return _emitterMetadataName;
			}
			set
			{
				if (_emitterMetadataName == value)
				{
					return;
				}
				_emitterMetadataName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rtpcName")] 
		public CName RtpcName
		{
			get
			{
				if (_rtpcName == null)
				{
					_rtpcName = (CName) CR2WTypeManager.Create("CName", "rtpcName", cr2w, this);
				}
				return _rtpcName;
			}
			set
			{
				if (_rtpcName == value)
				{
					return;
				}
				_rtpcName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("rtpcValue")] 
		public CHandle<IEvaluatorFloat> RtpcValue
		{
			get
			{
				if (_rtpcValue == null)
				{
					_rtpcValue = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "rtpcValue", cr2w, this);
				}
				return _rtpcValue;
			}
			set
			{
				if (_rtpcValue == value)
				{
					return;
				}
				_rtpcValue = value;
				PropertySet(this);
			}
		}

		public effectTrackItemSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
