using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AsyncSpawnData : IScriptable
	{
		[Ordinal(0)] [RED("callbackTarget")] public wCHandle<IScriptable> CallbackTarget { get; set; }
		[Ordinal(1)] [RED("controller")] public wCHandle<IScriptable> Controller { get; set; }
		[Ordinal(2)] [RED("functionName")] public CName FunctionName { get; set; }
		[Ordinal(3)] [RED("libraryID")] public CName LibraryID { get; set; }
		[Ordinal(4)] [RED("widgetData")] public CVariant WidgetData { get; set; }

		public AsyncSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
