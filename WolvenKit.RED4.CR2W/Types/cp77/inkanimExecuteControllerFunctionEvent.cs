using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimExecuteControllerFunctionEvent : inkanimEvent
	{
		private CName _controllerType;
		private CName _eventName;
		private CString _params;

		[Ordinal(1)] 
		[RED("controllerType")] 
		public CName ControllerType
		{
			get
			{
				if (_controllerType == null)
				{
					_controllerType = (CName) CR2WTypeManager.Create("CName", "controllerType", cr2w, this);
				}
				return _controllerType;
			}
			set
			{
				if (_controllerType == value)
				{
					return;
				}
				_controllerType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("params")] 
		public CString Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CString) CR2WTypeManager.Create("String", "params", cr2w, this);
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

		public inkanimExecuteControllerFunctionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
