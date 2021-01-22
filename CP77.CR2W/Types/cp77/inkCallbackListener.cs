using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCallbackListener : CVariable
	{
		[Ordinal(0)]  [RED("functionName")] public CName FunctionName { get; set; }
		[Ordinal(1)]  [RED("object")] public wCHandle<IScriptable> Object { get; set; }

		public inkCallbackListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
