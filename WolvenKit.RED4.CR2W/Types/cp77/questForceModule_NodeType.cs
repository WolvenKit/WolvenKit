using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForceModule_NodeType : questIVisionModeNodeType
	{
		[Ordinal(0)] [RED("params")] public CArray<questForceVMModule_NodeTypeParams> Params { get; set; }

		public questForceModule_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
