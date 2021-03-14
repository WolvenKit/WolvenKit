using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAcousticZoneParameterMapItem : audioAudioMetadata
	{
		private CName _param;
		private CFloat _value;
		private CFloat _enterCurveTime;
		private CFloat _exitCurveTime;

		[Ordinal(1)] 
		[RED("param")] 
		public CName Param
		{
			get
			{
				if (_param == null)
				{
					_param = (CName) CR2WTypeManager.Create("CName", "param", cr2w, this);
				}
				return _param;
			}
			set
			{
				if (_param == value)
				{
					return;
				}
				_param = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enterCurveTime")] 
		public CFloat EnterCurveTime
		{
			get
			{
				if (_enterCurveTime == null)
				{
					_enterCurveTime = (CFloat) CR2WTypeManager.Create("Float", "enterCurveTime", cr2w, this);
				}
				return _enterCurveTime;
			}
			set
			{
				if (_enterCurveTime == value)
				{
					return;
				}
				_enterCurveTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("exitCurveTime")] 
		public CFloat ExitCurveTime
		{
			get
			{
				if (_exitCurveTime == null)
				{
					_exitCurveTime = (CFloat) CR2WTypeManager.Create("Float", "exitCurveTime", cr2w, this);
				}
				return _exitCurveTime;
			}
			set
			{
				if (_exitCurveTime == value)
				{
					return;
				}
				_exitCurveTime = value;
				PropertySet(this);
			}
		}

		public audioAcousticZoneParameterMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
