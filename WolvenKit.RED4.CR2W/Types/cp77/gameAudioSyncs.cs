using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAudioSyncs : CVariable
	{
		private CArray<audioAudSwitch> _switchEvents;
		private CArray<audioAudEventStruct> _playEvents;
		private CArray<audioAudEventStruct> _stopEvents;
		private CArray<audioAudParameter> _parameterEvents;

		[Ordinal(0)] 
		[RED("switchEvents")] 
		public CArray<audioAudSwitch> SwitchEvents
		{
			get
			{
				if (_switchEvents == null)
				{
					_switchEvents = (CArray<audioAudSwitch>) CR2WTypeManager.Create("array:audioAudSwitch", "switchEvents", cr2w, this);
				}
				return _switchEvents;
			}
			set
			{
				if (_switchEvents == value)
				{
					return;
				}
				_switchEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playEvents")] 
		public CArray<audioAudEventStruct> PlayEvents
		{
			get
			{
				if (_playEvents == null)
				{
					_playEvents = (CArray<audioAudEventStruct>) CR2WTypeManager.Create("array:audioAudEventStruct", "playEvents", cr2w, this);
				}
				return _playEvents;
			}
			set
			{
				if (_playEvents == value)
				{
					return;
				}
				_playEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stopEvents")] 
		public CArray<audioAudEventStruct> StopEvents
		{
			get
			{
				if (_stopEvents == null)
				{
					_stopEvents = (CArray<audioAudEventStruct>) CR2WTypeManager.Create("array:audioAudEventStruct", "stopEvents", cr2w, this);
				}
				return _stopEvents;
			}
			set
			{
				if (_stopEvents == value)
				{
					return;
				}
				_stopEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("parameterEvents")] 
		public CArray<audioAudParameter> ParameterEvents
		{
			get
			{
				if (_parameterEvents == null)
				{
					_parameterEvents = (CArray<audioAudParameter>) CR2WTypeManager.Create("array:audioAudParameter", "parameterEvents", cr2w, this);
				}
				return _parameterEvents;
			}
			set
			{
				if (_parameterEvents == value)
				{
					return;
				}
				_parameterEvents = value;
				PropertySet(this);
			}
		}

		public gameAudioSyncs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
