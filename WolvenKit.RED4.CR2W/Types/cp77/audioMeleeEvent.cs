using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeEvent : CVariable
	{
		private CName _event;
		private CArray<audioAudSimpleParameter> _params;

		[Ordinal(0)] 
		[RED("event")] 
		public CName Event
		{
			get
			{
				if (_event == null)
				{
					_event = (CName) CR2WTypeManager.Create("CName", "event", cr2w, this);
				}
				return _event;
			}
			set
			{
				if (_event == value)
				{
					return;
				}
				_event = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CArray<audioAudSimpleParameter> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CArray<audioAudSimpleParameter>) CR2WTypeManager.Create("array:audioAudSimpleParameter", "params", cr2w, this);
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

		public audioMeleeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
