using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questForceModule_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("components")] public CArray<CName> Components { get; set; }
		[Ordinal(1)]  [RED("module")] public CString Module { get; set; }
		[Ordinal(2)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }

		public questForceModule_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
