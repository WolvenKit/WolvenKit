using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForceModule_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("objectRef")] public NodeRef ObjectRef { get; set; }
		[Ordinal(1)] [RED("module")] public CString Module { get; set; }
		[Ordinal(2)] [RED("components")] public CArray<CName> Components { get; set; }

		public questForceModule_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
