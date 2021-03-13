using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterToListListener : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("object")] public wCHandle<gameObject> Object { get; set; }
		[Ordinal(1)] [RED("funcName")] public CName FuncName { get; set; }

		public RegisterToListListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
