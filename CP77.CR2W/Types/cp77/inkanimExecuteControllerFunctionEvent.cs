using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkanimExecuteControllerFunctionEvent : inkanimEvent
	{
		[Ordinal(0)]  [RED("controllerType")] public CName ControllerType { get; set; }
		[Ordinal(1)]  [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(2)]  [RED("params")] public CString Params { get; set; }

		public inkanimExecuteControllerFunctionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
