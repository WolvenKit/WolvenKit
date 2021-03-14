using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSoundEvent : redEvent
	{
		private CName _eventName;
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _params;
		private CArray<CName> _dynamicParams;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		public entSoundEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
