using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackListener : CVariable
	{
		[Ordinal(0)] [RED("object")] public wCHandle<IScriptable> Object { get; set; }
		[Ordinal(1)] [RED("functionName")] public CName FunctionName { get; set; }

		public inkCallbackListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
