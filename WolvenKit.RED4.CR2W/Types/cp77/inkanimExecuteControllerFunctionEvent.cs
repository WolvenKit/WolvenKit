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
			get => GetProperty(ref _controllerType);
			set => SetProperty(ref _controllerType, value);
		}

		[Ordinal(2)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CString Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public inkanimExecuteControllerFunctionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
